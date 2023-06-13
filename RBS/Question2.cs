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
        public Question2()
        {
            InitializeComponent();
        }

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
                question.ctr2.Visible = false;
                question.ctr3.Visible = true;


            }
            else
            {
                label1.Text = "どちらか選択してください！";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            question.ctr2.Visible = false;
            question.ctr1.Visible = true;

        }

        private void Question2_Load(object sender, EventArgs e)
        {

        }
    }
}
