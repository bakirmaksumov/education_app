using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model.Models
{
    public partial class GrantType
    {
        public GrantType()
        {
            StudentGrants = new HashSet<StudentGrant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentGrant> StudentGrants { get; set; }
    }
}
