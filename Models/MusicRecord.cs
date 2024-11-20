namespace MusicRecordsRESTService.Models
{
    public class MusicRecord
    {
        public int Id;
        public string Artist;
        public int PublicationYear;
        public string Title;
        public int Duration;

        public override string ToString()
        {
            return $"id:{Id}, artist:{Artist}, publication year:{PublicationYear}, title: {Title}, duration: {Duration}";
        }
    }
}
