using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model.Models
{
    public partial class GrantConfirmation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GrantId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual StudentGrant Grant { get; set; }
        public virtual User User { get; set; }
    }
}
