using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class ReportCard
    {
        System.Data.DataTable report = new System.Data.DataTable();
        public void Data()
        {
            try
            {
                report.Clear();
                report.Columns.Add("Name");
                report.Columns.Add("Grade");

                System.Data.DataRow marshall = report.NewRow();
                marshall["Name"] = "Marshall";
                marshall["Grade"] = "15";
                report.Rows.Add(marshall);

                System.Data.DataRow todrick = report.NewRow();
                todrick["Name"] = "Todrick";
                todrick["Grade"] = "83";
                report.Rows.Add(todrick);

                System.Data.DataRow aria = report.NewRow();
                aria["Name"] = "Aria";
                aria["Grade"] = "100";
                report.Rows.Add(aria);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            } 
        }
        public void DisplayData() {

            foreach (System.Data.DataColumn column in report.Columns)
            {
                Console.Write("\t{0}", column.ColumnName);
            }
            Console.WriteLine("\t");

            foreach (System.Data.DataRow row in report.Rows)
            {
                foreach (System.Data.DataColumn column in report.Columns)
                {
                    Console.Write("\t{0}", row[column]);
                }
                Console.WriteLine("\t");
            }
        }
    }
}
