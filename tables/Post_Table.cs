using System.ComponentModel.DataAnnotations;
namespace eve_api.tables
{
    public class Post_Table
    {
        [Key]

        public int Id_post { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Icon { get; set; }
        [Required]
        public string Image {  get; set; }

        public string? Video { get; set; }
       
        public string? Country { get; set; }
       
        public string? City { get; set; }
        
        public string? Street { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }

        [Required]
        public string Start_Date { get; set; }

        [Required]
        public string End_Date { get; set; }

        [Required]
        public int User_id { get; set; }

        [Required]
        public string Category { get; set; }

    }
}
