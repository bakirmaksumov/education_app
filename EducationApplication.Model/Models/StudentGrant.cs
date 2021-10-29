using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model.Models
{
    public partial class StudentGrant
    {
        public StudentGrant()
        {
            GrantConfirmations = new HashSet<GrantConfirmation>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int GrantTypeId { get; set; }
        public string Url { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int StatusId { get; set; }
        public string RegistrationNumber { get; set; }
        public int Amount { get; set; }
        public bool? Removed { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual GrantType GrantType { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<GrantConfirmation> GrantConfirmations { get; set; }
    }
}
