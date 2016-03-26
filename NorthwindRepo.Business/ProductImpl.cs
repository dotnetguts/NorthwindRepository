using NorthwindRepo.Interfaces;
using NorthwindRepo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindRepo.Business
{
    public class ProductImpl : PetaPocoRepositoryImpl<Product>, IProduct
    {
    }
}
