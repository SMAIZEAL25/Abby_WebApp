using Abby_WebApp.Data;
using Abby_WebApp.DataAccess.Respositories.IRepository;
using Abby_WebApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby_WebApp.DataAccess.Respositories
{
    internal class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FoodTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Update(FoodType obj)
        {
            var ObjFromDB = _dbContext.FoodType.FirstOrDefault(u => u.Id == obj.Id);

            ObjFromDB.Name = obj.Name;
            
        }
    }
}
