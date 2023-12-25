
using eve_api.tables;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace eve_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Post_Controller : ControllerBase
    {

        private readonly appContext _context;

        public Post_Controller(appContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]

        public async Task<ActionResult<List<Post_Table>>> Get_Post()
        {

            var result = from post in _context.post_Tables
                         join user in _context.user_Tables on post.User_id equals user.User_id
                         orderby post.Id_post
                         select new
                         {
                             id_post = post.Id_post,
                             title = post.Title,
                             text = post.Text,
                             icon = post.Icon,
                             image = post.Image,
                             video = post.Video,
                             country = post.Country,
                             city = post.City,
                             street = post.Street,
                             latitude = post.Latitude,
                             longitude = post.Longitude,
                             start_date = post.Start_Date,
                             end_date = post.End_Date,
                             category = post.Category,

                             user_id = user.User_id,
                             user_nick = user.User_nick,
                             user_avatar = user.Avatar_image
                         };


            return Ok(await result.ToListAsync());

        }

        //public async Task<ActionResult<List<Post_Table>>> Get_Post()
        //{

        //    string vievs = "0";
        //    if (Request.Cookies.ContainsKey("vievs"))
        //    {
        //        vievs = Request.Cookies["vievs"];

        //        Response.Cookies.Delete("vievs");

        //        Response.Cookies.Append("vievs", (Convert.ToUInt32(vievs) + 2).ToString());
        //    }

        //    else
        //    {
        //        Response.Cookies.Append("vievs", "2");
        //    }


        //    var result = from post in _context.post_Tables.Skip(Convert.ToInt32(vievs)).Take(2)
        //                 join user in _context.user_Tables on post.User_id equals user.User_id
        //                 orderby post.Id_post
        //                 select new
        //                 {
        //                     id_post = post.Id_post,
        //                     title = post.Title,
        //                     text = post.Text,
        //                     icon = post.Icon,
        //                     image = post.Image,
        //                     video = post.Video,
        //                     country = post.Country,
        //                     city = post.City,
        //                     street = post.Street,
        //                     latitude = post.Latitude,
        //                     longitude = post.Longitude,
        //                     start_date = post.Start_Date,
        //                     end_date = post.End_Date,
        //                     category = post.Category,

        //                     user_id = user.User_id,
        //                     user_nick = user.User_nick,
        //                     user_avatar = user.Avatar_image
        //                 };


        //    return Ok(await result.ToListAsync());

        //}


    }
}
