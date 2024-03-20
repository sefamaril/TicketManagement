using Microsoft.EntityFrameworkCore;
using TicketManagement.Core.Entities;
using Microsoft.Extensions.Configuration;

namespace TicketManagement.Core.Concrete.EntityFramework.Context;

public class TicketContext : DbContext
{
    //Constructor calling the Base DbContext Class Constructor
    public TicketContext(DbContextOptions<TicketContext> options): base(options)
    {
    }
    //OnConfiguring() method is used to select and configure the data source
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Eðer optionsBuilder henüz bir veritabaný saðlayýcýsýyla yapýlandýrýlmamýþsa
        if (!optionsBuilder.IsConfigured)
        {
            throw new InvalidOperationException("DbContext yapýlandýrýlmamýþ. Lütfen uygulamanýn baðlantý dizesi saðladýðýndan emin olun.");
            //var defaultConnectionString = "Server=(localdb)\\mssqllocaldb;Database=MyDefaultDatabase;Trusted_Connection=True;";
            //optionsBuilder.UseSqlServer(defaultConnectionString);
        }
    }

    //OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //use this to configure the model
    }
    
    public DbSet<Article> Articles { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<CheckIn> CheckIns { get; set; }
    public DbSet<Escalation> Escalations { get; set; }   
    public DbSet<Message> Messages { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketHistory> TicketHistories { get; set; }
    public DbSet<User> Users { get; set; }
}