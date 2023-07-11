using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RBS
{
    partial class Recommend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column11, Column12, Column13 });
<<<<<<< HEAD
            dataGridView1.Location = new Point(245, 61);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(793, 56);
=======
            dataGridView1.Location = new Point(280, 81);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(906, 74);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "科目区分";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "数理";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "言語";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "情報";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "人文";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "体育";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "専門";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // Column11
            // 
            Column11.HeaderText = "学科外認定";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "全学共通";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "工学部共通";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            label1.Location = new Point(556, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
=======
            label1.Location = new Point(636, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            label1.TabIndex = 1;
            label1.Text = "Raku単くん";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10 });
<<<<<<< HEAD
            dataGridView2.Location = new Point(447, 279);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.ShowCellToolTips = false;
            dataGridView2.Size = new Size(370, 111);
=======
            dataGridView2.Location = new Point(492, 334);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.Size = new Size(423, 148);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            dataGridView2.TabIndex = 2;
            // 
            // Column8
            // 
            Column8.HeaderText = "科目区分";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "授業名";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "単位数";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            button1.Location = new Point(871, 318);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 47);
=======
            button1.Location = new Point(995, 424);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(107, 62);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            button1.TabIndex = 3;
            button1.Text = "おしまい";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            label2.Location = new Point(528, 125);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
=======
            label2.Location = new Point(604, 166);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            label2.TabIndex = 4;
            label2.Text = "総単位数(取得済み)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            label3.Location = new Point(194, 279);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
=======
            label3.Location = new Point(222, 372);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(240, 32);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            label3.TabIndex = 5;
            label3.Text = "あなたにおすすめの単位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            label4.Location = new Point(704, 125);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
=======
            label4.Location = new Point(805, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            label6.Location = new Point(528, 228);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 21);
=======
            label6.Location = new Point(604, 304);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            label6.TabIndex = 8;
            label6.Text = "総単位数(取得予定)";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
<<<<<<< HEAD
            dataGridView3.Location = new Point(245, 170);
            dataGridView3.Margin = new Padding(2, 2, 2, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 27;
            dataGridView3.Size = new Size(793, 56);
=======
            dataGridView3.Location = new Point(280, 218);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 27;
            dataGridView3.Size = new Size(906, 74);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            dataGridView3.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "科目区分";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "数理";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "言語";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "情報";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "人文";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "体育";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "専門";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "学科外認定";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "全学共通";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "工学部共通";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            label7.Location = new Point(705, 228);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
=======
            label7.Location = new Point(806, 304);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 28);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            label7.TabIndex = 10;
            label7.Text = "label7";
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            button2.Location = new Point(246, 338);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(155, 26);
=======
            button2.Location = new Point(282, 451);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(178, 35);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            button2.TabIndex = 11;
            button2.Text = "レコメンドしなおし";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1242, 248);
            button3.Name = "button3";
            button3.Size = new Size(132, 44);
            button3.TabIndex = 12;
            button3.Text = "学年別取得単位";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // recommend
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1224, 401);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1399, 534);
            Controls.Add(button3);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(dataGridView3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
<<<<<<< HEAD
            Margin = new Padding(2, 2, 2, 2);
=======
            Margin = new Padding(2);
>>>>>>> a9f21b5f6547461dcca1715013d52d7298b1eb88
            Name = "recommend";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}