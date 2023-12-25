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
    public class News_Controller : ControllerBase
    {


        private readonly appContext _context;
        public News_Controller(appContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<News_Table>>> GerNews()
        {

            return Ok(await _context.news_Tables.ToListAsync());

        }
    }
}
