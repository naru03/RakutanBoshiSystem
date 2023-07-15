/*******************************************************************
*** File Name : Exceltebiki.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : エクセルファイルを読み込み、成績の参照用のdataを配列に格納。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 白石 京馬, 2023.06.26
*** V1.1 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*** V1.2 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*** V1.3 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*/

using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;


namespace RBS
{

    public partial class Excel_Tebiki
    {
        public static String[,] Data = new string[300, 300];


        /****************************************************************************
        *** Constructor  Name : Exceltebiki()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : レポジトリ内のExcelファイルを読み取り、配列に格納する。
        *** Return : ×
        ****************************************************************************/

        public Excel_Tebiki()
        {
            const string path = "GPA分布.xlsx";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);


            XLWorkbook book = new XLWorkbook(path);
            var ws = book.Worksheet(1);
          
            // セルの値を読み取り
            //行数だけ繰り返す
                for (int row = 0; row < 208; row++)
                {
                    //列数だけ繰り返す
                    for (int col = 0; col < 23; col++)
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
