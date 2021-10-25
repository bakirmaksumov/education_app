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
            StudentGrants = new HashSet<StudentGrant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentCertificate> StudentCertificates { get; set; }
        public virtual ICollection<StudentGrant> StudentGrants { get; set; }
    }
}
