using System.ComponentModel.DataAnnotations;

namespace ToDo.Components.Models;

public class Todo
{
    [Required]
    public string? Name { get; set; }
    
    
    public int Id { get; set; }
    
    [Required]
    public string? IsDone { get; set; }
}