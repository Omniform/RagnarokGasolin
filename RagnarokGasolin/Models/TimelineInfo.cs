namespace RagnarokGasolin.Models
{
    public class TimelineInfo
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRight { get; set; }

        public TimelineInfo(bool isRight, string date, string title, string description) { 
            IsRight = isRight;
            Date = date;
            Title = title;
            Description = description;
        }
    }
}
