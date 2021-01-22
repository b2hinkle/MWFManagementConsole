using System.ComponentModel.DataAnnotations;

namespace MWFManagementConsoleWebApp.Models
{
    // Front end model for user forum data

    // Users shouldn't be able to gie the GameInstanceModel values. They should only be able to create GameInstanceModels from an existing GameModel. 
    // Might however give the option to override the values if they want slightly different values. But that is for a later time.
    public class GameInstanceModel
    {
        //  This should be enum instead with dropdown for choosing
        [Display(Name = "Game")]
        [Required(ErrorMessage = "Required field")]
        public string Game { get; set; }
/*
        [Display(Name = "Arguments")]
        [Required(ErrorMessage = "Required field")]
        public string Args { get; set; }
*/
        //  This should be enum instead with dropdown for choosing
        [Display(Name = "Host to Launch On")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(39, MinimumLength = 11, ErrorMessage = "Characters must be in the range 11-39")]
        public string AssociatedHost { get; set; }
    }
}
