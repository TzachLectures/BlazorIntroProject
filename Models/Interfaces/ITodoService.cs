namespace BlazorProject.Models.Interfaces
{
    public interface ITodoService
    {
        List<TodoItem> GetTodos();
        void AddTodo(TodoItem item);
        void DeleteTodo(Guid id);
        void ToggleTodoDone(Guid id);
    }
}
