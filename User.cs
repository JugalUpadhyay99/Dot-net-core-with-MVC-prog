using System;
using System.Collections.Generic;

namespace EMS_New.DataEntity
{
    public partial class User
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
