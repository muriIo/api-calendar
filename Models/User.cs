using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_calendar.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int User_id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Image_url { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public List<Event> Created_events { get; set; } = new List<Event>();

}
