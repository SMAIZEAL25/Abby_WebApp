using Abby_WebApp.DataAccess.Respositories.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Abby_WebApp.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class MenuItem : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuItem(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var menuItemList = _unitOfWork.MenuItem.GetAll(includeProperties: "Category,FoodType");
            return Json(new { data = menuItemList });
        }
    }
}
