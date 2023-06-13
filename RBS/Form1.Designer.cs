namespace RBS;

partial class Form1
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
        label1 = new Label();
        linkLabel1 = new LinkLabel();
        openFileDialog1 = new OpenFileDialog();
        textBox1 = new TextBox();
        dataGridView1 = new DataGridView();
        title = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // title
        // 
        title.AutoSize = true;
        title.Font = new Font("ＭＳ ゴシック", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
        title.Location = new Point(158, 26);
        title.Name = "title";
        title.Size = new Size(303, 35);
        title.TabIndex = 1;
        title.Text = "落単防止システム";
        title.Click += title_Click;
        // 
        // button1
        // 
        button1.Font = new Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(498, 122);
        button1.Name = "button1";
        button1.Size = new Size(88, 23);
        button1.TabIndex = 0;
        button1.Text = "選択";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("ＭＳ ゴシック", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(27, 124);
        label1.Name = "label1";
        label1.Size = new Size(135, 15);
        label1.TabIndex = 2;
        label1.Text = "ファイル読み込み";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
        linkLabel1.Location = new Point(27, 87);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(125, 12);
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
        textBox1.Location = new Point(168, 121);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(324, 23);
        textBox1.TabIndex = 4;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(27, 183);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(1167, 204);
        dataGridView1.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1224, 399);
        Controls.Add(dataGridView1);
        Controls.Add(textBox1);
        Controls.Add(linkLabel1);
        Controls.Add(label1);
        Controls.Add(title);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label title;
    private Label label1;
    private LinkLabel linkLabel1;
    private OpenFileDialog openFileDialog1;
    private TextBox textBox1;
    private DataGridView dataGridView1;
}
