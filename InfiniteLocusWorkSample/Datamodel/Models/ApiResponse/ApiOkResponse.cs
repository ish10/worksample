using System.Net;

namespace InfiniteLocusWorkSample.Model.ApiResponse
{
    public class ApiOkResponse:ApiResponse
    {
        public Object Result { get; set; }
        public ApiOkResponse(object result):base((int)HttpStatusCode.OK)
        {
            Result = result;
        }
    }
}
