using System;
using System.Collections.Generic;

namespace EMS_New.DataEntity
{
    public partial class UserRole
    {
        public int RoleId { get; set; }
        public int? UserId { get; set; }
        public string? Name { get; set; }

        public virtual User? User { get; set; }
    }
}
