using AWS.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace AWS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IBucketManager _bucketManager;
        
        public FileController(IBucketManager bucketManager) 
        { 
            _bucketManager = bucketManager;
        }

        [HttpGet]
        public ActionResult<string> GetFiles() 
        {
            try
            {
                return Ok(_bucketManager.GetFiles());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
