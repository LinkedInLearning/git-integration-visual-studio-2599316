using GitDemo.Repository;
Console.WriteLine("Todo-Demo V1.0");
Console.WriteLine("==============");
Console.WriteLine();

var repository = new TodoRepository();

var todos = repository.LoadTodos();

foreach (var todo in todos)
{
    Console.WriteLine($"#{todo.Id} - {todo.Title}, ({(todo.IsDone ? "erledigt [x]": "offen [ ]")})");
}
Console.WriteLine("Bitte eine Taste drücken.");
Console.ReadLine();
