namespace TicketManagement.Core.Entities;

public class Attachment : BaseEntity<Guid>
{
    public required string FilePath { get; set; }
    public Guid TicketId { get; set; }
    public virtual Ticket? Ticket { get; set; }
    public Guid UserId { get; set; }
    public virtual User? User { get; set; }
}