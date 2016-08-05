using DropDownListDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace DropDownListDemo.Controllers
{
    public class HomeController : Controller
    {
        List<Book> books;
        public HomeController()
        {
            books = new List<Book>()
            {
                new Book() {ID=1,Name="语文" },
                new Book() {ID=2,Name="数学" },
                new Book() {ID=2,Name="政治" },
                new Book() {ID=3,Name="英语" },
                new Book() {ID=3,Name="美术" },
                new Book() {ID=4,Name="历史" }
            };
        }
        // GET: Home
        public ActionResult Index()
        {

            ViewModel model = new ViewModel();
            model.ViewModels = books.Select(x=>new SelectListItem() {
                Text=x.Name,
                Value=x.ID.ToString()
            });
            return View(model);
        }

        public JsonResult Get(string id)
        {
            var list = books.Where(x => x.ID.Equals(int.Parse(id))).ToList();
            return Json(JsonConvert.SerializeObject(list),JsonRequestBehavior.AllowGet);
        }
    }
}