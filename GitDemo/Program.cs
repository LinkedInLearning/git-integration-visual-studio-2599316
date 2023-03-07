using GitDemo;
using GitDemo.Repository;
Console.WriteLine("Todo-Demo V1.0");
Console.WriteLine("==============");
Console.WriteLine();

var repository = new TodoRepository();

var todos = repository.LoadTodos();

foreach (var item in todos)
{
    Console.WriteLine($"#{item.Id} - {item.Title}, ({(item.IsDone ? "erledigt [x]": "offen [ ]")})");
}
Console.WriteLine("Bitte eine Taste drücken.");
Console.ReadLine();
