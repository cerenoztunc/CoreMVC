﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro_1.Models.Entities
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public UserRole Role { get; set; }

        //relational prop
        public virtual List<Order> Orders { get; set; }
        public virtual AppUserProfile Profile { get; set; }
    }
}
