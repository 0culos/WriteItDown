using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WriteItDown.Models;

namespace WriteItDown.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category { Id = 1, Name = "Work" });
            list.Add(new Category { Id = 2, Name = "Market" });
            list.Add(new Category { Id = 3, Name = "Health" });
            list.Add(new Category { Id = 4, Name = "Finace" });
            list.Add(new Category { Id = 5, Name = "Leisure" });
            return View(list);
        }
    }
}
