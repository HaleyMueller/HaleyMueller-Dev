namespace HaleyMueller_Dev.Models
{
    public class ProjectModel
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<string> ImgUrls { get; set; } = new List<string>();
        public string Warning { get; set; }
        public int Significance { get; set; }
        public List<Link> Links { get; set; } = new List<Link>();
        public class Link
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }
    }
}
