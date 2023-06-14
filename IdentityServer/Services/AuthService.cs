using AutoMapper;
using IdentityServer.Database;
using IdentityServer.Database.Entities;
using IdentityServer.Models.SignIn;
using IdentityServer.Models.SignUp;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IdentityServer.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AspNetIdentityDbContext _context;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthService(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            AspNetIdentityDbContext context,
            IJwtTokenGenerator jwtTokenGenerator
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<SignInResponse> SignIn(SignInRequest request)
        {
            var user = await _context.AppUsers.Include("AppUserRoles.AppRole").FirstOrDefaultAsync(x => x.UserName.ToLower() == request.UserName);
            if (user is null)
            {
                throw new Exception("User Not Found");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!result.Succeeded)
            {
                throw new Exception("Invalid Credentials");
            }

            var claims = await _userManager.GetClaimsAsync(user);
            var token = await _jwtTokenGenerator.GenerateToken(user, claims);

            return new SignInResponse
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.UserName,
                EmailConfirmed = user.EmailConfirmed,
                TwoFactorEnabled = user.TwoFactorEnabled,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                Token = token,
                CreatedAt = user.CreatedAt,
                LastModified = user.LastModified,
                RoleNames = string.Join(", ", user.AppUserRoles.Select(x => x.AppRole.Name).ToList())
            };
        }

        public async Task<SignUpResponse> SignUp(SignUpRequest request)
        {
            var userFromDb = await _context.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == request.UserName);
            if (userFromDb is not null)
            {
                throw new Exception("User with that username already exists!");
            }

            var user = new Database.Entities.AppUser
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                NormalizedUserName = request.UserName.ToUpper(),
                Email = request.Email,
                NormalizedEmail = request.Email.ToUpper()
            };

            await _userManager.CreateAsync(user, request.Password);

            var userRole = new Database.Entities.AppUserRoles
            {
                UserId = user.Id,
                RoleId = 2,
                CreatedAt = DateTime.UtcNow,
                LastModified = null
            };

            await _context.AppUserRoles.AddAsync(userRole);
            await _userManager.AddToRoleAsync(user, "Manager");
            await _context.SaveChangesAsync();

            var claims = await _userManager.GetClaimsAsync(user);
            var token = await _jwtTokenGenerator.GenerateToken(user, claims);

            return new SignUpResponse
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.UserName,
                EmailConfirmed = user.EmailConfirmed,
                TwoFactorEnabled = user.TwoFactorEnabled,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                Token = token,
                CreatedAt = user.CreatedAt,
                LastModified = user.LastModified,
                RoleNames = string.Join(", ", user.AppUserRoles.Select(x => x.AppRole.Name).ToList())
            };
        }
    }
}
