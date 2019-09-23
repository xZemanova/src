using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public interface IRestaurantManager: IDomainService
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetRestaurantById(int id);
        Task<Restaurant> Create(Restaurant entity);
        void Update(Restaurant entity);
        void Delete(int id);
    }
}
