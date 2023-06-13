using System;
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
    }
}
