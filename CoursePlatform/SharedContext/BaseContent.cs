using CoursePlataform.NotificationContext;

namespace CoursePlataform.SharedContext;

public abstract class BaseContent : Notifiable
{
    public Guid Id { get; set; }

    public BaseContent()
    {
        Id = Guid.NewGuid();
    }
}