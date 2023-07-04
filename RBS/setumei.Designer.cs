namespace RBS
{
    partial class setumei
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(383, 92);
            label1.Name = "label1";
            label1.Size = new Size(502, 52);
            label1.TabIndex = 0;
            label1.Text = "[htmlファイル作成方法]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(223, 314);
            label2.Name = "label2";
            label2.Size = new Size(37, 40);
            label2.TabIndex = 1;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(325, 314);
            label3.Name = "label3";
            label3.Size = new Size(666, 40);
            label3.TabIndex = 2;
            label3.Text = "FireFoxでscomzにアクセスし、sgsotを開く";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(223, 474);
            label4.Name = "label4";
            label4.Size = new Size(37, 40);
            label4.TabIndex = 3;
            label4.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(223, 625);
            label5.Name = "label5";
            label5.Size = new Size(37, 40);
            label5.TabIndex = 4;
            label5.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(325, 474);
            label6.Name = "label6";
            label6.Size = new Size(651, 40);
            label6.TabIndex = 5;
            label6.Text = "sgsotの「履修」→「履修科目」にアクセス";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(325, 625);
            label7.Name = "label7";
            label7.Size = new Size(878, 80);
            label7.TabIndex = 6;
            label7.Text = "科目の上で右クリック→\r\n「このフレーム」→「フレームを名前を付けて保存」を選択";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(223, 791);
            label8.Name = "label8";
            label8.Size = new Size(37, 40);
            label8.TabIndex = 7;
            label8.Text = "4";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(325, 791);
            label9.Name = "label9";
            label9.Size = new Size(655, 40);
            label9.TabIndex = 8;
            label9.Text = "ファイル形式を.htmまたは.htmlにして保存";
            // 
            // setumei
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 1039);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "setumei";
            Text = "setumei";
            Load += setumei_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}