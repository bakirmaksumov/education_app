using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model.Models
{
    public partial class CertificateType
    {
        public CertificateType()
        {
            CertificateConfirmations = new HashSet<CertificateConfirmation>();
            CertificateTemplates = new HashSet<CertificateTemplate>();
            StudentCertificates = new HashSet<StudentCertificate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CertificateConfirmation> CertificateConfirmations { get; set; }
        public virtual ICollection<CertificateTemplate> CertificateTemplates { get; set; }
        public virtual ICollection<StudentCertificate> StudentCertificates { get; set; }
    }
}
