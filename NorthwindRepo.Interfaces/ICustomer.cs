﻿using NorthwindRepo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindRepo.Interfaces
{
    public interface ICustomer : IPetaPocoRepository<Customer> 
    {
    }
}
