using InfiniteLocusWorkSample.Helper.Interface;

namespace InfiniteLocusWorkSample.Helper
{
    public class CustomValidator: ICustomValidator
    {
        Dictionary<int,string> dic= new Dictionary<int,string>();

        public async Task<Dictionary<int, string>> validateSingle(int input) 
        {
            dic.Clear();
            if (input == 0)
            {
                dic.Add(1, "Id cannot be null");
               return dic;
            
            }
            return dic;
        }
    }
}
