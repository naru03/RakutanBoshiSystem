﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace アンケート管理部
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
                
                var form2= new recommend();
                form2.Show();


            }
            else
            {
                label1.Text = "どちらか選択してください！";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            question.ctr3.Visible = false;
            question.ctr2.Visible = true;
            
        }
    }
}