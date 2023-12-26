using eve_api;
using eve_api.tables;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Partners_Controller : ControllerBase
    {
        private readonly appContext _context;
        public Partners_Controller(appContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<Partners_Table>>> GerPartners()
        {

            return Ok(await _context.partners_Tables.ToListAsync());

        }
    }
}
