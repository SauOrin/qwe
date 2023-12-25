using System.ComponentModel.DataAnnotations;

namespace eve_api.tables
{
    public class Partners_Table
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Partners_name { get; set; }

        [Required]
        public string Partners_logo { get; set; }

        [Required]
        public string Partners_link { get; set; }


    }
}
