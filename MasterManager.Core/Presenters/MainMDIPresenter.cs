using INTEC.Med.MasterManager.Core.ViewsAbstraction;
using INTEC.Med.MasterManager.Data;
using INTEC.Med.CommonLibrary;
using System.Reflection;

using log4net;

namespace INTEC.Med.MasterManager.Core.Presenters
{
    public class MainMDIPresenter
    {
        #region メンバ変数

        private ILog _log = LogFetcher.GetLogger();

        private readonly IMainMDIView _mainMDIView;

        #endregion メンバ変数

        public MainMDIPresenter(IMainMDIView mainMDIView)
        {
            _mainMDIView = mainMDIView;
            _mainMDIView._showHospView += ShowHospView;
            _mainMDIView._showTableView += ShowTableView;
            _mainMDIView._saveWindowSize += SaveWindowSize;


            //フォーム情報の定義
            _log.Info("ウィンドウサイズ情報を定義");
            Assembly mainAssembly = Assembly.GetEntryAssembly();
            _mainMDIView.FormTitle = CommonConstant.Forms.mainMDITitleConst + " - " + mainAssembly.GetName().Version;
            _mainMDIView.WindowTop = SettingReader.WindowTop;
            _mainMDIView.WindowLeft = SettingReader.WindowLeft;
            _mainMDIView.WindowWidth = SettingReader.WindowWidth;
            _mainMDIView.WindowHeight = SettingReader.WindowHeight;
            _mainMDIView.DockSizeHeight = SettingReader.DockSizeHeight;
            _mainMDIView.DockSizeWidth = SettingReader.DockSizeWidth;
        }

        #region Viewから受け取った処理

        /// <summary>
        /// 子プレゼンターに子フォームのインスタンスを持たせる
        /// ※子フォームのインスタンスは親フォームで作る
        /// </summary>
        /// <param name="hospCollectionView"></param>
        private void ShowHospView(IHospCollectionView hospCollectionView)
        {
            _log.Info("hospCollectionフォーム作成");
            var hospCollectionPresenter = new HospCollectionPresenter(hospCollectionView);
        }

        /// <summary>
        /// 子プレゼンターに子フォームのインスタンスを持たせる
        /// ※子フォームのインスタンスは親フォームで作る
        /// </summary>
        /// <param name="tableCollectionView"></param>
        private void ShowTableView(ITableCollectionView tableCollectionView)
        {
            _log.Info("tableCollectionフォーム作成");
            var tableCollectionPresenter = new TableCollectionPresenter(tableCollectionView);
        }

        /// <summary>
        /// 子プレゼンターに子フォームのインスタンスを持たせる
        /// ※子フォームのインスタンスは親フォームで作る
        /// </summary>
        /// <param name="tableCollectionView"></param>
        private void ShowMDBSelectorView(IMDBSelectorView MDBSelectorView)
        {
            _log.Info("MDBSelectorフォーム作成");
            var MDBSelectorPresenter = new MDBSelectorPresenter(MDBSelectorView);
        }

        /// <summary>
        /// フォームクローズ時にウィンドウサイズを保存する
        /// </summary>
        private void SaveWindowSize()
        {
            //TODO:ログのはきかたが下手
            _log.Info("Windowフォームのポジションを保存");

            SettingReader.WindowTop= _mainMDIView.WindowTop;
            SettingReader.WindowLeft= _mainMDIView.WindowLeft;
            SettingReader.WindowWidth= _mainMDIView.WindowWidth;
            SettingReader.WindowHeight= _mainMDIView.WindowHeight;
            SettingReader.DockSizeHeight= _mainMDIView.DockSizeHeight;
            SettingReader.DockSizeWidth= _mainMDIView.DockSizeWidth;
        }
        #endregion Viewから受け取った処理
    }
}