using System.Runtime.InteropServices.JavaScript;
using CoursePlataform.NotificationContext;
using CoursePlataform.SharedContext;

namespace CoursePlataform.ContentContext;

public abstract class Content : BaseContent
{

    public Content(string title, string url)
    {
        Title = title;
        Url = url;
        
    }
   
    public string Title { get; set; }
    public string Url { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
}