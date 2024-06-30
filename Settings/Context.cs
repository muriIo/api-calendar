using api_calendar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace api_calendar.Settings;

public class Context(IMongoClient mongoClient, IOptions<MongoDBSettings> settings) : DbContext
{
    private readonly IMongoClient _mongoClient = mongoClient;
    private readonly string _databaseName = settings.Value.DatabaseName;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMongoDB(_mongoClient, _databaseName);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    
}
