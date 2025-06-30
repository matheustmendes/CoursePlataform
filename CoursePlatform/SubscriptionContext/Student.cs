using CoursePlataform.SharedContext;

namespace CoursePlataform.SubscriptionContext;

/// <summary>
///  The user is not always a student, but the student is always a user.
/// </summary>
public class Student : BaseContent
{
    public User User { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public IList<Subscription> Subscriptions { get; set; }
    
}