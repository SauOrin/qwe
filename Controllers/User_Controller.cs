
using eve_api.tables;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eve_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_Controller : ControllerBase
    {

       
        private readonly appContext _context;
        public User_Controller(appContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<List<User_Table>>> GerUser(int id)
        {

            var dbusers = from user in _context.user_Tables
                          where user.User_id == id
                          select new
                          {
                              user_User_name = user.User_name,                          
                              user_Avatar_image = user.Avatar_image,
                              user_Date_registration = user.Date_registration
                          };
            if (dbusers == null)
                return BadRequest("Пользователь не найден");



            return Ok(await dbusers.ToListAsync());

        }



    }
}
