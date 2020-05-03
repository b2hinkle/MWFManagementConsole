using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DeveloperConsoleDataLibrary.Models
{
    class ServerModel
    {
        [Display(Name = "Server IP (This is given to UE4 Clients. Port number is supposed to be specified in the GameInstance table)")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(39, MinimumLength = 11, ErrorMessage = "Characters must be in the range 11-39")]
        public string ServerIP { get; set; }

        [Display(Name = "GamesInstances Management API IP (If duel NIC card setup this will be different than the last IP)")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(39, MinimumLength = 11, ErrorMessage = "Amount of characters must be in the range 11-39")]
        public string GameInstancesManagementApiIp { get; set; }

        [Display(Name = "GameInstances Management API Port")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Amount of characters must be in the range 1-5")]
        public string GameInstancesManagementApiPort { get; set; }
    }
}
