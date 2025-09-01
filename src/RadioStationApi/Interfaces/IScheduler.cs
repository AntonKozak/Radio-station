using RadioStationApi.Entities;

namespace RadioStationApi.Interfaces
{
    public interface IScheduler
    {
        void AddEntry(DailySchedule schedule, ScheduleEntry entry);
        List<DailySchedule> GetWeeklySchedule();
        DailySchedule GetScheduleForDay(DateTime date);
    }
}
