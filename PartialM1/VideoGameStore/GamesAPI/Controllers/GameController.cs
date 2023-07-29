
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VideoGameStore.Data;
using VideoGameStore.Models;
using System.Xml.Linq;

namespace GamesAPI.Controllers
{
    public class ItemController : Controller
    {
        private ISqlData _db;
        public IActionResult Index()
        {
            return View();
        }
        public ItemController(ISqlData db)
        {
            _db = db;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("/api/[controller]/add")]
        public ActionResult AddPost([FromBody] Item form)
        {
            Item item = new Item();
            item.Code = form.Code;
            item.Name = form.Name;
            item.Brand = form.Brand;
            item.UnitPrice = form.UnitPrice;
            item.DateOrdered = DateTime.Now;
            _db.AddItem(item);
            return Ok("Order Created.");
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("/api/[controller]/list")]
        public ActionResult ListItems()
        {
            List<ItemList> items = _db.ListItems();
            return Ok(items);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult GetItems(int id)
        {
            ItemList item = _db.GetItems(id);
            return Ok(item);
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("/api/[controller]/delete/{id}")]
        public ActionResult deleteEmployee(int id)
        {
            _db.deleteItem(id);
            return Ok("Deleted");
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("/api/[controller]/update/{id}")]
        public ActionResult updateItem(int id, [FromBody] Item form)
        {
            Item item = new Item();
            item.Code = form.Code;
            item.Name = form.Name;
            item.Brand = form.Brand;
            item.UnitPrice = form.UnitPrice;
            item.DateOrdered = DateTime.Now;
            _db.updateItem(id, form);
            return Ok("Updated");
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/api/[controller]/register")]
        public ActionResult Register([FromBody] Users user)
        {
            Users use = new Users();
            use.Username = user.Username;
            use.Password = user.Password;
            _db.Register(user);
            return Ok("User Registered.");
        }
    }
}
