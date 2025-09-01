using RadioStationApi.Entities;
using RadioStationApi.Interfaces;

namespace RadioStationApi.Services
{
    public class SchedulerService : IScheduler
    {
        private readonly List<DailySchedule> _weeklySchedule;

        public SchedulerService()
        {
            // Load mock data for demonstration/testing
            // In feature load from DB
            _weeklySchedule = Data.MockScheduleData.GetSampleWeek();
        }

        public void AddEntry(DailySchedule schedule, ScheduleEntry entry)
        {
            // Fallback to music if no entry
            if (entry == null)
            {
                entry = new ScheduleEntry
                {
                    Type = ContentType.Music,
                    Title = "Music Fallback",
                    StartTime = schedule.Date,
                    EndTime = schedule.Date.AddDays(1)
                };
            }
            schedule.Entries.Add(entry);
        }

        public List<DailySchedule> GetWeeklySchedule()
        {
            return _weeklySchedule;
        }

        public DailySchedule GetScheduleForDay(DateTime date)
        {
            return _weeklySchedule.FirstOrDefault(s => s.Date.Date == date.Date) ?? new DailySchedule { Date = date };
        }
    }
}
