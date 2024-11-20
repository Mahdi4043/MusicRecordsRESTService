namespace MusicRecordsRESTService.Models
{
    public class MusicRecord
    {
        public int Id;
        public string? Artist;
        public int PublicationYear;
        public string? Title;
        public int Duration;

        public override string ToString()
        {
            return $"id:{Id}, artist:{Artist}, publication year:{PublicationYear}, title: {Title}, duration: {Duration}";
        }
        public void ValidateTitle()
        {

            if (Title == null)
            {
                throw new ArgumentNullException(nameof(Title), "Title cannot be null");
            }
            if (Title.Length < 1)
            {
                throw new ArgumentException("Title must be at least 1 character", nameof(Title));
            }

        }
        public void ValidateArtist()
        {

            if (Artist == null)
            {
                throw new ArgumentNullException(nameof(Artist), "Title cannot be null");
            }
            if (Artist.Length < 1)
            {
                throw new ArgumentException("Title must be at least 1 character", nameof(Artist));
            }

        }

    }
}
