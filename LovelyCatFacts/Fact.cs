namespace LovelyCatFacts
{
    public class Fact
    {
        public string Id { get; set; }
        public int VersionNumber { get; set; }
        public string? User { get; set; }
        public string Text { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public DateTime? SendDate { get; set; }
        public bool IsDeleted { get; set; }
        public string? Source { get; set; }

        public string? Type { get; set; }
        public int SentCount { get; set; }




    }
}
