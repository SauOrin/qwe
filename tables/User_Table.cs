using System.ComponentModel.DataAnnotations;

namespace eve_api.tables
{
    public class User_Table
    {
        [Key]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string User_name {  get; set; }

        [Required]
        public string User_nick { get; set; }

        [Required]
        public string Avatar_image { get; set;}
        
        [Required]
        public string Date_registration { get; set;}

        [Required]
        public int User_id { get; set; }


        

    }
}
