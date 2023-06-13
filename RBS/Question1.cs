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
