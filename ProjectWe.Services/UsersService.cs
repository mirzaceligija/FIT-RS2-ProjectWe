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

            foreach (var roleId in insert.AppRoleIdsList)
            {
                var userRole = new AppUserRoles
                {
                    UserId = entity.Id,
                    RoleId = roleId,
                    CreatedAt = DateTime.UtcNow,
                    LastModified = null,
                };

                Context.UserRoles.Add(userRole);
            }

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

            var existingRoles = Context.UserRoles.Where(x => x.UserId == entity.Id).ToList();

            var rolesToAdd = update.AppRoleIdsList
                .Where(roleId => !existingRoles.Any(ur => ur.RoleId == roleId))
                .Select(roleId => new AppUserRoles {
                    UserId = entity.Id,
                    RoleId = roleId,
                    CreatedAt = DateTime.UtcNow,
                    LastModified = null,
                }).ToList();

            var rolesToDelete = existingRoles
                .Where(ur => !update.AppRoleIdsList.Contains(ur.RoleId))
                .ToList();

            foreach (var role in rolesToAdd)
            {
                Context.UserRoles.Add(role);
            }

            foreach (var role in rolesToDelete)
            {
                Context.UserRoles.Remove(role);
            }

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
                query = query.Include("AppUserRoles.AppRole");
            }

            return query;
        }
    }
}
