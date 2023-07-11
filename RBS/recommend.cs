/*******************************************************************
*** File Name : Recommend.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : レコメンドされた授業、単位数、総単位を画面表示。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 作成者名, 白石京馬.06.26
*** V1.1 : 修正者名, 植竹航也.07.04 Form2_load_1
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
using System.Reflection.Emit;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Globalization;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Drawing.Charts;
using RBS;
using static System.Windows.Forms.DataFormats;

namespace RBS
{
    public partial class Recommend : Form
    {
        /****************************************************************************
        *** Constructor  Name : recommend()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : GUIアプリケーションの初期化処理を行う。
        *** Return : ×
        ****************************************************************************/

        public Recommend()
        {
            InitializeComponent();
        }

        /****************************************************************************
        *** Method Name : Form2_Load_1()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : 現在の総単位数や取得予定単位数の表示を行う
        *** Return : ×
        ****************************************************************************/

        private void Form2_Load_1(object sender, EventArgs e)
        {
            Score_Manage instance = new Score_Manage();
            Recommend_Algo instance2 = new Recommend_Algo();

            // 今取った単位数確認
            dataGridView1.Rows.Add("単位数", Score_Manage.suurisum + "/14", Score_Manage.gengosum + "/10", "*",
                Score_Manage.jinbunsum + "/6", Score_Manage.taikusum + "/2", Score_Manage.senmonsum + "/70",
                Score_Manage.gakkakateigai, Score_Manage.zengaku, Score_Manage.kyoutuu);

            dataGridView3.Rows.Add("単位数", Score_Manage.suurisum_max + "/14", Score_Manage.gengosum_max + "/10", "*",
                Score_Manage.jinbunsum_max + "/6", Score_Manage.taikusum_max + "/2", Score_Manage.senmonsum_max + "/70",
                Score_Manage.gakkakateigai_max, Score_Manage.zengaku_max, Score_Manage.kyoutuu_max);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //カラム数指定
            dataGridView2.ColumnCount = 3;

            //総取得単位表示(取得済み)
            label4.Text = Score_Manage.allscore + "/124";

            label7.Text = Score_Manage.allscore_max + "/124";

            //カラム指定
            dataGridView2.Columns[0].HeaderText = "科目区分";
            dataGridView2.Columns[1].HeaderText = "授業名";
            dataGridView2.Columns[2].HeaderText = "単位数";

            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "リンク";
            linkColumn.Name = "LinkColumn";
            dataGridView2.Columns.Add(linkColumn);


            dataGridView2.CellContentClick += dataGridView2_CellContentClick;

            //データを追加
            if (Recommend_Algo.sibori3[0, 0] == null)
            {
                dataGridView2.Rows.Add("1.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("1. " + Recommend_Algo.sibori3[0, 0], Recommend_Algo.sibori3[0, 3], Recommend_Algo.sibori3[0, 4]);
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = Recommend_Algo.sibori3[0, 22];
                dataGridView2.Rows[0].Cells["LinkColumn"] = linkCell;
            }

            if (Recommend_Algo.sibori3[1, 0] == null)
            {
                dataGridView2.Rows.Add("2.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("2. " + Recommend_Algo.sibori3[1, 0], Recommend_Algo.sibori3[1, 3], Recommend_Algo.sibori3[1, 4]);
                DataGridViewLinkCell linkCell2 = new DataGridViewLinkCell();
                linkCell2.Value = Recommend_Algo.sibori3[1, 22];
                dataGridView2.Rows[1].Cells["LinkColumn"] = linkCell2;
            }

            if (Recommend_Algo.sibori3[2, 0] == null)
            {
                dataGridView2.Rows.Add("3.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("3. " + Recommend_Algo.sibori3[2, 0], Recommend_Algo.sibori3[2, 3], Recommend_Algo.sibori3[2, 4]);
                DataGridViewLinkCell linkCell3 = new DataGridViewLinkCell();
                linkCell3.Value = Recommend_Algo.sibori3[2, 22];
                dataGridView2.Rows[2].Cells["LinkColumn"] = linkCell3;
            }

            if (Recommend_Algo.sibori3[3, 0] == null)
            {
                dataGridView2.Rows.Add("4.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("4. " + Recommend_Algo.sibori3[3, 0], Recommend_Algo.sibori3[3, 3], Recommend_Algo.sibori3[3, 4]);
                DataGridViewLinkCell linkCell4 = new DataGridViewLinkCell();
                linkCell4.Value = Recommend_Algo.sibori3[3, 22];
                dataGridView2.Rows[3].Cells["LinkColumn"] = linkCell4;
            }


            if (Recommend_Algo.sibori3[4, 0] == null)
            {
                dataGridView2.Rows.Add("5.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("5. " + Recommend_Algo.sibori3[4, 0], Recommend_Algo.sibori3[4, 3], Recommend_Algo.sibori3[4, 4]);
                DataGridViewLinkCell linkCell5 = new DataGridViewLinkCell();
                linkCell5.Value = Recommend_Algo.sibori3[4, 22];
                dataGridView2.Rows[4].Cells["LinkColumn"] = linkCell5;
            }

            //データ真ん中
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //一番左野項目列を削除
            dataGridView2.RowHeadersVisible = false;

        }

        /****************************************************************************
        *** Method Name : dataGridView2_CellContentClick()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : 提案された授業のリンクをクリックすることで、その授業のシラバスに飛ぶ
        *** Return : ×
        ****************************************************************************/

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string link = dataGridView2.Rows[e.RowIndex].Cells[dataGridView2.Columns["LinkColumn"].Index].Value.ToString();

            if (!string.IsNullOrEmpty(link))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });
            }

        }


        /****************************************************************************
        *** Method Name : button1_Click()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method :「おしまい」ボタンクリックによりすべての画面を閉じる
        *** Return : ×
        ****************************************************************************/

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        /****************************************************************************
        *** Method Name : button2_Click()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : 「レコメンドしなおし」ボタンをクリックすることで、絞った授業の配列を初期化し、アンケートを取り直す
        *** Return : ×
        ****************************************************************************/

        private void button2_Click(object sender, EventArgs e)
        {
            Recommend_Algo.sibori1 = new string[208, 23];
            Recommend_Algo.sibori2 = new string[208, 23];
            Recommend_Algo.sibori3 = new string[208, 23];
            Question.ctr3.Visible = false;
            Question.ctr1.Visible = true;

            Score_Manage.graph_suuri1sum = 0;
            Score_Manage.graph_suuri2sum = 0;
            Score_Manage.graph_suuri3sum = 0;
            Score_Manage.graph_suuri4sum = 0;
            Score_Manage.graph_genngo1sum = 0;
            Score_Manage.graph_genngo2sum = 0;
            Score_Manage.graph_genngo3sum = 0;
            Score_Manage.graph_genngo4sum = 0;
            Score_Manage.graph_zinnbunn1sum = 0;
            Score_Manage.graph_zinnbunn2sum = 0;
            Score_Manage.graph_zinnbunn3sum = 0;
            Score_Manage.graph_zinnbunn4sum = 0;
            Score_Manage.graph_taiiku1sum = 0;
            Score_Manage.graph_taiiku2sum = 0;
            Score_Manage.graph_taiiku3sum = 0;
            Score_Manage.graph_taiiku4sum = 0;
            Score_Manage.graph_sennmonn1sum = 0;
            Score_Manage.graph_sennmonn2sum = 0;
            Score_Manage.graph_sennmonn3sum = 0;
            Score_Manage.graph_sennmonn4sum = 0;
            this.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            graph Graph = new graph();
            Graph.Show();

        }
    }
}
