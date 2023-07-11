/*******************************************************************
*** File Name : File_Input.cs
*** Version : V1.0
*** Designer : ���{ ����
*** Date : 2023.06.26
*** Purpose : �t�@�C����ǂݍ��݁A��ʕ\�����s���B
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : ���{ ����, 2023.06.26
*** V1.1 : ���� ���n, 2023.06.30 linkLabel1_LinkClicked
*** V1.2 : �L�� �q��, 2023.07.03 button2_Click
*** V1.3 : �C���Җ�, yyyy.mm.dd �������W���[����������
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
        *** Designer : ���� ���n
        *** Date : 2023.6.26
        *** Method : GUI�A�v���P�[�V�����̏������������s���B
        *** Return : �~
        ****************************************************************************/

        public File_Input()
        {
            InitializeComponent();
        }

        /****************************************************************************
        *** Method Name : Form1_Load()
        *** Designer : ���{ ����
        *** Date : 2023.6.26
        *** Method : �ǂݍ���html�t�@�C���̎��Ƃ�\�����邽�߂̕\�쐬
        *** Return : �~
        ****************************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].HeaderText = "�n�E�S";
            dataGridView1.Columns[1].HeaderText = "�Ȗږ�";
            dataGridView1.Columns[2].HeaderText = "�Ȗ�";
            dataGridView1.Columns[3].HeaderText = "�P�ʋ敪";
            dataGridView1.Columns[4].HeaderText = "�P�ʐ�";
            dataGridView1.Columns[5].HeaderText = "����";
            dataGridView1.Columns[6].HeaderText = "�]��";
            dataGridView1.Columns[7].HeaderText = "�N��";
            dataGridView1.Columns[8].HeaderText = "�N�x";
            dataGridView1.Columns[9].HeaderText = "��";
            dataGridView1.Columns[10].HeaderText = "����";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /****************************************************************************
        *** Method Name : button1_Click()
        *** Designer : ���{ ����
        *** Date : 2023.6.26
        *** Method : �ǂݍ��ރt�@�C���̑I�����s���A���̎��Ƃ̏���z��Ɋi�[
        *** Return : �~
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
        *** Designer : �L�� �q��
        *** Date : 2023.6.26
        *** Method : �ǂݍ��ރt�@�C���̌`����"htm"��"html"���b�Z�[�W�łȂ���΁A�G���[���b�Z�[�W�\��
        *** Return :�@�~
        ****************************************************************************/

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1 == null || textBox1.Text.Contains(".htm") == false && textBox1.Text.Contains(".html") == false)
            {
                label2.Text = "�t�@�C��������܂���I";
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
        *** Designer : ���� ���n
        *** Date : 2023.6.26
        *** Method : "�t�@�C���쐬�̂���"�̃����N���N���b�N����Ɛ�����ʕ\��
        *** Return :�@�~
        ****************************************************************************/

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Setumei = new Setumei();
            Setumei.Show();
        }
    }
}