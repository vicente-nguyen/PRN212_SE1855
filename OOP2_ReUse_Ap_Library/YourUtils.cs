﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_ReUse_Ap_Library
{
    public static class YourUtils
    {
        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year-emp.Birthday.Year+1;
        }
    }
}
