using System.Text.Json;

namespace GitDemo.Repository
{
    public class TodoRepository
    {
        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "todos.json");

        public void SaveTodos(List<TodoItem> todos)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(todos, options);
            File.WriteAllText(_filePath, json);
        }

        public List<TodoItem> LoadTodos()
        {
            if (!File.Exists(_filePath))
            {
                var todoItems =  new List<TodoItem>();
                var todo = new TodoItem { Id = 1, Title = "Anwendung fertigstellen!", IsDone = false };
                todoItems.Add(todo);
                return todoItems;
            }

            string json = File.ReadAllText(_filePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<TodoItem>>(json, options);
        }
    }
}
