using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using BurgerFanatics.Authorization.Roles;
using BurgerFanatics.Authorization.Users;
using BurgerFanatics.Models;
using BurgerFanatics.Pictures.Dto;
using BurgerFanatics.Restaurants.Dto;
using BurgerFanatics.Reviews.Dto;
using BurgerFanatics.Roles.Dto;
using BurgerFanatics.Users.Dto;

namespace BurgerFanatics
{
    [DependsOn(typeof(BurgerFanaticsCoreModule), typeof(AbpAutoMapperModule))]
    public class BurgerFanaticsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpAutoMapper().UseStaticMapper = false;

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                #region Restaurants
                cfg.CreateMap<CreateRestaurant, Restaurant>().ReverseMap();
                cfg.CreateMap<Restaurant, GetRestaurant>().ReverseMap();
                cfg.CreateMap<List<Restaurant>, List<GetRestaurant>>().ReverseMap();
                cfg.CreateMap<UpdateRestaurant, Restaurant>().ReverseMap();
                #endregion

                #region Reviews
                cfg.CreateMap<CreateReview, Review>();
                cfg.CreateMap<Review, GetReview>().ReverseMap();
                cfg.CreateMap<List<Review>, List<GetReview>>().ReverseMap();
                cfg.CreateMap<UpdateReview, Review>().ReverseMap();
                #endregion

                #region Pictures
                cfg.CreateMap<PictureCreate, Picture>();
                cfg.CreateMap<Picture, GetPicture>().ReverseMap();
                cfg.CreateMap<List<Picture>, List<GetPicture>>().ReverseMap();
                cfg.CreateMap<UpdatePicture, Picture>().ReverseMap();
                #endregion

                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                cfg.CreateMap<CreateRoleDto, Role>();
                cfg.CreateMap<RoleDto, Role>();
                cfg.CreateMap<Role, RoleDto>().ForMember(x => x.GrantedPermissions,
                    opt => opt.MapFrom(x => x.Permissions.Where(p => p.IsGranted)));

                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }
    }
}
