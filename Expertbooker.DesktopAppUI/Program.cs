﻿using EkspertBooker.DesktopAppUI.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertBooker.DesktopAppUI
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
            Application.Run(new FormLogin());

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
            {
                MessageBox.Show(e.Exception.Message, "Unhandled Thread Exception");
            }

            void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
            {
                MessageBox.Show((e.ExceptionObject as Exception).Message, "Unhandled UI Exception");
            }

        }
    }
}
