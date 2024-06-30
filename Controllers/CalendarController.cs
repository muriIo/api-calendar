using api_calendar.Settings;
using Microsoft.AspNetCore.Mvc;

namespace api_calendar;

[Route("api/[controller]")]
[ApiController]
public class CalendarController(Context context) : ControllerBase
{
    private readonly Context _context = context;
}
