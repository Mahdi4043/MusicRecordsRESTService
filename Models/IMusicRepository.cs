namespace MusicRecordsRESTService.Models
{
    public interface IMusicRepository
    {
        MusicRecord Add(MusicRecord music);
        IEnumerable<MusicRecord> Get(int? publicationYear = null, string? titleIncludes = null, string? orderBy = null);
        MusicRecord? GetById(int id);
        MusicRecord? Remove(int id);
        MusicRecord? Update(int id, MusicRecord movie);
    }
}

