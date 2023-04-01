using ProjectWe.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectWe.Models.Exceptions;
using ProjectWe.Services.Database;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using ProjectWe.Models.SearchObjects;

namespace ProjectWe.Services
{
    public class UsersService : BaseCRUDService<Models.AppUser, Database.AppUser, UserSearchObject, UserInsertRequest, UserUpdateRequest>, IUsersService
    {
        private readonly UserManager<Database.AppUser> _userManager;
        private readonly SignInManager<Database.AppUser> _singInManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public UsersService(_160020Context context, UserManager<Database.AppUser> userManager, SignInManager<Database.AppUser> singInManager, IJwtTokenGenerator jwtTokenGenerator, IMapper mapper) : base(context, mapper)
        {
            _userManager = userManager;
            _singInManager = singInManager;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public override Models.AppUser Insert(UserInsertRequest insert)
        {
            if (insert.Password != insert.ConfirmPassword)
            {
                throw new UserException("Password confirmation did not match the password!");
            }

            var entity = base.Insert(insert);

            var userRole = new AppUserRoles
            {
                UserId = entity.Id,
                RoleId = 2, // 2 stands for manager,
                CreatedAt = DateTime.UtcNow,
                LastModified = null,
            };

            Context.UserRoles.Add(userRole);
            Context.SaveChanges();

            return entity;
        }

        public override void BeforeInsert(UserInsertRequest insert, Database.AppUser entity)
        {
            entity.NormalizedEmail = entity.Email.ToUpper();
            entity.NormalizedUserName = entity.UserName.ToUpper();
            entity.CreatedAt = DateTime.UtcNow;
            entity.LastModified = null;
            entity.PasswordHash = _userManager.PasswordHasher.HashPassword(entity, insert.Password);
            entity.SecurityStamp = Guid.NewGuid().ToString();
            entity.ConcurrencyStamp = Guid.NewGuid().ToString();

            base.BeforeInsert(insert, entity);
        }

        public override Models.AppUser Update(int id, UserUpdateRequest update)
        {
            if (update.Password != update.ConfirmPassword)
            {
                throw new UserException("Password confirmation did not match the password!");
            }

            var entity = base.Update(id, update);

            Context.SaveChanges();

            return entity;
        }

        public override void BeforeUpdate(UserUpdateRequest update, Database.AppUser entity)
        {
            entity.NormalizedEmail = entity.Email.ToUpper();
            entity.PasswordHash = _userManager.PasswordHasher.HashPassword(entity, update.Password);
            entity.SecurityStamp = Guid.NewGuid().ToString();
            entity.ConcurrencyStamp = Guid.NewGuid().ToString();
            entity.LastModified = DateTime.UtcNow;

            base.BeforeUpdate(update, entity);
        }


        public override IQueryable<Database.AppUser> AddFilter(IQueryable<Database.AppUser> query, UserSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                filteredQuery = filteredQuery.Where(x => x.UserName == search.Username);
            }

            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                filteredQuery = filteredQuery.Where(x => x.Email == search.Email);
            }

            return filteredQuery;
        }

        public override IQueryable<Database.AppUser> AddInclude(IQueryable<Database.AppUser> query, UserSearchObject search = null)
        {
            if (search?.IncludeRoles == true)
            {
                query = query.Include("UserRoles.Role");
            }

            return query;
        }

        public async Task<Models.AppUser> SignIn(UserSignInRequest signin)
        {
            var user = await Context.Users.Include("AppUserRoles.AppRole").FirstOrDefaultAsync(x => x.UserName.ToLower() == signin.UserName);
            if (user is null)
            {
                throw new UserException("User Not Found");
            }

            var result = await _singInManager.CheckPasswordSignInAsync(user, signin.Password, false);
            if(!result.Succeeded)
            {
                throw new UserException("Invalid Credentials");
            }

            var claims = await _userManager.GetClaimsAsync(user);
            var token = await _jwtTokenGenerator.GenerateToken(user, claims);

            return Mapper.Map<Models.AppUser>(user, opt => opt.AfterMap((src, dest) => dest.Token = token));
        }

        public async Task<Models.AppUser> SignUp(UserInsertRequest insert)
        {
            var userFromDb = await Context.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == insert.UserName);
            if (userFromDb is not null)
            {
                throw new UserException("User with that username already exists!");
            }

            var user = new Database.AppUser {
                FirstName = insert.FirstName,
                LastName = insert.LastName,
                UserName = insert.UserName,
                NormalizedUserName = insert.UserName.ToUpper(),
                Email = insert.Email,
                NormalizedEmail = insert.Email.ToUpper()
            };

            await _userManager.CreateAsync(user, insert.Password);

            var userRole = new Database.AppUserRoles
            {
                UserId = user.Id,
                RoleId = 2,
                CreatedAt = DateTime.UtcNow,
                LastModified = null
            };

            await Context.AppUserRoles.AddAsync(userRole);
            await _userManager.AddToRoleAsync(user, "Manager");
            await Context.SaveChangesAsync();

            var claims = await _userManager.GetClaimsAsync(user);
            var token = await _jwtTokenGenerator.GenerateToken(user, claims);

            return Mapper.Map<Models.AppUser>(user, opt => opt.AfterMap((src, dest) => dest.Token = token));
        }
    }
}
