using System;
using System.Collections.Generic;
using RadioStationApi.Entities;

namespace RadioStationApi.Data
{
    public static class MockScheduleData
    {
        public static List<DailySchedule> GetSampleWeek()
        {
            var week = new List<DailySchedule>();
            var today = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                var date = today.AddDays(i);
                var daily = new DailySchedule { Date = date };
                // Example: Add a live session in Studio 1
                daily.Entries.Add(new ScheduleEntry
                {
                    StartTime = date.AddHours(9),
                    EndTime = date.AddHours(11),
                    Type = ContentType.LiveSession,
                    Title = $"Morning Show {i + 1}",
                    Host = "DJ Anton",
                    StudioNumber = 1
                });
                // Example: Add a pre-recorded reportage
                daily.Entries.Add(new ScheduleEntry
                {
                    StartTime = date.AddHours(12),
                    EndTime = date.AddHours(13),
                    Type = ContentType.PreRecordedReportage,
                    Title = $"Reportage {i + 1}",
                    Host = "Reporter",
                    StudioNumber = 2
                });
                // Example: Fallback music for the rest of the day
                daily.Entries.Add(new ScheduleEntry
                {
                    StartTime = date.AddHours(0),
                    EndTime = date.AddHours(9),
                    Type = ContentType.Music,
                    Title = "Night Music",
                    StudioNumber = 1
                });
                daily.Entries.Add(new ScheduleEntry
                {
                    StartTime = date.AddHours(11),
                    EndTime = date.AddHours(12),
                    Type = ContentType.Music,
                    Title = "Midday Music",
                    StudioNumber = 1
                });
                daily.Entries.Add(new ScheduleEntry
                {
                    StartTime = date.AddHours(13),
                    EndTime = date.AddHours(24),
                    Type = ContentType.Music,
                    Title = "Evening Music",
                    StudioNumber = 2
                });
                week.Add(daily);
            }
            return week;
        }
    }
}
