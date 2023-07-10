﻿/*******************************************************************
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
*** V1.2 : 篠塚 勇希, 2023.07.11 Scoremanage
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
        public static int gakkakateigai = 0;
        public static int allscore_max = 0;
        public static int senmonsum_max = 0;
        public static int jinbunsum_max = 0;
        public static int gengosum_max = 0;
        public static int taikusum_max = 0;
        public static int suurisum_max = 0;
        public static int zengaku_max= 0;
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

                if (fileinput.Kamoku[i, 0] == "学科課程外科目")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        gakkakateigai = gakkakateigai + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    gakkakateigai_max = gakkakateigai_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "全学共通科目")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        zengaku = zengaku + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    zengaku_max = zengaku_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "専門")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        senmonsum = senmonsum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    senmonsum_max = senmonsum_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);

                }
                else if (fileinput.Kamoku[i, 0] == "人文社会系教養")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        jinbunsum = jinbunsum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    jinbunsum_max = jinbunsum_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "言語")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        gengosum = gengosum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    gengosum_max = gengosum_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "体育健康")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        taikusum = taikusum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    taikusum_max = taikusum_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "数理基礎")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        suurisum = suurisum + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    suurisum_max = suurisum_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "工学部共通")
                {
                    if (fileinput.Kamoku[i, 5] == "合格" || fileinput.Kamoku[i, 5] == "認定")
                    {
                        kyoutuu = kyoutuu + int.Parse(fileinput.Kamoku[i, 4]);
                        allscore = allscore + int.Parse(fileinput.Kamoku[i, 4]);
                    }
                    kyoutuu_max = kyoutuu_max + int.Parse(fileinput.Kamoku[i, 4]);
                    allscore_max = allscore_max + int.Parse(fileinput.Kamoku[i, 4]);
                }
                
                if (fileinput.Kamoku[i, 0] == "数理基礎" && fileinput.Kamoku[i, 7] == "1" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_suuri1sum += int.Parse(fileinput.Kamoku[i, 4]);

                }
                else if (fileinput.Kamoku[i, 0] == "数理基礎" && fileinput.Kamoku[i, 7] == "2" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_suuri2sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "数理基礎" && fileinput.Kamoku[i, 7] == "3" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_suuri3sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "数理基礎" && fileinput.Kamoku[i, 7] == "4" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_suuri4sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                if (fileinput.Kamoku[i, 0] == "言語" && fileinput.Kamoku[i, 7] == "1" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_genngo1sum += int.Parse(fileinput.Kamoku[i, 4]);

                }
                else if (fileinput.Kamoku[i, 0] == "言語" && fileinput.Kamoku[i, 7] == "2" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_genngo2sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "言語" && fileinput.Kamoku[i, 7] == "3" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_genngo3sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "言語" && fileinput.Kamoku[i, 7] == "4" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_genngo4sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                if (fileinput.Kamoku[i, 0] == "人文社会系教養" && fileinput.Kamoku[i, 7] == "1" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn1sum += int.Parse(fileinput.Kamoku[i, 4]);

                }
                else if (fileinput.Kamoku[i, 0] == "人文社会系教養" && fileinput.Kamoku[i, 7] == "2" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn2sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "人文社会系教養" && fileinput.Kamoku[i, 7] == "3" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn3sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "人文社会系教養" && fileinput.Kamoku[i, 7] == "4" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_zinnbunn4sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                if (fileinput.Kamoku[i, 0] == "体育健康" && fileinput.Kamoku[i, 7] == "1" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku1sum += int.Parse(fileinput.Kamoku[i, 4]);

                }
                else if (fileinput.Kamoku[i, 0] == "体育健康" && fileinput.Kamoku[i, 7] == "2" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku2sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "体育健康" && fileinput.Kamoku[i, 7] == "3" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku3sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "体育健康" && fileinput.Kamoku[i, 7] == "4" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_taiiku4sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                if (fileinput.Kamoku[i, 0] == "専門" && fileinput.Kamoku[i, 7] == "1" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn1sum += int.Parse(fileinput.Kamoku[i, 4]);

                }
                else if (fileinput.Kamoku[i, 0] == "専門" && fileinput.Kamoku[i, 7] == "2" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn2sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "専門" && fileinput.Kamoku[i, 7] == "3" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn3sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
                else if (fileinput.Kamoku[i, 0] == "専門" && fileinput.Kamoku[i, 7] == "4" && fileinput.Kamoku[i, 5] == "合格")
                {
                    graph_sennmonn4sum += int.Parse(fileinput.Kamoku[i, 4]);
                }
            }


        }


    }
}
