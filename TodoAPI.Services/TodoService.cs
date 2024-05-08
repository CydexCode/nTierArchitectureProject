using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.DataAccess;
using TodoAPI.Models;
using TodoAPI.Services;

namespace TodoAPI.Services
{
    public class TodoService : ITodoRepository
    {
        // Get Todos
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get vegitables",
                Description = "Get vegitables for the week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plans",
                Description = "Water all the plants quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
            };
            todos.Add(todo3);

            return todos;
        }
    }
}