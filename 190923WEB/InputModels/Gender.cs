using System.ComponentModel.DataAnnotations;

namespace _190923WEB.InputModels
{
    public enum Gender
    {
        [Display(Name = "Muž")]
        Man = 0,
        [Display(Name = "Žena")]
        Woman = 1,
        [Display(Name = "Cosi")]
        Other = 2
    }
}
