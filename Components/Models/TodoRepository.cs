namespace ToDo.Components.Models;

public class TodoRepository
{
    private static List<Todo> Todos =
    [
        new(){Id = 1, Name = "do something", IsDone = "Unfinished"},
        new(){Id = 2, Name = "do something else",IsDone = "Unfinished" },
        new(){Id = 3, Name = "do nothing", IsDone = "Unfinished" },
        new(){Id = 4, Name = "do your mom", IsDone = "Unfinished"}
    ];
    //metoda dodawania id do nowego todo
    public static void AddTodo(Todo ToAdd)
    {
        if (Todos.Count > 0)
        {
            var maxId = Todos.Max(s => s.Id);
            ToAdd.Id = maxId + 1;
            Todos.Add(ToAdd);
        }
        else
        {
            ToAdd.Id = 1;
            Todos.Add(ToAdd);
        }
    }
    //zbiera liste obiektow na zewnatrz
    public static List<Todo> GetTodos() => Todos;

    
    //sprawdza po tagu zgodnosc po czym przypisuje jedno do drugiego (nie ogarniam cry emoji)
    public static List<Todo> GetTodoByTag(string tag)
    {
        return Todos.Where(s => s.IsDone != null && s.IsDone.Equals(tag, StringComparison.OrdinalIgnoreCase) ).ToList();
    }

    public static Todo? GetTodoById(int id)
    {
        var todo = Todos.FirstOrDefault(s => s.Id == id);
        if (todo != null)
        {
            return new Todo
            {
                Id = todo.Id,
                Name = todo.Name,
                IsDone = todo.IsDone,
            };
        }
        return null;
    }

    public static void UpdateTodo(int todoId, Todo todo)
    {
      
        
        var todoToUpdate = Todos.FirstOrDefault(s => s.Id == todoId);
        
        if (todoToUpdate != null)
        {
            todoToUpdate.IsDone = "Finished";
            
            
        }
    }

    public static void DeleteTodo(int todoId)
    {
        var todo = Todos.FirstOrDefault(s => s.Id == todoId);
        if (todo != null)
        {
            Todos.Remove(todo);
        }
    }

    public static List<Todo> SearchTodo(string Todofilter)
    {
        return Todos.Where(s => s.Name != null && s.Name.Contains(Todofilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }


}
/*
public static List<Server> GetServersByCity(string cityName)
{
    return servers.Where(s => s.City != null && s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
}
 */
