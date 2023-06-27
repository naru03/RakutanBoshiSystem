/*******************************************************************
*** File Name : recommend.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : レコメンドの表示画面。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 作成者名, yyyy.mm.dd
*** V1.1 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
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
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;

namespace RBS
{
    public partial class recommend : Form
    {

        public recommend()
        {
            InitializeComponent();
        }

        /****************************************************************************
       *** Method Name : Form2_Load_1()
       *** Designer : 白石 京馬
       *** Date : 2023.6.26
       *** Method : 単位数の表示やレコメンドした科目の表示
       *** Return : ×
       ****************************************************************************/


        private void Form2_Load_1(object sender, EventArgs e)
        {
            Scoremanage instance = new Scoremanage();
            recommendalgo instance2 = new recommendalgo();
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
            if (recommendalgo.sibori3[0, 0] == null)
            {
                dataGridView2.Rows.Add("1.あなたの", "おすすめは", "ありません");
            }
            else
            {
               
                dataGridView2.Rows.Add("1. " + recommendalgo.sibori3[0, 0], recommendalgo.sibori3[0, 3], recommendalgo.sibori3[0, 4]);
            }

            if (recommendalgo.sibori3[1, 0] == null)
            {
                dataGridView2.Rows.Add("2.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("2. " + recommendalgo.sibori3[1, 0], recommendalgo.sibori3[1, 3], recommendalgo.sibori3[1, 4]);
            }

            if (recommendalgo.sibori3[2, 0] == null)
            {
                dataGridView2.Rows.Add("3.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("3. " + recommendalgo.sibori3[2, 0], recommendalgo.sibori3[2, 3], recommendalgo.sibori3[2, 4]);
            }

            if (recommendalgo.sibori3[3, 0] == null)
            {
                dataGridView2.Rows.Add("4.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("4. " + recommendalgo.sibori3[3, 0], recommendalgo.sibori3[3, 3], recommendalgo.sibori3[3, 4]);
            }

            if (recommendalgo.sibori3[4, 0] == null)
            {
                dataGridView2.Rows.Add("5.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("5. " + recommendalgo.sibori3[4, 0], recommendalgo.sibori3[4, 3], recommendalgo.sibori3[4, 4]);
            }

            //データ真ん中
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //一番左野項目列を削除
            dataGridView2.RowHeadersVisible = false;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
