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
    public partial class Question3 : UserControl
    {
        public static int pattern3;

       /****************************************************************************
       *** Constructor  Name : Question3()
       *** Designer : 白石 京馬
       *** Date : 2023.6.26
       *** Method : GUIアプリケーションの初期化処理を行う。
       *** Return : ×
       ****************************************************************************/

        public Question3()
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
                    pattern3 = 0;
                }
                else
                {
                    pattern3 = 1;
                }

                Score_Manage.taikusum = 0;
                Score_Manage.gengosum = 0;
                Score_Manage.senmonsum = 0;
                Score_Manage.suurisum = 0;
                Score_Manage.allscore = 0;
                Score_Manage.jinbunsum = 0;
                Score_Manage.zengaku = 0;
                Score_Manage.kyoutuu = 0;
                Score_Manage.gakkakateigai = 0;
                Score_Manage.allscore_max = 0;
                Score_Manage.senmonsum_max = 0;
                Score_Manage.jinbunsum_max = 0;
                Score_Manage.gengosum_max = 0;
                Score_Manage.taikusum_max = 0;
                Score_Manage.suurisum_max = 0;
                Score_Manage.zengaku_max = 0;
                Score_Manage.kyoutuu_max = 0;
                Score_Manage.gakkakateigai_max = 0;


                var form2 = new Recommend();
                form2.Show();
            }
            else
            {
                label1.Text = "どちらか選択してください！";

            }
        }

        /****************************************************************************
        *** Method Name : button2_Click()
        *** Designer : 白石 京馬
        *** Date : 2023.06.26
        *** Method : ボタンclick時に前のアンケート画面へ遷移
        *** Return : ×
        ****************************************************************************/

        private void button2_Click(object sender, EventArgs e)
        {

            Question.ctr3.Visible = false;
            Question.ctr2.Visible = true;

        }
    }
}
