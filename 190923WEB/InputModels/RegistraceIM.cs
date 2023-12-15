using System.ComponentModel.DataAnnotations;

namespace _190923WEB.InputModels
{
    public class RegistraceIM
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Min Length Is One Character")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Shoe Size")]
        [Range(14, 50)]
        public int ShoeSize { get; set; }
        [EmailAddress]
        [Display(Name = "Email Adress")]
        public string Email { get; set; }
        public bool IsAdult { get; set; }
        [Display(Name = "Pohlaví")]
        public Gender Gender { get; set; }
    }
}
