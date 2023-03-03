using GitDemo.Repository;

var repository = new TodoRepository();

var todoItems = repository.LoadTodos();

foreach (var item in todoItems)
{
    Console.WriteLine($"#{item.Id} - {item.Title}, ({(item.IsDone ? "erledigt [x]": "offen [ ]")})");
}
Console.WriteLine("Bitte eine Taste drücken.");
Console.ReadLine();