using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneSignal.Models
{


    public class CreateAppViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "App Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "App Name")]
        public string Id { get; set; }
    }


    public class AppsIndexViewModel
    {
        public Backend.EF.App[] apps;
    }

}