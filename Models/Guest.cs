using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_calendar.Enums;

namespace api_calendar.Models;

public class Guest
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Guest_id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Image_url { get; set; } = string.Empty;

    public StatusEnum Status { get; set; }

    [ForeignKey("Event"), DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Event_id { get; set; }

    public Event? Event { get; set; }

}
