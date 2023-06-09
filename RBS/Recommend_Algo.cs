﻿/*******************************************************************
*** File Name : Recommend_Algo.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : 表示する授業の名前や科目区分、単位数を絞るためのアルゴリズム。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 白石 京馬, 2023.06.26
*** V1.1 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*** V1.2 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*** V1.3 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBS
{
    public partial class Recommend_Algo
    {
        public static String[,] kirisute = new string[208, 24];
        public static String[,] siborilast = new string[208, 23];
        public static String[,] sibori1 = new string[208, 23];
        public static String[,] sibori2 = new string[208, 23];
        public static String[,] sibori3 = new string[208, 23];
        public static String[] kamoku = new string[5];
        public static String[] tani = new string[5];
        public static String[] kamokukubun = new string[5];

        /****************************************************************************
        *** Constructor  Name : Recommend_Algo()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : アンケート結果から授業を絞る。
        *** Return : ×
        ****************************************************************************/

        public Recommend_Algo()
        {
            tannijogai();
            reccomend1(Question1.pattern1);
            reccomend2(Question2.pattern2);
            reccomend3(Question3.pattern3);

        }

        /****************************************************************************
        *** Method Name : tannijogai()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : 現在すでにとっているあるいは履修している科目を選択肢から外す
        *** Return : ×
        ****************************************************************************/

        public void tannijogai()
        {
            //kir 今取った単位の名前
            String[] kir = new string[200];
            for (int lk = 0; lk < 200; lk++)
            {
                kir[lk] = File_Input.Kamoku[lk, 1];
                if (File_Input.Kamoku[lk, 1] == null) break;

            }

            Excel_Tebiki instance2 = new Excel_Tebiki();
            int index = 0;
            for (int k = 0; k < 208; k++)
            {
                int lm = 0;
                for (int lk = 0; lk < 200; lk++)
                {
                    if (kir[lk] == null) break;
                    if (kir[lk] == Excel_Tebiki.Data[k, 3])
                    {
                        lm = 1;
                        break;
                    }
                }
                if(lm==0)
                {
                    if (Excel_Tebiki.Data[k, 0] == "") break;
                    for (int j = 0; j < 23; j++)
                    {
                        kirisute[index, j] = Excel_Tebiki.Data[k, j];
                    }
                    index++;
                }

            }

        }


        /****************************************************************************
        *** Method Name : recommend1()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : 専門科目かそれ以外かで絞り、新しい配列で格納
        *** Return : ×
        ****************************************************************************/

        public void reccomend1(int pattern1)
        {
            int index = 0;
            //専門科目絞り
            if (pattern1 == 0)
            {

                for (int i = 0; i < 200; i++)
                {
                    if (kirisute[i, 0] == "") break;
                    if (kirisute[i, 0] == "専門" && kirisute[i, 0] != "")
                    {
                        for (int j = 0; j < 23; j++)
                        {
                            sibori1[index, j] = kirisute[i, j];
                        }
                        index++;
                    }

                }

            }
            else
            {
                for (int i = 1; i < 200; i++)
                {
                    if (kirisute[i, 0] == null || kirisute[i, 0] == "専門") break;
                    if (kirisute[i, 0] != "専門" && kirisute[i, 0] != null)
                    {
                        for (int j = 0; j < 23; j++)
                        {
                            sibori1[index, j] = kirisute[i, j];
                        }
                        index++;
                    }

                }
            }

        }

        /****************************************************************************
        *** Method Name : recommend2()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : レポートの評価が大きいかか、テストとの点が大きいかで絞り、新しい配列で格納
        *** Return : ×
        ****************************************************************************/

        public void reccomend2(int pattern2)
        {
            //レポートの評価大
            int index = 0;
            if (pattern2 == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (sibori1[i, 0] == null) break;
                    if (int.Parse(sibori1[i, 21]) != -1 && sibori1[i, 0] != "")
                    {
                        if (sibori1[i, 0] == "専門")
                        {
                            if (int.Parse(sibori1[i, 21]) > 30)
                            {
                                for (int j = 0; j < 23; j++)
                                {
                                    sibori2[index, j] = sibori1[i, j];
                                }
                                index++;
                            }

                        }
                        else if (int.Parse(sibori1[i, 21]) > 50)
                        {
                            for (int j = 0; j < 23; j++)
                            {
                                sibori2[index, j] = sibori1[i, j];
                            }
                            index++;
                        }
                    }

                }

            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    if (sibori1[i, 0] == null) break;
                    if (int.Parse(sibori1[i, 21]) != -1)
                    {
                        if (sibori1[i, 0] == "専門")
                        {
                            if (int.Parse(sibori1[i, 21]) > 30)
                            {
                                for (int j = 0; j < 23; j++)
                                {
                                    sibori2[index, j] = sibori1[i, j];
                                }
                                index++;
                            }

                        }
                        else if (int.Parse(sibori1[i, 21]) < 50 && sibori1[i, 0] != null)
                        {
                            for (int j = 0; j < 23; j++)
                            {
                                sibori2[index, j] = sibori1[i, j];
                            }
                            index++;
                        }
                    }

                }
            }

        }


        /****************************************************************************
        *** Method Name : recommend3()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : GPAを気にしているかで絞り、新しい配列で格納
        *** Return : ×
        ****************************************************************************/

        public void reccomend3(int pattern3)
        {
            //GPA
            int index = 0;
            if (pattern3 == 0)
            {
                for (int i = 0; i < 30; i++)
                {
                    if (sibori2[i, 0] == null) break;
                    if (int.Parse(sibori2[i, 21]) != -1)
                    {
                        if (double.Parse(sibori2[i, 17]) > 50)
                        {
                            for (int j = 0; j < 23; j++)
                            {
                                sibori3[index, j] = sibori2[i, j];
                            }
                            index++;
                        }
                    }

                }

            }
            else
            {
                for (int i = 0; i < 30; i++)
                {
                    if (sibori2[i, 0] == null) break;
                    if (int.Parse(sibori2[i, 21]) != -1)
                    {
                        if (double.Parse(sibori2[i, 17]) + double.Parse(sibori2[i, 18]) + double.Parse(sibori2[i, 19]) > 70 && sibori2[i, 0] != null)
                        {
                            for (int j = 0; j < 23; j++)
                            {
                                sibori3[index, j] = sibori2[i, j];
                            }
                            index++;
                        }
                    }

                }
            }

        }
    }
}
