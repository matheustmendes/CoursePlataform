using System.Runtime.InteropServices.JavaScript;

namespace CoursePlataform.ContentContext;

public abstract class Content
{

    public Content()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
}