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
        //Get the Connection String from appsettings.json file

        //Step2: Load the Configuration File.
        var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        // Step3: Get the Section to Read from the Configuration File
        var configSection = configBuilder.GetSection("ConnectionStrings");

        // Step4: Get the Configuration Values based on the Config key.
        var connectionString = configSection["SQLServerConnection"] ?? null;

        //Configuring the Connection String
        optionsBuilder.UseSqlServer(connectionString);
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