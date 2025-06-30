using CoursePlataform.SharedContext;

namespace CoursePlataform.SubscriptionContext;

public class User : BaseContent
{
    public string Username { get; set; }
    public string Password { get; set; }
}