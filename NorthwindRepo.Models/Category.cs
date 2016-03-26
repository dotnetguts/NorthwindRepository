using System;
using System.Collections.Generic;

namespace NorthwindRepo.Models.Models
{
    [PetaPoco.TableName("Categories")]
    [PetaPoco.PrimaryKey("CategoryID")]
    public class Category
    {
     
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
     
    }
}
