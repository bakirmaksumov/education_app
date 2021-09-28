using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model.Models
{
    public partial class Status
    {
        public Status()
        {
            StudentCertificates = new HashSet<StudentCertificate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentCertificate> StudentCertificates { get; set; }
    }
}
