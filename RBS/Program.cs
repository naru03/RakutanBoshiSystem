/*******************************************************************
*** File Name : Program.cs
*** Version : V1.0
*** Designer : 根本 成明
*** Date : 2023.06.26
*** Purpose : システム初期起動。
***
*******************************************************************/
/*
*** Revision :
*** V1.0 : 根本 成明, 2023.06.26
*** V1.1 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*** V1.2 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*** V1.3 : 修正者名, yyyy.mm.dd 改訂モジュール名を書く
*/

namespace RBS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        /****************************************************************************
        *** Method Name : Main()
        *** Designer : 根本 成明
         *** Date : 2023.6.26
        *** Method : アプリケーションの初期化を行い、ファイル読み込み画面から始める。
        *** Return : ×
        ****************************************************************************/

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new File_Input());
        }
    }
}