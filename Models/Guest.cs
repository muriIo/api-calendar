using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using api_calendar.Enums;

namespace api_calendar.Models;

public class Guest
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Guest_id { get; set; } = string.Empty;

    [BsonElement("Name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("Email")]
    public string Email { get; set; } = string.Empty;

    [BsonElement("Image_url")]
    public string Image_url { get; set; } = string.Empty;

    [BsonElement("Status")]
    public StatusEnum Status { get; set; }

    [BsonElement("Event_id")]
    public string Event_id { get; set; } = string.Empty;

}
