namespace TicketManagement.Core.Entities;

public class Notification : BaseEntity<Guid>
{
    public Guid UserId { get; set; } // Bildirimin gönderildiği kullanıcı
    public virtual User User { get; set; } // Navigation property

    public Guid TicketId { get; set; } // İlişkili bilet, bildirim bir biletle ilişkili olmayabilir
    public virtual Ticket? Ticket { get; set; } // Navigation property

    public string Message { get; set; } // Bildirim mesajı
    public bool IsRead { get; set; } // Okunma durumu
    public DateTime NotificationDate { get; set; } // Bildirim tarihi
}