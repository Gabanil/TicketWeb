using System.ComponentModel.DataAnnotations;

namespace Web_App.Models
{
    public class Producer
    {
        [Key]
        public int? Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must between 2 and 50 chars")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string? Bio { get; set; }


        //relationships
        public List<Movie>? Movies { get; set; }
    }
}
