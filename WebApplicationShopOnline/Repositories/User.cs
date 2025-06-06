using System.ComponentModel.DataAnnotations;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Login is required")]
        [StringLength(50)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Phone]
        [Required(ErrorMessage = "Telephone is required")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}