/*******************************************************************
*** File Name : question.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : アンケートの表示画面。
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBS
{
    public partial class question : Form
    {
        public static Question1 ctr1;
        public static Question2 ctr2;
        public static Question3 ctr3;

        public question()
        {
            InitializeComponent();

            ctr1 = new Question1();
            ctr2 = new Question2();
            ctr3 = new Question3();

            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            panel1.Controls.Add(ctr3);

            ctr1.Visible = true;
            ctr2.Visible = false;
            ctr3.Visible = false;
        }


        /****************************************************************************
       *** Method Name : button1_Clicki()
       *** Designer : 白石 京馬
       *** Date : 2023.6.26
       *** Method : ボタンclick時に読み込み画面へ遷移
       *** Return : ×
       ****************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            var fileinput = new fileinput();
            fileinput.Show();

            this.Hide();
        }

        private void question_Load(object sender, EventArgs e)
        {

        }
    }
}
