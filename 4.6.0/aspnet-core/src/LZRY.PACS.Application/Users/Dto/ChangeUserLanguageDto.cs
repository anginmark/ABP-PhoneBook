using System.ComponentModel.DataAnnotations;

namespace LZRY.PACS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}