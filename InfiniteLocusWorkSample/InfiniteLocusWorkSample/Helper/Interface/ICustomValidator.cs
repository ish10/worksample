namespace InfiniteLocusWorkSample.Helper.Interface
{
    public interface ICustomValidator
    {
        Task<Dictionary<int, string>> validateSingle(int input);
    }
}
