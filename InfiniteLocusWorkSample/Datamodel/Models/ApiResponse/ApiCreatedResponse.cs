using System.Net;

namespace InfiniteLocusWorkSample.Model.ApiResponse
{
    public class ApiCreatedResponse : ApiResponse
    {
        public String Message { get; set; }
        public ApiCreatedResponse(string msg = "Records Created Successfully") : base((int)HttpStatusCode.Created)
        {
            Message = msg;
        }
    }
}
