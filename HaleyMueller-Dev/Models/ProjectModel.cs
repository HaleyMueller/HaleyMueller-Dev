namespace HaleyMueller_Dev.Models
{
    public class ProjectModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ImgUrl { get; set; }
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
