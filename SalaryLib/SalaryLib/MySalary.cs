﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryLib
{
    public class MySalary
    {
        private double basic,net,da,hra,tax;

        public MySalary()
        {
            Console.WriteLine("************ Calculate Net Salary ******************");
            basic = 0;
            net = 0;

        }
        public double CalcuateSal(long b)
        {
            da = (b * 0.2);
            hra = (b * 0.3);
            tax = (b * 0.1);
            net = (b + da + hra) - tax;
            return net;

        }
    }
}
