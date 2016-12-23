using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGTempCF.DataModels
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        
        //public string LastName { get; set; }
        
        //public string FirstName { get; set; }

        [StringLength(100)]
        [Display(Name = "Длъжност")]
        public string Position { get; set; }

        [StringLength(1000)]
        [Display(Name = "Професионален опит")]
        public string Experience { get; set; }

        [StringLength(1000)]
        [Display(Name = "За мен")]
        public string AboutMe { get; set; }

        [StringLength(1000)]
        [Display(Name = "Защо работя в детска градина")]
        public string WhyWorkInAKindergarten { get; set; }
        
        //public virtual ICollection<File> Files { get; set; }
    }
}
