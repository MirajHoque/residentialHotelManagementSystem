﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MDIControl());
            //Application.Run(new User.FormChangePass());
            //Application.Run(new Employee.FormEmployeeReg());
           Application.Run(new Guest.FormGuestInfo());
            //Application.Run(new Hotel.FormHotelExpense());
        }
    }
}
