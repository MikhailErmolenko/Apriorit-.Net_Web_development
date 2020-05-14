using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication5.Models;
using WebApplication5.Services;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoList todoList;

        public HomeController(TodoList todoList)
        {
            this.todoList = todoList;
        }

        public IActionResult Index()
        {
            var items = todoList.GetItems();
            return View(items);
        }

        [HttpPost("Home/Add")]
        public IActionResult Add(string text)
        {
            var itemWithId = todoList.Add(new TodoItem
            {
                Text = text
            });
            return PartialView("_ToDoItem", itemWithId);
        }

        [HttpPost("Home/Remove")]
        public IActionResult Remove(int id)
        {
            var result = todoList.Delete(id);
            return Json(result);
        }

    }
}
