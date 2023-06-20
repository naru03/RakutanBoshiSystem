namespace RBS
{
    partial class question
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("MS UI Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(813, 90);
            label1.Name = "label1";
            label1.Size = new Size(311, 94);
            label1.TabIndex = 0;
            label1.Text = "Raku単くん";
            // 
            // panel1
            // 
            panel1.Location = new Point(181, 315);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1525, 676);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(266, 236);
            label2.Name = "label2";
            label2.Size = new Size(156, 36);
            label2.TabIndex = 2;
            label2.Text = "アンケート";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1283, 237);
            button1.Name = "button1";
            button1.Size = new Size(237, 40);
            button1.TabIndex = 3;
            button1.Text = "読み込み画面に戻る";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // question
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1733, 1050);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "question";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Button button1;
    }
}

