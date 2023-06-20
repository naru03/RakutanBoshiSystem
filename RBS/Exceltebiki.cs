using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;

namespace RBS
{
    public partial class Exceltebiki
    {
        public static String[,] Data = new string[300, 300];

        public Exceltebiki()
        {
            const string path = @"./GPA分布.xlsx"; //パスは変えてください。
            XLWorkbook book = new XLWorkbook(path);
            var ws = book.Worksheet(1);


            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            // セルの値を読み取り
            //行数だけ繰り返す
            for (int row = 0; row < 208; row++)
            {
                //列数だけ繰り返す
                for (int col = 0; col < 22; col++)
                {
                    //文字列型に変換
                    string value = ws.Cell(row + 2, col + 1).Value.ToString();
                    Data[row, col] = value;
                    Console.WriteLine(Data[row, col]);

                }
            }
        }
    }
}
