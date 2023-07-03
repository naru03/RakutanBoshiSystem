/*******************************************************************
*** File Name : Scoremanage.cs
*** Version : V1.1
*** Designer : 植竹　航也
*** Date : 2023.07.03
*** Purpose : 現在の単位数を計算する。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 白石 京馬, 2023.06.26
*** V1.1 : 植竹 航也, 2023.07.03
*** V1.2 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*** V1.3 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*/

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RBS
{
    public partial class Scoremanage
    {

        //専門科目の配列:s[0]
        public static string[] s = new string[100];
        //人文科目の配列:j[0]
        public static string[] j = new string[100];
        //言語科目の配列:g[0]
        public string[] g = new string[100];
        //体育科目の配列:t[0]
        public static string[] t = new string[100];

        //今までとった単位数
        public static int senmonsum = 0;
        public static int jinbunsum = 0;
        public static int gengosum = 0;
        public static int taikusum = 0;
        public static int suurisum = 0;
        public static int allscore = 0;
        public static int zengaku = 0;
        public static int kyoutuu = 0;

        public Scoremanage()
        {
            //scoresizeでとった単位数の列を取得
            int scoresize = fileinput.Kamoku.GetLength(0);

            //配列格納カウント用
            //int scount = 0;
            //int jcount = 0;
            //int gcount = 0;
            //int tcount = 0;
            //int zengaku = 0;
            //int kyoutuu = 0;
            for (int i = 0; i < scoresize; i++)
            {
                if (fileinput.Kamoku[i, 0] == "全学共通科目")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        zengaku = senmonsum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                }
                else if (fileinput.Kamoku[i, 0] == "専門")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        senmonsum = senmonsum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }

                }
                else if (fileinput.Kamoku[i, 0] == "人文社会系教養")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        jinbunsum = jinbunsum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                }
                else if (fileinput.Kamoku[i, 0] == "言語")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        gengosum = gengosum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                }
                else if (fileinput.Kamoku[i, 0] == "体育健康")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        taikusum = taikusum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                }
                else if (fileinput.Kamoku[i, 0] == "数理基礎")
                {

                    suurisum = suurisum + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "全学共通科目")
                {

                    zengaku = zengaku + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "工学部共通")
                {

                    kyoutuu = kyoutuu + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                }

            }


        }


    }
}
