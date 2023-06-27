/*******************************************************************
*** File Name : Question1.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : 一つ目のアンケートを表示する。
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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace RBS
{
    public partial class Question1 : UserControl
    {
        public static int pattern1;

        public Question1()
        {
            InitializeComponent();
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
                    pattern1 = 0;
                }
                else
                {
                    pattern1 = 1;
                }
                question.ctr1.Visible = false;
                question.ctr2.Visible = true;


            }
            else
            {
                label1.Text = "どちらか選択してください！";

            }

        }
    }
}
