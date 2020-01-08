using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class ReportCard
    {
        public void DisplayData() {
            System.Data.DataTable report = new System.Data.DataTable();
            report.Clear();
            report.Columns.Add("Name");
            report.Columns.Add("Grade");
           
            System.Data.DataRow marshall = report.NewRow();
            marshall["Name"] = "Marshall";
            marshall["Grade"] = "0";
            report.Rows.Add(marshall);

            System.Data.DataRow todrick = report.NewRow();
            todrick["Name"] = "Todrick";
            todrick["Grade"] = "0";
            report.Rows.Add(todrick);

            System.Data.DataRow aria = report.NewRow();
            aria["Name"] = "Aria";
            aria["Grade"] = "0";
            report.Rows.Add(aria);

            Console.WriteLine(report);
        }
    }
}
