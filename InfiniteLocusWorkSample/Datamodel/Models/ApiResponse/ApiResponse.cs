namespace InfiniteLocusWorkSample.Model.ApiResponse
{
    public class ApiResponse
    {
        public int Statuscode { get; set; }

        public ApiResponse(int statuscode)
        {
            Statuscode = statuscode;
        }
    }
}
