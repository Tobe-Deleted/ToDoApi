using ToDoAPI.Models;
using System.Collections.Generic;

namespace ToDoAPI.Repositories
{
    public interface ToDoAPIRepositories
    {
        List<ToDoItem> GetAll();
        ToDoItem GetById(int id);
        void Add(ToDoItem item);
        void Update(ToDoItem item);
        void Delete(int id);
    }
}