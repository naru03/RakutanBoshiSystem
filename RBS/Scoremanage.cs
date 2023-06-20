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

        public Scoremanage()
        {
            //scoresizeでとった単位数の列を取得
            int scoresize = fileinput.Kamoku.GetLength(0);

            //配列格納カウント用
            int scount = 0;
            int jcount = 0;
            int gcount = 0;
            int tcount = 0;
            for (int i = 0; i < scoresize; i++)
            {
                if (fileinput.Kamoku[i, 0] == "専門")
                {

                    senmonsum = senmonsum + int.Parse(fileinput.Kamoku[i,4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);

                }
                else if (fileinput.Kamoku[i, 0] == "人文社会系教養")
                {

                    jinbunsum = jinbunsum + int.Parse(fileinput.Kamoku[i,4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "言語")
                {

                    gengosum = gengosum + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "体育健康")
                {

                    taikusum = taikusum + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "数理基礎")
                {

                    suurisum = suurisum + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                }
                  
            }

            //配列分岐
            static void main()
            { 

            }


            //取得終わり

            //それぞれの科目区分の単位数計算

            //計算終わり

            //レコメンド画面に現在の単位数の値を格納

            //格納終わり


        }


    }
}
