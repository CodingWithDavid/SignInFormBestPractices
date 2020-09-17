
using System.ComponentModel.DataAnnotations;

namespace SigninBestPratices.Data
{
    public class SignInModel
    {
        [Required]
        [MaxLength(125)]
        public string Email { get; set; }

        [Required]
        [MaxLength(32)]
        [MinLength(6)]
        public string Password { get; set; }

        public bool LoggedIn { get; set; }
    }
}
