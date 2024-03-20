namespace TicketManagement.Core.Entities;

public class User : BaseEntity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool Gender { get; set; }
    public string? MobileNo { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string? ProfilePicture { get; set; }
    public bool EmailVerification { get; set; }

    // Navigation properties
    public virtual ICollection<Ticket>? Tickets { get; set; }
}