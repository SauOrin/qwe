using System.ComponentModel.DataAnnotations;

namespace eve_api.tables
{
    public class News_Table
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string News_name { get; set; }

        [Required]
        public string News_icon { get; set; }

        [Required]
        public string News_image { get; set; }

        [Required]
        public string News_color { get; set; }

        [Required]
        public string News_date { get; set; }

        [Required]
        public string News_body { get; set; }

    }
}
