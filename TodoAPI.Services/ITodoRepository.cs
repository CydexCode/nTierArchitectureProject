using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataAccess;
using TodoAPI.Models;

namespace TodoAPI.Services
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
    }
}
