using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model
{
    public partial class CertificateTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cktext { get; set; }
        public int CertificateTypeId { get; set; }
        public bool Active { get; set; }
        public bool Removed { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual CertificateType CertificateType { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
    }
}
