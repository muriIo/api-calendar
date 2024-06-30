using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_calendar.Enums;

namespace api_calendar.Models;

public class Event
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Event_id { get; set; }

    public string Title { get; set; } = string.Empty;

    public bool All_day { get; set; }

    public TypeEnum Type { get; set; }

    public string Url_video_conference { get; set; } = string.Empty;
    
    public string Location { get; set; } = string.Empty;

    public string Color { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool Is_public { get; set; }

    public DateTime Start_time { get; set; }

    public DateTime End_time { get; set; }

    [ForeignKey("User"), DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Creator_id { get; set; }

    public User? Creator { get; set; }

    public List<Guest> Guests { get; set; } = new List<Guest>();

    public List<Attachment> Attachments { get; set; } = new List<Attachment>();

}
