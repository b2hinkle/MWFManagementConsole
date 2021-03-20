using System.ComponentModel.DataAnnotations;

namespace MWFManagementConsoleWebApp.Models
{
    // Front end model for user forum data
    public class FEHostModel
    {
        [Display(Name = "Host Ip (This is given to UE4 Clients. Port number is supposed to be specified in the GameInstance table)")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(39, MinimumLength = 11, ErrorMessage = "Characters must be in the range 11-39")]
        public string HostIp { get; set; }

        [Display(Name = "Associated Host Services Api Ip (If duel NIC card setup this will be different than \"HostIp\")")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(39, MinimumLength = 11, ErrorMessage = "Amount of characters must be in the range 11-39")]
        public string AssociatedHostServicesApiIp { get; set; }

        [Display(Name = "Associated Host Services Api Port")]
        [Required(ErrorMessage = "Required field")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Amount of characters must be in the range 1-5")]
        public string AssociatedHostServicesApiPort { get; set; }
    }
}
