using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // 今取った単位数確認
            dataGridView1.Rows.Add("単位数", "○○/14", "○○/10", "*", "○○/6", "○○/2", "○○/70");
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //カラム数指定
            dataGridView2.ColumnCount = 3;

            //カラム指定
            dataGridView2.Columns[0].HeaderText = "科目区分";
            dataGridView2.Columns[1].HeaderText = "授業名";
            dataGridView2.Columns[2].HeaderText = "単位数";

            //データを追加
            dataGridView2.Rows.Add(Question1.pattern1, Question2.pattern2, Question3.pattern3);
            dataGridView2.Rows.Add("2. ○○", "○○", "○○");
            dataGridView2.Rows.Add("3. ○○", "○○", "○○");
            dataGridView2.Rows.Add("4. ○○", "○○", "○○");
            dataGridView2.Rows.Add("5. ○○", "○○", "○○");

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
