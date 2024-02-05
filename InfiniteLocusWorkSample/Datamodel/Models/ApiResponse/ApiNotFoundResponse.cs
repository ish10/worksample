using System.Net;

namespace InfiniteLocusWorkSample.Model.ApiResponse
{
    public class ApiNotFoundResponse:ApiResponse
    {
        public string Message { get; set; }
        public ApiNotFoundResponse(string message = "Data not Found") : base((int)HttpStatusCode.NotFound)
        {

            Message = message;
        }
        
    }
}
