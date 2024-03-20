using TicketManagement.Core.Enums;

namespace TicketManagement.Core.Entities;

public class Ticket : BaseEntity<Guid>
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Contact { get; set; }
    public CategoryType Category { get; set; }
    public PriorityType Priority { get; set; }
    public string Subject { get; set; }

    public DateTime? LastResponseTime { get; set; } // Son yanıtın zamanı
    public EscalationLevel EscalationLevel { get; set; } // 0: Agent, 1: AgentAdmin, 2: HOD

    // User ile ilişki Foreign Key
    public Guid UserId { get; set; }
    public virtual User User { get; set; }

    // Navigation properties
    public virtual ICollection<Message>? Messages { get; set; }
    public virtual ICollection<Attachment>? Attachments { get; set; }
    public virtual ICollection<Note>? Notes { get; set; }
}