using api_calendar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace api_calendar.Settings;

public class Context : DbContext
{
    private readonly IMongoClient _mongoClient;
    private readonly string _databaseName;
    private readonly IMongoDatabase _database;

    public Context(IMongoClient mongoClient, IOptions<MongoDBSettings> settings)
    {
        _mongoClient = mongoClient;
        _databaseName = settings.Value.DatabaseName;
        _database = _mongoClient.GetDatabase(_databaseName);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMongoDB(_mongoClient, _databaseName);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToCollection("users");
        modelBuilder.Entity<Guest>().ToCollection("guests");
        modelBuilder.Entity<Event>().ToCollection("events");
        modelBuilder.Entity<Attachment>().ToCollection("attachments");

        base.OnModelCreating(modelBuilder);
    }

    public IMongoCollection<User> Users => _database.GetCollection<User>("users");
    public IMongoCollection<Guest> Guests => _database.GetCollection<Guest>("guests");
    public IMongoCollection<Event> Events => _database.GetCollection<Event>("events");
    public IMongoCollection<Attachment> Attachments => _database.GetCollection<Attachment>("attachments");

}
