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

namespace RBS
{
    public partial class recommend : Form
    {

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



    }
}
