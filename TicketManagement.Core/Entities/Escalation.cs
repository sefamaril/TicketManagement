using TicketManagement.Core.Enums;

namespace TicketManagement.Core.Entities;

public class Escalation : BaseEntity<Guid>
{
    public Guid TicketId { get; set; }
    public virtual Ticket Ticket { get; set; } // İlişkili bilet

    public EscalationLevel CurrentLevel { get; set; } // Mevcut escalation seviyesi: Agent, AgentAdmin, HOD

    public DateTime EscalationDate { get; set; } // Escalation'ın gerçekleştiği tarih

    // Escalation'ı tetikleyen kullanıcı (örneğin, ilk atanan agent)
    public Guid TriggeredByUserId { get; set; }
    public virtual User TriggeredByUser { get; set; }

    // Escalation'a yanıt vermesi gereken sonraki seviyedeki kullanıcı (AgentAdmin veya HOD)
    public Guid? RespondedByUserId { get; set; }
    public virtual User? RespondedByUser { get; set; }

    public bool IsResolved { get; set; } // Escalation'ın çözülüp çözülmediği
}