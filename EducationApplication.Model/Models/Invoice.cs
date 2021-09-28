using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool Payed { get; set; }
        public DateTime? PayDate { get; set; }
        public int SchoolId { get; set; }
        public int Amount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Url { get; set; }
        public bool? IsCash { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
