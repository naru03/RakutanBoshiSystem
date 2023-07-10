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
            dataGridView1.Rows.Add("単位数", Scoremanage.suurisum + "/14", Scoremanage.gengosum + "/10", "*",
                Scoremanage.jinbunsum + "/6", Scoremanage.taikusum + "/2", Scoremanage.senmonsum + "/70",
                Scoremanage.gakkakateigai, Scoremanage.zengaku, Scoremanage.kyoutuu);

            dataGridView3.Rows.Add("単位数", Scoremanage.suurisum_max + "/14", Scoremanage.gengosum_max + "/10", "*",
                Scoremanage.jinbunsum_max + "/6", Scoremanage.taikusum_max + "/2", Scoremanage.senmonsum_max + "/70",
                Scoremanage.gakkakateigai_max, Scoremanage.zengaku_max, Scoremanage.kyoutuu_max);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //カラム数指定
            dataGridView2.ColumnCount = 3;

            //総取得単位表示(取得済み)
            label4.Text = Scoremanage.allscore + "/124";

            label7.Text = Scoremanage.allscore_max + "/124";

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
            if (recommendalgo.sibori3[0, 0] == null)
            {
                dataGridView2.Rows.Add("1.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("1. " + recommendalgo.sibori3[0, 0], recommendalgo.sibori3[0, 3], recommendalgo.sibori3[0, 4]);
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = recommendalgo.sibori3[0, 22];
                dataGridView2.Rows[0].Cells["LinkColumn"] = linkCell;
            }

            if (recommendalgo.sibori3[1, 0] == null)
            {
                dataGridView2.Rows.Add("2.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("2. " + recommendalgo.sibori3[1, 0], recommendalgo.sibori3[1, 3], recommendalgo.sibori3[1, 4]);
                DataGridViewLinkCell linkCell2 = new DataGridViewLinkCell();
                linkCell2.Value = recommendalgo.sibori3[1, 22];
                dataGridView2.Rows[1].Cells["LinkColumn"] = linkCell2;
            }

            if (recommendalgo.sibori3[2, 0] == null)
            {
                dataGridView2.Rows.Add("3.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("3. " + recommendalgo.sibori3[2, 0], recommendalgo.sibori3[2, 3], recommendalgo.sibori3[2, 4]);
                DataGridViewLinkCell linkCell3 = new DataGridViewLinkCell();
                linkCell3.Value = recommendalgo.sibori3[2, 22];
                dataGridView2.Rows[2].Cells["LinkColumn"] = linkCell3;
            }

            if (recommendalgo.sibori3[3, 0] == null)
            {
                dataGridView2.Rows.Add("4.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("4. " + recommendalgo.sibori3[3, 0], recommendalgo.sibori3[3, 3], recommendalgo.sibori3[3, 4]);
                DataGridViewLinkCell linkCell4 = new DataGridViewLinkCell();
                linkCell4.Value = recommendalgo.sibori3[3, 22];
                dataGridView2.Rows[3].Cells["LinkColumn"] = linkCell4;
            }

            if (recommendalgo.sibori3[4, 0] == null)
            {
                dataGridView2.Rows.Add("5.あなたの", "おすすめは", "ありません");
            }
            else
            {
                dataGridView2.Rows.Add("5. " + recommendalgo.sibori3[4, 0], recommendalgo.sibori3[4, 3], recommendalgo.sibori3[4, 4]);
                DataGridViewLinkCell linkCell5 = new DataGridViewLinkCell();
                linkCell5.Value = recommendalgo.sibori3[4, 22];
                dataGridView2.Rows[4].Cells["LinkColumn"] = linkCell5;
            }

            //データ真ん中
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //一番左野項目列を削除
            dataGridView2.RowHeadersVisible = false;

        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            recommendalgo.sibori1 = new string[208, 23];
            recommendalgo.sibori2 = new string[208, 23];
            recommendalgo.sibori3 = new string[208, 23];
            question.ctr3.Visible = false;
            question.ctr1.Visible = true;
            
            Scoremanage.graph_suuri1sum = 0;
            Scoremanage.graph_suuri2sum = 0;
            Scoremanage.graph_suuri3sum = 0;
            Scoremanage.graph_suuri4sum = 0;
            Scoremanage.graph_genngo1sum = 0;
            Scoremanage.graph_genngo2sum = 0;
            Scoremanage.graph_genngo3sum = 0;
            Scoremanage.graph_genngo4sum = 0;
            Scoremanage.graph_zinnbunn1sum = 0;
            Scoremanage.graph_zinnbunn2sum = 0;
            Scoremanage.graph_zinnbunn3sum = 0;
            Scoremanage.graph_zinnbunn4sum = 0;
            Scoremanage.graph_taiiku1sum = 0;
            Scoremanage.graph_taiiku2sum = 0;
            Scoremanage.graph_taiiku3sum = 0;
            Scoremanage.graph_taiiku4sum = 0;
            Scoremanage.graph_sennmonn1sum = 0;
            Scoremanage.graph_sennmonn2sum = 0;
            Scoremanage.graph_sennmonn3sum = 0;
            Scoremanage.graph_sennmonn4sum = 0;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graph Graph = new graph();
            Graph.Show();
        }
    }
}
