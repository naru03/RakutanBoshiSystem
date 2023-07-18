/*******************************************************************
*** File Name : File_Input.cs
*** Version : V1.0
*** Designer : 根本 成明
*** Date : 2023.06.26
*** Purpose : ファイルを読み込み、画面表示を行う。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 根本 成明, 2023.06.26
*** V1.1 : 白石 京馬, 2023.06.30 linkLabel1_LinkClicked
*** V1.2 : 鵜飼 航希, 2023.07.03 button2_Click
*** V1.3 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*/

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace RBS
{
   
    public partial class File_Input : Form
    {
        public static String[,] Kamoku = new string[100, 11];

        /****************************************************************************
        *** Constructor  Name : File_Input()
        *** Designer : 根本 成明
        *** Date : 2023.6.26
        *** Method : GUIアプリケーションの初期化処理を行う。
        *** Return : ×
        ****************************************************************************/

        public File_Input()
        {
            InitializeComponent();
        }

        /****************************************************************************
        *** Method Name : Form1_Load()
        *** Designer : 根本 成明
        *** Date : 2023.6.26
        *** Method : 読み込んだhtmlファイルの授業を表示するための表作成
        *** Return : ×
        ****************************************************************************/

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
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        /****************************************************************************
        *** Method Name : button1_Click()
        *** Designer : 根本 成明
        *** Date : 2023.6.26
        *** Method : 読み込むファイルの選択を行い、その授業の情報を配列に格納
        *** Return : ×
        ****************************************************************************/

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
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
                            Kamoku[i / 11, i % 11] = node.InnerText;
                            i++;
                            if (i % 11 == 0)
                            {
                                dataGridView1.Rows.Add(Kamoku[(i - 1) / 11, 0], Kamoku[(i - 1) / 11, 1], Kamoku[(i - 1) / 11, 2], Kamoku[(i - 1) / 11, 3], Kamoku[(i - 1) / 11, 4], Kamoku[(i - 1) / 11, 5], Kamoku[(i - 1) / 11, 6], Kamoku[(i - 1) / 11, 7], Kamoku[(i - 1) / 11, 8], Kamoku[(i - 1) / 11, 9], Kamoku[(i - 1) / 11, 10]);
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

        /****************************************************************************
        *** Method Name : button2_Click()
        *** Designer : 鵜飼 航希
        *** Date : 2023.6.26
        *** Method : 読み込むファイルの形式が"htm"か"html"メッセージでなければ、エラーメッセージ表示
        *** Return :　×
        ****************************************************************************/

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1 == null || textBox1.Text.Contains(".htm") == false && textBox1.Text.Contains(".html") == false)
            {
                label2.Text = "ファイルがありません！";
            }
            else if (dataGridView1.Rows.Count == 0)
            {
                label2.Text = "ファイルが無効です";
            }
            else
            {
                var Question = new Question();
                Question.Show();

                this.Visible = false;
            }
        }

        /****************************************************************************
        *** Method Name : linkLabel1_LinkClicked()
        *** Designer : 白石 京馬
        *** Date : 2023.6.26
        *** Method : "ファイル作成のやり方"のリンクをクリックすると説明画面表示
        *** Return :　×
        ****************************************************************************/

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Setumei = new Setumei();
            Setumei.Show();
        }
    }
}
