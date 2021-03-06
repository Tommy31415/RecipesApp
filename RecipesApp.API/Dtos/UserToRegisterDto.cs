using System.ComponentModel.DataAnnotations;

namespace RecipesApp.API.Dtos
{
    public class UserToRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Password length should be between 4 and 8 characters")]
        public string Password { get; set; }
    }
}