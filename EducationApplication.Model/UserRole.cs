﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model
{
    public partial class UserRole
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
