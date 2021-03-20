using System.ComponentModel.DataAnnotations;

namespace MWFManagementConsoleWebApp.Models
{
    // Front end model for user forum data
    public class FEGameModel
    {
        [Display(Name = "Name (just to make it easier to identify)")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Characters must be in the range 11-39")]
        public string Name { get; set; }

        //  This should be enum instead with dropdown for choosing
        [Required(ErrorMessage = "Required field")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Amount of characters must be in the range 11-39")]
        public string Game { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Amount of characters must be in the range 1-5")]
        public string Map { get; set; }

        public string Args { get; set; }
    }
}
