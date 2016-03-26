using System;
using System.Collections.Generic;

namespace NorthwindRepo.Models.Models
{
    [PetaPoco.TableName("[Order Details]")]
    [PetaPoco.PrimaryKey("OrderID")]
    public partial class Order_Detail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
