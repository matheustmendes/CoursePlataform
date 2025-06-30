using CoursePlataform.ContentContext.Enums;

namespace CoursePlataform.ContentContext;

public class Course : Content
{
    
    public ELevel Level { get; set; }
    public IList<Module> Modules { get; set; }
    public Category Category { get; set; }
    public string Title { get; set; }
    
    
     public Course(ELevel level, string title, string url, Category category) : base(title, url)
    {
        Level = level;
        Title = title;
        Category = category;
        Modules = new List<Module>();
    }

    
    
    
}