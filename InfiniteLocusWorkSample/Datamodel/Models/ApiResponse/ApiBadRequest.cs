using System.Net;

namespace InfiniteLocusWorkSample.Model.ApiResponse
{
    public class ApiBadRequest:ApiResponse
    {
        public Dictionary<int, string> Errors { get; set; }
        public ApiBadRequest(Dictionary<int, string> Err):base((int)HttpStatusCode.BadRequest){
            Errors = Err;
        }
    }
}
