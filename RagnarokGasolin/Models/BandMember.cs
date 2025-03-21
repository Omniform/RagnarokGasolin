namespace RagnarokGasolin.Models
{
    public class BandMember
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImgPath { get; set; }
        public string? Description { get; set; }
        
        public List<TimelineInfo> TimelineInfo { get; set; }


        public BandMember(string name, string imgPath, string description) { 
            Name = name;
            ImgPath = imgPath;
            Description = description;
            TimelineInfo = new List<TimelineInfo>();
            
        }
    }
}
