﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetanysPieShop.Models;

namespace BetanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
