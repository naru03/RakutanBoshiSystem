using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RBS;
using System.Reflection.Emit;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Globalization;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace RBS
{
    public partial class recommend : Form
    {
        public static String[,] kirisute = new string[208, 22];
        public static String[,] siborilast = new string[208, 22];
        public static String[,] sibori1 = new string[208, 22];
        public static String[,] sibori2 = new string[208, 22];
        public static String[,] sibori3 = new string[208, 22];
        public static String[] kamoku = new string[5];
        public static String[] tani = new string[5];
        public static String[] kamokukubun = new string[5];

        public recommend()
        {
            InitializeComponent();
        }

        //レコメンド画面表示
        //private void Reccomend_Diaplay()
        //{

        //}

        //レコメンド画面のアルゴリズム
        //private void Reccomend_Algo()
        //{

        //}

        //表に授業データやこれまでの単位数を自動で書き込む
        //private void Reccomec_Data_Input() 
        //{

        //}



        private void Form2_Load_1(object sender, EventArgs e)
        {
            Scoremanage instance = new Scoremanage();
            tannijogai();
            reccomend1(Question1.pattern1);
            reccomend2(Question2.pattern2);
            //reccomendbug();

            // 今取った単位数確認
            dataGridView1.Rows.Add("単位数", Scoremanage.suurisum + "/14", Scoremanage.gengosum + "/10", "*", Scoremanage.jinbunsum + "/6", Scoremanage.taikusum + "/2", Scoremanage.senmonsum + "/70");
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //カラム数指定
            dataGridView2.ColumnCount = 3;

            //総取得単位表示
            label4.Text = Scoremanage.allscore + "/124";

            //カラム指定
            dataGridView2.Columns[0].HeaderText = "科目区分";
            dataGridView2.Columns[1].HeaderText = "授業名";
            dataGridView2.Columns[2].HeaderText = "単位数";

            //データを追加
            dataGridView2.Rows.Add("1. " + sibori2[0, 0], sibori2[0, 3], sibori2[0, 4]);
            dataGridView2.Rows.Add("2. " + sibori2[1, 0], sibori2[1, 3], sibori2[1, 4]);
            dataGridView2.Rows.Add("3. " + sibori2[2, 0], sibori2[2, 3], sibori2[2, 4]);
            dataGridView2.Rows.Add("4. " + sibori2[3, 0], sibori2[3, 3], sibori2[3, 4]);
            dataGridView2.Rows.Add("4. " + sibori2[4, 0], sibori2[4, 3], sibori2[4, 4]);

            //データ真ん中
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //一番左野項目列を削除
            dataGridView2.RowHeadersVisible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //読み込んだファイルの科目を排除
        public void tannijogai()
        {
            String[] kir = new string[100];
            for (int lk = 0; lk < 100; lk++)
            {
                kir[lk] = fileinput.Kamoku[lk, 1];

            }

            Exceltebiki instance2 = new Exceltebiki();
            int index = 0;
            for (int k = 0; k < 208; k++)
            {
                int lm = 0;
                for (int lk = 0; lk < 100; lk++)
                {
                    if (kir[lk] == Exceltebiki.Data[k, 3])
                    {
                        lm = 1;
                    }
                }
                if (lm == 1)
                {

                }
                else
                {
                    for (int j = 0; j < 22; j++)
                    {
                        kirisute[index, j] = Exceltebiki.Data[k, j];
                    }
                    index++;
                }

            }

        }


        //絞り1回目
        public void reccomend1(int pattern1)
        {
            Exceltebiki instance2 = new Exceltebiki();
            int index = 0;
            //専門科目絞り
            if (pattern1 == 0)
            {

                for (int i = 0; i < 200; i++)
                {
                    if (kirisute[i, 0] == null) break;
                    if (kirisute[i, 0] == "専門" && kirisute[i, 0] != null)
                    {
                        for (int j = 0; j < 22; j++)
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
                    if (kirisute[i, 0] == null) break;
                    if (kirisute[i, 0] != "専門" && kirisute[i, 0] != null)
                    {
                        for (int j = 0; j < 22; j++)
                        {
                            sibori1[index, j] = kirisute[i, j];
                        }
                        index++;
                    }

                }
            }

        }



        public void reccomendbug()
        {
            if (int.Parse(sibori1[0, 21]) > 50)
            {
                sibori1[0, 21] = "aaa";
            }
        }


        //絞り2回目
        public void reccomend2(int pattern2)
        {
            //レポートの評価大
            int index = 0;
            if (pattern2 == 0)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (sibori1[i, 0] == "") break;
                    if (int.Parse(sibori1[i, 21]) != -1 && sibori1[i, 0] != "")
                    {
                        if (int.Parse(sibori1[i, 21]) > 50)
                        {
                            for (int j = 0; j < 22; j++)
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
                for (int i = 0; i < 20; i++)
                {
                    if (sibori1[i, 0] == null) break;
                    if (int.Parse(sibori1[i, 21]) != -1)
                    {
                        if (int.Parse(sibori1[i, 21]) < 50 && sibori1[i, 0] != null)
                        {
                            for (int j = 0; j < 22; j++)
                            {
                                sibori2[index, j] = sibori1[i, j];
                            }
                            index++;
                        }
                    }

                }
            }

        }
    }
}
