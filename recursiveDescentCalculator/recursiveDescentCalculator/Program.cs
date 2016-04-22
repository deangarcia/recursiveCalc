using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Dean Garcia
 * ID: 012113996
 * CECS 444
 * Programming Excercise 4.29
 * The purpose of this program is to create a simple integer arithmetic recursive descent calculator 
 * that can perform the following mathematical operations: +, -, /, *, %, ^ in order to get an idea 
 * of how compilers generate expression trees from tokens. 
 */

namespace recursiveDescentCalculator
{
    static class Program
    {
        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
