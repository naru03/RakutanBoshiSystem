namespace RBS
{
    partial class Question
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
            label1.Location = new Point(516, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 56);
            label1.TabIndex = 0;
            label1.Text = "Raku単くん";
            // 
            // panel1
            // 
            panel1.Location = new Point(11, 144);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 220);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(135, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 2;
            label2.Text = "アンケート";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(961, 64);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(190, 50);
            button1.TabIndex = 3;
            button1.Text = "読み込み画面に戻る";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // question
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1224, 401);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "question";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
    }
}

