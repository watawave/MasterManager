using INTEC.Med.CommonLibrary;                          //add
using INTEC.Med.MasterManager.Presenters;          //add
using INTEC.Med.MasterManager.ViewsAbstraction;    //add
using log4net;                                          //add
using System;
using System.Windows.Forms;

namespace INTEC.Med.MasterManager
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ILog log = LogFetcher.GetLogger();
            log.Info("===== Program Start");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainMDIView mainMDIView = new MainMDIForm();
            MainMDIPresenter mainMDIPresenter = new MainMDIPresenter(mainMDIView);
            log.Info("===== Program.CSよりMDI子フォームを起動");
            mainMDIView.ShowMDIChildForm();
            log.Info("===== Program.CSよりMDI親フォームを起動");
            mainMDIView.ShowView();

            log.Info("===== Program End");
        }
    }
}