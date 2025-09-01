using Microsoft.AspNetCore.Mvc;
using RadioStationApi.Entities;
using RadioStationApi.Services;

namespace RadioStationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly SchedulerService _schedulerService;

        public ScheduleController()
        {
            _schedulerService = new SchedulerService();
        }

        [HttpGet("week")]
        public ActionResult<List<DailySchedule>> GetWeek()
        {
            return _schedulerService.GetWeeklySchedule();
        }

        [HttpGet("day/{date}")]
        public ActionResult<DailySchedule> GetDay(string date)
        {
            if (!DateTime.TryParse(date, out var parsedDate))
                return BadRequest("Invalid date format. Use yyyy-MM-dd.");
            return _schedulerService.GetScheduleForDay(parsedDate);
        }
    }
}
