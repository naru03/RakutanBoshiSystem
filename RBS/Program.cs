/*******************************************************************
*** File Name : Program.cs
*** Version : V1.0
*** Designer : ���{ ����
*** Date : 2023.06.26
*** Purpose : �V�X�e�������N���B
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : �쐬�Җ�, yyyy.mm.dd
*** V1.1 : �C���Җ�, yyyy.mm.dd �������W���[����������
*** V1.2 : �C���Җ�, yyyy.mm.dd �������W���[����������
*** V1.3 : �C���Җ�, yyyy.mm.dd �������W���[����������
*/

namespace RBS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fileinput());

        }
    }
}