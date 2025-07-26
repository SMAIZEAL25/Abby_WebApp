using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby_WebApp.DataAccess.Respositories.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        IFoodTypeRepository FoodType { get; }

        void Save();
    }
}
