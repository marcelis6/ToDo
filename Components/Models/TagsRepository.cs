namespace ToDo.Components.Models;

public class TagsRepository
{
    private static List<string> Tags =
    [
        "Unfinished",
        "Finished",
        
    ];
    //metoda ktora dostarcza nam liste stringow do innych komponentow
    public static List<string> GetTags() => Tags;

}
