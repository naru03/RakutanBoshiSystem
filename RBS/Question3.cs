/*******************************************************************
*** File Name : Question2.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : 3つ目のアンケートを表示する。
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
    public partial class Question3 : UserControl
    {
        public static int pattern3;
        public Question3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /****************************************************************************
        *** Method Name : button1_Clicki()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : ボタンclick時に次のアンケート画面へ遷移
        *** Return : ×
        ****************************************************************************/

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    pattern3 = 0;
                }
                else
                {
                    pattern3 = 1;
                }

                Scoremanage.taikusum = 0;
                Scoremanage.gengosum = 0;
                Scoremanage.senmonsum = 0;
                Scoremanage.suurisum = 0;
                Scoremanage.allscore = 0;
                Scoremanage.jinbunsum = 0;

                var form2 = new recommend();
                form2.Show();


            }
            else
            {
                label1.Text = "どちらか選択してください！";

            }
        }

        /****************************************************************************
        *** Method Name : button1_Clicki()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : ボタンclick時に前のアンケート画面へ遷移
        *** Return : ×
        ****************************************************************************/

        private void button2_Click(object sender, EventArgs e)
        {

            question.ctr3.Visible = false;
            question.ctr2.Visible = true;

        }

        private void Question3_Load(object sender, EventArgs e)
        {

        }
    }
}
