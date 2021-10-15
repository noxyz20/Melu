using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;
using DataContracts;

namespace Services
{
    public class Reader
    {
        public List<Column> readXls(String filePath)
        {
            var workbook = new WorkBook(filePath);
            var sheet = workbook.DefaultWorkSheet;
            var columns = new List<Column>();
            var firstLine = true;
            foreach (var row in sheet.Rows)
            {
                if (row.Columns[0].Value.ToString() == "") break;
                var i = 0;
                foreach (var column in row.Columns)
                {
                    var cell = column.Value.ToString();
                    if (firstLine)
                    {
                        columns.Add(new Column()
                        {
                            name = cell,
                            cells = new List<DataContracts.Cell>(),
                            id = Guid.NewGuid()
                        });
                    }
                    else
                    {
                        columns[i].cells.Add(new DataContracts.Cell()
                        {
                            content = cell
                        });

                    }
                    i++;

                }
                firstLine = false;
            }
            return columns;
        }

        public void createXls()
        {
            var workbook = WorkBook.Create(ExcelFileFormat.XLSX);
            var sheet = workbook.CreateWorkSheet("toto");

            sheet["A1"].Value = "Hello";
            sheet["A2"].Value = "World";

            workbook.SaveAs(@"C:\Users\storm\Documents\Cours\C#\Melu\test.xlsx");
        }
    }
}