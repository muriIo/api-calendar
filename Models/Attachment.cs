using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api_calendar.Models;

public class Attachment
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Attachment_id { get; set; } = string.Empty;

    [BsonElement("Name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("Url")]
    public string Url { get; set; } = string.Empty;

    [BsonElement("Event_id")]
    public string Event_id { get; set; } = string.Empty;

}
