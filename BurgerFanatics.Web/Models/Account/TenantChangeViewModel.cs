using Abp.AutoMapper;
using BurgerFanatics.Sessions.Dto;

namespace BurgerFanatics.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}