using Abp.Application.Services;
using BurgerFanatics.Restaurants.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Restaurants
{
    public interface IRestaurantAppService : IApplicationService
    {
        IEnumerable<GetRestaurant> ListAll();
        Task Create(CreateRestaurant input);
        void Update(UpdateRestaurant input);
        void Delete(DeleteRestaurant input);
        GetRestaurant GetRestaurantById(GetRestaurantId input);
    }
}
