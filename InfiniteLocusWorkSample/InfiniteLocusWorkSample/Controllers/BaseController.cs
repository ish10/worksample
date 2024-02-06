using InfiniteLocusWorkSample.Model.ApiResponse;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InfiniteLocusWorkSample.Controllers
{
  
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    
    public class BaseController : ControllerBase
    {
        protected internal IActionResult GetResult(ApiResponse apiResponse)
        {

            if (apiResponse.Statuscode == StatusCodes.Status400BadRequest)
                return BadRequest(apiResponse);
            else if (apiResponse.Statuscode == StatusCodes.Status201Created)
                return StatusCode(201, apiResponse);
            else if (apiResponse.Statuscode == StatusCodes.Status404NotFound)
                return NotFound(apiResponse);
            else return Ok(apiResponse);
        }
    }
}
