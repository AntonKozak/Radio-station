using System.Collections.Generic;

namespace RadioStationApi.Entities
{
    public class DailySchedule
    {
        public DateTime Date { get; set; }
        public List<ScheduleEntry> Entries { get; set; } = new();
    }
}
