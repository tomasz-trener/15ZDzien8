using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04PolaczenieZExelem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open($"{AppDomain.CurrentDomain.BaseDirectory}import.xlsx");
            Worksheet arkusz = wb.ActiveSheet;

            string s = arkusz.Cells[1, 2].Value.ToString();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}