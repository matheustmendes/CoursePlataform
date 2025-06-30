using CoursePlataform.ContentContext.Enums;

namespace CoursePlataform.ContentContext;

public class Career : Content
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ELevel Level { get; set; }
    public IList<CareerItem> Items { get; set; }

    public int TotalCourses => Items.Count;
    
    

    public Career(string title, string url) : base(title, url)
    {

        Items = new List<CareerItem>();
    }
    
}

