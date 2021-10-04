using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.School
{
    public class SchoolVM
    {
        [Display(Name = "Registration №")]
        public string Id { get; set; }
        [Display(Name = "School Name")]
        public string Name { get; set; }
        [Display(Name = "Type")]
        public string BuildingType { get; set; }
        [Display(Name = "Status")]
        public string BuildingStatus { get; set; }
        [Display(Name = "Address")]
        public string Street { get; set; }

    //public string Id { get; set; }

        //[Display(Name = "Address")]
        //public string Address { get; set; }

        //[Display(Name = "School Name")]
        //public string Name { get; set; }

        //[Display(Name = "Registration Number")]
        //public string RegNumber { get; set; }

        //[Display(Name = "Type")]
        //public string Type { get; set; }
        //[Display(Name = "Status")]
        //public string Status { get; set; }
    }
}
