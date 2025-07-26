using System.ComponentModel.DataAnnotations;

namespace Final8Net.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string ImageUrl { get; set; }
        [Required]
        public required string Url { get; set; }
    }
}
