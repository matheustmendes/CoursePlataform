using CoursePlataform.NotificationContext;

namespace CoursePlataform.ContentContext;

public abstract class BaseContent : Notifiable
{
    public Guid Id { get; set; }

    public BaseContent()
    {
        Id = Guid.NewGuid();
    }
}