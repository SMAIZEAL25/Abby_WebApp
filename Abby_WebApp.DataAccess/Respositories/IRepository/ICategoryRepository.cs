using Abby_WebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby_WebApp.DataAccess.Respositories.IRepository
{
    internal interface ICategoryRepository : IRepository<Category>
    {
        void update(Category category);

        void Save();
    }
}
