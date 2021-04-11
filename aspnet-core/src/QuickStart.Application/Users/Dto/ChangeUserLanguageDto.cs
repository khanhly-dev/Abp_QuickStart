using System.ComponentModel.DataAnnotations;

namespace QuickStart.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}