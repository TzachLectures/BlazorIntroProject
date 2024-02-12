using BlazorProject.Models;
using BlazorProject.Models.Interfaces;

namespace BlazorProject.Services
{
    public class TodoService : ITodoService
    {
        private List<TodoItem> _todos = new List<TodoItem>();
        public List<TodoItem> GetTodos() { return _todos; }
        public void AddTodo(TodoItem item)
        {
            _todos.Add(item);
        }
        public void DeleteTodo(Guid id) {
            TodoItem? item = _todos.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                _todos.Remove(item);
            }
        }
        public void ToggleTodoDone(Guid id)
        {
            TodoItem? item = _todos.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                item.IsDone = !item.IsDone;
            }
        }

    }
}
