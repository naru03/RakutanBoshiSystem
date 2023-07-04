using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Drawing;
using System.Windows.Forms;

namespace RBS
{
    partial class fileinput
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label title;
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("ＭＳ ゴシック", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(226, 43);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(455, 53);
            title.TabIndex = 1;
            title.Text = "落単防止システム";
            title.Click += title_Click;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(711, 203);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(126, 38);
            button1.TabIndex = 0;
            button1.Text = "選択";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1000, 203);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(126, 38);
            button2.TabIndex = 0;
            button2.Text = "読み込み";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 207);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 23);
            label1.TabIndex = 2;
            label1.Text = "ファイル読み込み";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(39, 145);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(188, 18);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ファイル作成のやり方";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 202);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 31);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 305);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1667, 340);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new Point(755, 145);
            label2.Name = "label2";
            label2.Size = new Size(14, 32);
            label2.TabIndex = 6;
            label2.Text = "\r\n";
            // 
            // fileinput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1749, 668);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(button1);
            Controls.Add(button2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "fileinput";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label title;
        private Label label1;
        private LinkLabel linkLabel1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
    }
}
