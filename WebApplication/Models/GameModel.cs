using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class GameModel
    {
        [Display(Name = "Name (just to make it easier to identify)")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Characters must be in the range 11-39")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Amount of characters must be in the range 11-39")]
        public string Game { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Amount of characters must be in the range 1-5")]
        public string Map { get; set; }

 

        [Required(ErrorMessage = "Required field")]
        public int MaxPlayers { get; set; }
    }
}
