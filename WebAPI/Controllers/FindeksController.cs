using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindeksController : ControllerBase
    {
        IFindeksService _findeksService;
        public FindeksController(IFindeksService findeksService)
        {
            _findeksService = findeksService;
        }
        [HttpGet("getfindeks")]
        public IActionResult GetFindeksByCustomerId(int customerId)
        {
            var result = _findeksService.GetByCustomerId(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
