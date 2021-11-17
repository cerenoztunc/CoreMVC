﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro_1.Models.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Prop
        public virtual List<Product> Products { get; set; }
    }
}
