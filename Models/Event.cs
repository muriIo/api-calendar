using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using api_calendar.Enums;

namespace api_calendar.Models;

public class Event
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Event_id { get; set; } = string.Empty;

    [BsonElement("Title")]
    public string Title { get; set; } = string.Empty;

    [BsonElement("All_day")]
    public bool All_day { get; set; }

    [BsonElement("Type")]
    public TypeEnum Type { get; set; }

    [BsonElement("Url_video_conference")]
    public string Url_video_conference { get; set; } = string.Empty;

    [BsonElement("Location")]
    public string Location { get; set; } = string.Empty;

    [BsonElement("Color")]
    public string Color { get; set; } = string.Empty;

    [BsonElement("Description")]
    public string Description { get; set; } = string.Empty;

    [BsonElement("Is_public")]
    public bool Is_public { get; set; }

    [BsonElement("Start_time")]
    public DateTime Start_time { get; set; }

    [BsonElement("End_time")]
    public DateTime End_time { get; set; }

    [BsonElement("Creator_id")]
    public string Creator_id { get; set; } = string.Empty;

}
