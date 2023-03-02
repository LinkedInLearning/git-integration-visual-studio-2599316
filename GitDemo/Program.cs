// See https://aka.ms/new-console-template for more information
using GitDemo;

Console.WriteLine("Hello, World!");

var todoItems = new List<TodoItem>();

var todo = new TodoItem { Id = 1, Title = "Anwendung fertigstellen", IsDone = false };
todoItems.Add(todo);

foreach (var item in todoItems)
{
    Console.WriteLine($"{item.Title}, Erledigt: {item.IsDone}");
}
Console.ReadLine();