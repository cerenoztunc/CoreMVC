using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro_1.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippedAddress { get; set; }
        public int AppUserID { get; set; }

        //Relational prop
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
