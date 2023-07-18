/*******************************************************************
*** File Name : Score_Manage.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.07.03
*** Purpose : 現在の単位数を計算する。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 白石 京馬, 2023.06.26
*** V1.1 : 鵜飼 航希, 2023.07.01 Score_Manage
*** V1.2 : 植竹 航也, 2023.07.03 Score_Manage
*** V1.3 : 篠塚 勇希, 2023.07.11 Score_Manage
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
    public partial class Score_Manage
    {

        //今までとった単位数
        public static int senmonsum = 0;
        public static int jinbunsum = 0;
        public static int gengosum = 0;
        public static int taikusum = 0;
        public static int suurisum = 0;
        public static int allscore = 0;
        public static int zengaku = 0;
        public static int kyoutuu = 0;
        public static int gakkakateigai = 0;
        public static int allscore_max = 0;
        public static int senmonsum_max = 0;
        public static int jinbunsum_max = 0;
        public static int gengosum_max = 0;
        public static int taikusum_max = 0;
        public static int suurisum_max = 0;
        public static int zengaku_max = 0;
        public static int kyoutuu_max = 0;
        public static int gakkakateigai_max = 0;

        public static int graph_suuri1sum = 0;
        public static int graph_suuri2sum = 0;
        public static int graph_suuri3sum = 0;
        public static int graph_suuri4sum = 0;
        public static int graph_genngo1sum = 0;
        public static int graph_genngo2sum = 0;
        public static int graph_genngo3sum = 0;
        public static int graph_genngo4sum = 0;
        public static int graph_zinnbunn1sum = 0;
        public static int graph_zinnbunn2sum = 0;
        public static int graph_zinnbunn3sum = 0;
        public static int graph_zinnbunn4sum = 0;
        public static int graph_taiiku1sum = 0;
        public static int graph_taiiku2sum = 0;
        public static int graph_taiiku3sum = 0;
        public static int graph_taiiku4sum = 0;
        public static int graph_sennmonn1sum = 0;
        public static int graph_sennmonn2sum = 0;
        public static int graph_sennmonn3sum = 0;
        public static int graph_sennmonn4sum = 0;

        /****************************************************************************
        *** Constructor  Name : Score_Manage()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : 読み込んだファイルの単位数を計算。
        *** Return : ×
        ****************************************************************************/
        public Score_Manage()
        {
            //scoresizeでとった単位数の列を取得
            int scoresize = File_Input.Kamoku.GetLength(0);

            //配列格納カウント用
            //int scount = 0;
            //int jcount = 0;
            //int gcount = 0;
            //int tcount = 0;
            //int zengaku = 0;
            //int kyoutuu = 0;
            //int allscore_max = 0;
            //public static int senmonsum_max = 0;
            //public static int jinbunsum_max = 0;
            //public static int gengosum_max = 0;
            //public static int taikusum_max = 0;
            //public static int suurisum_max = 0;
            //public static int zengaku_max = 0;
            //public static int kyoutuu_max = 0;
            //public static int gakkakateigai_max = 0;
            for (int i = 0; i < scoresize; i++)
            {

                if (File_Input.Kamoku[i, 0] == "学科課程外科目")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        gakkakateigai = gakkakateigai + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        gakkakateigai_max = gakkakateigai_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                }
                else if (File_Input.Kamoku[i, 0] == "全学共通科目")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        zengaku = zengaku + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        zengaku_max = zengaku_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                }
                else if (File_Input.Kamoku[i, 0] == "専門")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        senmonsum = senmonsum + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        senmonsum_max = senmonsum_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }

                }
                else if (File_Input.Kamoku[i, 0] == "人文社会系教養")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        jinbunsum = jinbunsum + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        jinbunsum_max = jinbunsum_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                }
                else if (File_Input.Kamoku[i, 0] == "言語")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        gengosum = gengosum + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        gengosum_max = gengosum_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                }
                else if (File_Input.Kamoku[i, 0] == "体育健康")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        taikusum = taikusum + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        taikusum_max = taikusum_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                }
                else if (File_Input.Kamoku[i, 0] == "数理基礎")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        suurisum = suurisum + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        suurisum_max = suurisum_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                }
                else if (File_Input.Kamoku[i, 0] == "工学部共通")
                {
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定")
                    {
                        kyoutuu = kyoutuu + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                    if (File_Input.Kamoku[i, 5] == "合格" || File_Input.Kamoku[i, 5] == "認定" || File_Input.Kamoku[i, 5] == "履修中")
                    {
                        kyoutuu_max = kyoutuu_max + int.Parse(File_Input.Kamoku[i, 4]);
                        allscore_max = allscore_max + int.Parse(File_Input.Kamoku[i, 4]);
                    }
                }

                if (File_Input.Kamoku[i, 0] == "数理基礎" && File_Input.Kamoku[i, 7] == "1" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_suuri1sum += int.Parse(File_Input.Kamoku[i, 4]);

                }
                else if (File_Input.Kamoku[i, 0] == "数理基礎" && File_Input.Kamoku[i, 7] == "2" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_suuri2sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "数理基礎" && File_Input.Kamoku[i, 7] == "3" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_suuri3sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "数理基礎" && File_Input.Kamoku[i, 7] == "4" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_suuri4sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                if (File_Input.Kamoku[i, 0] == "言語" && File_Input.Kamoku[i, 7] == "1" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_genngo1sum += int.Parse(File_Input.Kamoku[i, 4]);

                }
                else if (File_Input.Kamoku[i, 0] == "言語" && File_Input.Kamoku[i, 7] == "2" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_genngo2sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "言語" && File_Input.Kamoku[i, 7] == "3" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_genngo3sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "言語" && File_Input.Kamoku[i, 7] == "4" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_genngo4sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                if (File_Input.Kamoku[i, 0] == "人文社会系教養" && File_Input.Kamoku[i, 7] == "1" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn1sum += int.Parse(File_Input.Kamoku[i, 4]);

                }
                else if (File_Input.Kamoku[i, 0] == "人文社会系教養" && File_Input.Kamoku[i, 7] == "2" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn2sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "人文社会系教養" && File_Input.Kamoku[i, 7] == "3" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn3sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "人文社会系教養" && File_Input.Kamoku[i, 7] == "4" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn4sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                if (File_Input.Kamoku[i, 0] == "体育健康" && File_Input.Kamoku[i, 7] == "1" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku1sum += int.Parse(File_Input.Kamoku[i, 4]);

                }
                else if (File_Input.Kamoku[i, 0] == "体育健康" && File_Input.Kamoku[i, 7] == "2" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku2sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "体育健康" && File_Input.Kamoku[i, 7] == "3" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku3sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "体育健康" && File_Input.Kamoku[i, 7] == "4" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku4sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                if (File_Input.Kamoku[i, 0] == "専門" && File_Input.Kamoku[i, 7] == "1" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn1sum += int.Parse(File_Input.Kamoku[i, 4]);

                }
                else if (File_Input.Kamoku[i, 0] == "専門" && File_Input.Kamoku[i, 7] == "2" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn2sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "専門" && File_Input.Kamoku[i, 7] == "3" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn3sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
                else if (File_Input.Kamoku[i, 0] == "専門" && File_Input.Kamoku[i, 7] == "4" && File_Input.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn4sum += int.Parse(File_Input.Kamoku[i, 4]);
                }
            }


        }


    }
}
