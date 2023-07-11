/*******************************************************************
*** File Name : Question2.cs
*** Version : V1.0
*** Designer : 白石 京馬
*** Date : 2023.06.26
*** Purpose : 2つ目のアンケートを表示する。
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBS
{
    public partial class Question2 : UserControl
    {
        public static int pattern2;

        /****************************************************************************
        *** Constructor  Name : Question2()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : GUIアプリケーションの初期化処理を行う。
        *** Return : ×
        ****************************************************************************/

        public Question2()
        {
            InitializeComponent();
        }

        /****************************************************************************
        *** Method Name : button1_Click()
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
                    pattern2 = 0;
                }
                else
                {
                    pattern2 = 1;
                }
                Question.ctr2.Visible = false;
                Question.ctr3.Visible = true;


            }
            else
            {
                label1.Text = "どちらか選択してください！";

            }
        }

        /****************************************************************************
        *** Method Name : button2_Clicki()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : ボタンclick時に前のアンケート画面へ遷移
        *** Return : ×
        ****************************************************************************/

        private void button2_Click(object sender, EventArgs e)
        {
            Question.ctr2.Visible = false;
            Question.ctr1.Visible = true;

        }

        
    }
}
