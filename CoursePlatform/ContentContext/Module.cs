namespace CoursePlataform.ContentContext;

public class Module : BaseContent
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int OrderInCourse { get; set; }
    public List<Lecture> Lectures { get; set; } = new List<Lecture>();
}