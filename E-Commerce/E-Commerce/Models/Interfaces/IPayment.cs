﻿using E_Commerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface IPayment
    {
       string Run(CheckoutViewModel sa);
    }
}
