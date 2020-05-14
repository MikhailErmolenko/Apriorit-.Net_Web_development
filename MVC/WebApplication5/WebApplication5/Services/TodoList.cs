using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Services
{
    public class TodoList
    {
        private List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
        private int Count { get; set; } = 0;

        public TodoItem Add(TodoItem item)
        {
            item.Id = ++Count;
            TodoItems.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            var item = TodoItems.FirstOrDefault(t => t.Id == id);
            
            if (item != null)
            {
                TodoItems.Remove(item);
                return true;
            }
            return false;
        }

        public IEnumerable<TodoItem> GetItems() => TodoItems.ToList(); 
        // return a copy to make sure that it will never be changed 
    }
}
