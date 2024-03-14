namespace Mission10_API.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<CombinedData> GetAllBowlingInfo();
    }

}