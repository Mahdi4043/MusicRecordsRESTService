namespace MusicRecordsRESTService.Models
{
    public class MusicRepo
    {
        private readonly List<MusicRecord> _musicRecord = new();
        public List<MusicRecord> GetAll()
        {
            return new List<MusicRecord>(_musicRecord);
        }

    }
}
