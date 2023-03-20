namespace RESTS_opg.Models
{
    public class MusicRecords
    {
        public string? Title { get; set; }

        public string? Artist { get; set; }
        public int publicationYear { get; set; }
        public int duration { get; set; }

        public int Id { get; set; }
    }
}