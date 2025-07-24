using Abby_WebApp.Data;
using Abby_WebApp.DataAccess.Respositories.IRepository;
using Abby_WebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abby_WebApp.DataAccess.Respositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext applicationDb) : base(applicationDb)
        {
            _context = applicationDb;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void update(Category category)
        {
            var ObjFromDB = _context.Categories.FirstOrDefault(u => u.Id == category.Id);

            ObjFromDB.Name = category.Name;
            ObjFromDB.DisplayOrder= category.DisplayOrder;
        }

    }
}
