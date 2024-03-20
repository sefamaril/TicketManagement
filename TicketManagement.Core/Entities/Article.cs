using TicketManagement.Core.Enums;

namespace TicketManagement.Core.Entities;

public class Article : BaseEntity<Guid>
{
    public CategoryType Category { get; set; } // Makalenin kategorisi
    public string? Type { get; set; } // Makalenin türü
    public string Subject { get; set; } // Makalenin konusu
    public string Contents { get; set; } // Makalenin içeriği (500 karaktere kadar)
    public string? Keywords { get; set; } // Anahtar kelimeler, virgülle ayrılabilir

    // Navigation properties
    public virtual ICollection<Attachment>? Attachments { get; set; } // Makaleye eklenen dosyalar

    // Makaleyi oluşturan veya son düzenlemeyi yapan kullanıcının ID'si
    public Guid AuthorUserId { get; set; }
    public virtual User AuthorUser { get; set; } // Makaleyi oluşturan kullanıcı
}