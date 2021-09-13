using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model.Models
{
    public partial class ContractType
    {
        public ContractType()
        {
            ContractStudents = new HashSet<ContractStudent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContractStudent> ContractStudents { get; set; }
    }
}
