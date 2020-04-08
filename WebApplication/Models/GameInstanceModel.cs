using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class GameInstanceModel
    {
        [Display(Name = "Game")]
        [Required(ErrorMessage = "Required field")]
        public string Game { get; set; }

        [Display(Name = "Arguments")]
        [Required(ErrorMessage = "Required field")]
        public string Args { get; set; }

        [Display(Name = "Server to Launch On")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(39, MinimumLength = 11, ErrorMessage = "Characters must be in the range 11-39")]
        public string ServerToLaunchOn { get; set; }
    }
}
