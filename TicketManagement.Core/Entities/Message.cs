namespace TicketManagement.Core.Entities;

public class Message : BaseEntity<Guid>
{
    public string? Content { get; set; }
    public Guid TicketId { get; set; }
    public virtual Ticket? Ticket { get; set; }
    public Guid UserId { get; set; }
    public virtual User? User { get; set; }
}