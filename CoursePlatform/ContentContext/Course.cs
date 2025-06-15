using CoursePlataform.ContentContext.Enums;

namespace CoursePlataform.ContentContext;

public class Course : Content
{
    
    public ELevel Level { get; set; }
    public IList<Module> Modules { get; set; } = new List<Module>();
    public Category Category { get; set; }
    
    /* Vou comentar o construtor por enquanto 
     public Course(ELevel level, string title, string slug, Category category)
    {
        Level = level;
        Title = title;
        Category = category;
    }
    */
    
    
    
}