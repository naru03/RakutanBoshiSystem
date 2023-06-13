using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace RBS;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.ColumnCount = 11;
        dataGridView1.Columns[0].HeaderText = "系・郡";
        dataGridView1.Columns[1].HeaderText = "科目名";
        dataGridView1.Columns[2].HeaderText = "科目";
        dataGridView1.Columns[3].HeaderText = "単位区分";
        dataGridView1.Columns[4].HeaderText = "単位数";
        dataGridView1.Columns[5].HeaderText = "判定";
        dataGridView1.Columns[6].HeaderText = "評価";
        dataGridView1.Columns[7].HeaderText = "年次";
        dataGridView1.Columns[8].HeaderText = "年度";
        dataGridView1.Columns[9].HeaderText = "期";
        dataGridView1.Columns[10].HeaderText = "教員";
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DialogResult dr = openFileDialog1.ShowDialog();
        if (dr == System.Windows.Forms.DialogResult.OK)
        {
            try
            {
                String[] Kamoku = new string[11];
                var sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
                string htmlStr = sr.ReadToEnd();
                if (htmlStr != null)
                {
                    var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                    htmlDoc.LoadHtml(htmlStr);
                    HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes("//td[@id='kyuukou' or @id='kyuukou1']");
                    int i = 0;
                    foreach (HtmlNode node in nodes)
                    {
                        Kamoku[i % 11] = node.InnerText;
                        i++;
                        if (i % 11 == 0)
                        {
                            dataGridView1.Rows.Add(Kamoku[0], Kamoku[1], Kamoku[2], Kamoku[3], Kamoku[4], Kamoku[5], Kamoku[6], Kamoku[7], Kamoku[8], Kamoku[9], Kamoku[10]);
                        }
                    }
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }

    private void title_Click(object sender, EventArgs e)
    {

    }
}
