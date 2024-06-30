using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_calendar.Models;

public class Attachment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Attachment_id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    [ForeignKey("Event"), DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Event_id { get; set; }

    public Event? Event { get; set; }

}
