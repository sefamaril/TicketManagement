namespace TicketManagement.Core.Entities;

public class CheckIn : BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
    public DateTime CheckInTime { get; set; }
    public DateTime? CheckOutTime { get; set; }
}