﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class ParttimeEmployee:Employee
    {
        public int workingHour {  get; set; }
        public override double calSalary()
        {
            return base.calSalary()+100000*workingHour;
        }
    }
}
