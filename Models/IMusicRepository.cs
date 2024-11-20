namespace MusicRecordsRESTService.Models
{
    public interface IMusicRepository
    {
        MusicRecord Add(MusicRecord music);
        IEnumerable<MusicRecord> Get(int? yearAfter = null, string? titleIncludes = null, string? orderBy = null);
        Movie? GetById(int id);
        Movie? Remove(int id);
        Movie? Update(int id, Movie movie);
    }
}
