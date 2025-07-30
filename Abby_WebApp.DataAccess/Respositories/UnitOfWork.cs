using Abby_WebApp.Data;
using Abby_WebApp.DataAccess.Respositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby_WebApp.DataAccess.Respositories
{
    
       public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDb;

        public UnitOfWork(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
            Category = new CategoryRepository(_applicationDb);
            FoodType = new FoodTypeRepository(_applicationDb);


        }

        public ICategoryRepository Category { get; private set; }
        public IFoodTypeRepository FoodType { get; private set; }

        public IMenuItemRepository MenuItem {  get; private set; }



        public void Dispose()
        {
            _applicationDb.Dispose();
        }

        public void Save()
        {
            _applicationDb.SaveChanges();
        }
    }
}
