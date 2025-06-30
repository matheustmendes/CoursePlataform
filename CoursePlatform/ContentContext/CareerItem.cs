namespace CoursePlataform.ContentContext;

    public class CareerItem : BaseContent
    {
        
        public CareerItem(int order, string title, string description, Course course)
        {
            if(course == null)
                throw new ArgumentNullException(nameof(course), "Course cannot be null");
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
