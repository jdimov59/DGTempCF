using System;
using System.Collections.Generic;

namespace DGTempCF.DataModels
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        //public string LastName { get; set; }
        //public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}
