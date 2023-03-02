// See https://aka.ms/new-console-template for more information
using GitDemo;

var todoItems = new List<TodoItem>();

var todo = new TodoItem { Id = 1, Title = "Anwendung fertigstellen!", IsDone = false };
todoItems.Add(todo);

foreach (var item in todoItems)
{
    Console.WriteLine($"#{item.Id} - {item.Title}, {(item.IsDone ? "erledigt": "offen")}");
}
Console.ReadLine();