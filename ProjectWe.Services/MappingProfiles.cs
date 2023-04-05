using AutoMapper;
using ProjectWe.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Database.AppUser, Models.AppUser>()
                .ForMember(dest => dest.RoleNames, opt => opt.MapFrom(src => string.Join(", ", src.AppUserRoles!.Select(x => x.AppRole!.Name).ToList())));
            CreateMap<UserInsertRequest, Database.AppUser>();
            CreateMap<UserUpdateRequest, Database.AppUser>();

            CreateMap<Database.AppRole, Models.AppRole>();
            CreateMap<RoleUpsertRequest, Database.AppRole>();

            CreateMap<Database.AppUserRoles, Models.AppUserRoles>();

            CreateMap<Database.City, Models.City>();
            CreateMap<CityUpsertRequest, Database.City>();

            CreateMap<Database.Status, Models.Status>();
            CreateMap<StatusUpsertRequest, Database.Status>();

            CreateMap<Database.Category, Models.Category>();
            CreateMap<CategoryUpsertRequest, Database.Category>();

            CreateMap<Database.Project, Models.Project>();
            CreateMap<ProjectUpsertRequest, Database.Project>();

            CreateMap<Database.Objective, Models.Objective>();
            CreateMap<ObjectiveUpsertRequest, Database.Objective>();

            CreateMap<Database.Output, Models.Output>();
            CreateMap<OutputUpsertRequest, Database.Output>();

            CreateMap<Database.Activity, Models.Activity>();
            CreateMap<ActivityInsertRequest, Database.Activity>();
            CreateMap<ActivityUpdateRequest, Database.Activity>();

            CreateMap<Database.Budget, Models.Budget>();
            CreateMap<BudgetInsertRequest, Database.Budget>();
            CreateMap<BudgetUpdateRequest, Database.Budget>();
        }
    }
}
