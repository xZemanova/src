using Abp.Application.Services;
using AutoMapper;
using BurgerFanatics.Models;
using BurgerFanatics.Restaurants.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Restaurants
{
    class RestaurantAppService : ApplicationService, IRestaurantAppService
    {
        private readonly IRestaurantManager _restaurantManager;
        public RestaurantAppService(IRestaurantManager RestaurantManager)
        {
            _restaurantManager = RestaurantManager;
        }

        public async Task Create(CreateRestaurant input)
        {
            Restaurant output = Mapper.Map<CreateRestaurant, Restaurant>(input);
            await _restaurantManager.Create(output);
        }

        public void Delete(DeleteRestaurant input)
        {
            _restaurantManager.Delete(input.Id);
        }

        public GetRestaurant GetRestaurantById(GetRestaurantId input)
        {
            var getRestaurant = _restaurantManager.GetRestaurantById(input.Id);
            GetRestaurant output = Mapper.Map<Restaurant, GetRestaurant>(getRestaurant);
            return output;
        }

        public IEnumerable<GetRestaurant> ListAll()
        {
            var getAll = _restaurantManager.GetAll().ToList();
            List<GetRestaurant> output = Mapper.Map<List<Restaurant>, List<GetRestaurant>>(getAll);
            return output;
        }

        public void Update(UpdateRestaurant input)
        {
            Restaurant output = Mapper.Map<UpdateRestaurant, Restaurant>(input);
            _restaurantManager.Update(output);
        }
    }
}
