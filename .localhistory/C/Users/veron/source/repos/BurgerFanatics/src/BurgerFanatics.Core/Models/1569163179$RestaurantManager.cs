using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public class RestaurantManager : DomainService, IRestaurantManager
    {
        private readonly IRepository<Restaurant> _repositoryRestaurant;
        public RestaurantManager(IRepository<Restaurant> repositoryRestaurant)
        {
            _repositoryRestaurant = repositoryRestaurant;
        }

        public async Task<Restaurant> Create(Restaurant entity)
        {
            var restaurant = _repositoryRestaurant.FirstOrDefault(x => x.Id == entity.Id);
            if (restaurant != null)
            {
                throw new UserFriendlyException("Already exists");
            }
            else
            {
                return await _repositoryRestaurant.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var review = _repositoryRestaurant.FirstOrDefault(x => x.Id == id);
            if (review != null)
            {
                throw new UserFriendlyException("No data found");
            }
            else
            {
                _repositoryRestaurant.Delete(review);
            }
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _repositoryRestaurant.GetAll();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _repositoryRestaurant.Get(id);
        }

        public void Update(Restaurant entity)
        {
            _repositoryRestaurant.Update(entity);
        }
    }
