using TicketManagement.Core.Enums;

namespace TicketManagement.Core.Entities;

public class TicketHistory : BaseEntity<Guid>
{
    public Guid TicketId { get; set; }
    public virtual Ticket Ticket { get; set; }

    public Guid ChangedByUserId { get; set; }
    public virtual User ChangedByUser { get; set; }

    public OperationType OperationType { get; set; }
    public string OperationOldValue { get; set; }
    public string OperationNewValue { get; set; }
    public string Description { get; set; }
    public DateTime ChangeDate { get; set; }
}