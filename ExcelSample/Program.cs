using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using ExcelNamespace = Microsoft.Office.Interop.Excel;



namespace ExcelSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ryska\Source\Repos\Samples\ExcelSample\sabrsula_zalohy_kamery.XLSX";
            _Application excel = new ExcelNamespace.Application();
            ExcelNamespace.Workbook wb = excel.Workbooks.Open(path);
            ExcelNamespace.Worksheet ws = wb.Worksheets[2];
            ExcelNamespace.Range range = ws.UsedRange;


            string[,] array = (string[,])range.;
            try
            {
                int rowCount = range.Rows.Count;
                int colCount = range.Columns.Count;

                for (int i = 1; i < rowCount; i++)
                {
                    for (int j = 1; j < colCount; j++)
                    {

                        Console.Write(range.Cells[i, j].Value2.ToString());
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(ws);

                wb.Close();
                Marshal.ReleaseComObject(wb);

                excel.Quit();
                Marshal.ReleaseComObject(excel);
            }

        }
    }
}
