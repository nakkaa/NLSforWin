﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NLSforWin
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        /// 
        
        //public static int flag;
        [STAThread]
        static void Main()
        {
            System.OperatingSystem os = System.Environment.OSVersion;
            //OSバージョンがWindows8.1でなければ終了する
            Version version = os.Version;
            if (version.Build < 9600)
            {
                MessageBox.Show("このアプリケーションは\nWIndows 8.1 以降のOSに対応しています。","エラー");
                Environment.Exit(0);
            }

            //ウィンドウ生成
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
