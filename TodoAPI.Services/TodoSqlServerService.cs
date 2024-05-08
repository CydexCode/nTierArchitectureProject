using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataAccess;
using TodoAPI.Models;
using TodoAPI.Services;

namespace TodoAPI.Services
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
