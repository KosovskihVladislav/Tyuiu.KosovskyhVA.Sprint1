﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosovskykhVA.Sprint1.Task1.V9.Lib
{
    public class DataService : ISprint1Task1V9
    {
        public double Calculate(double x, double y)
        {
            return (1 + 3 * x) / (4 * y);
        }
    }
}
