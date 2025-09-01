namespace RadioStationApi.Entities
{
    public enum ContentType
    {
        Music,
        PreRecordedReportage,
        LiveSession
    }

    public class ScheduleEntry
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ContentType Type { get; set; }
        public string? Title { get; set; }
        public string? Host { get; set; }
        public string? Guest { get; set; }
        public int StudioNumber { get; set; }
    }
}
