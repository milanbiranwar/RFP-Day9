﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmployeeAttendanceUC1
    {
        public static void EmployeeAttandance()
        {
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
