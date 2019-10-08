using INTEC.Med.CommonLibrary;
using INTEC.Med.MasterManager.ViewsAbstraction;
using log4net;
using System.Reflection;

namespace INTEC.Med.MasterManager.Presenters
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

        #region 子プレゼンター作成処理（フォームのインスタンスを持たせつつ）

        private void ShowHospView(IHospCollectionView hospCollectionView)
        {
            _log.Info("hospCollectionフォーム作成");
            var hospCollectionPresenter = new HospCollectionPresenter(hospCollectionView);
        }

        private void ShowTableView(ITableCollectionView tableCollectionView)
        {
            _log.Info("tableCollectionフォーム作成");
            var tableCollectionPresenter = new TableCollectionPresenter(tableCollectionView);
        }

        #endregion 子プレゼンター作成処理（フォームのインスタンスを持たせつつ）

        /// <summary>
        /// フォームクローズ時にウィンドウサイズを保存する
        /// </summary>
        private void SaveWindowSize()
        {
            _log.Info("Windowフォームのポジションを保存");
            SettingReader.WindowTop = _mainMDIView.WindowTop;
            SettingReader.WindowLeft = _mainMDIView.WindowLeft;
            SettingReader.WindowWidth = _mainMDIView.WindowWidth;
            SettingReader.WindowHeight = _mainMDIView.WindowHeight;
            SettingReader.DockSizeHeight = _mainMDIView.DockSizeHeight;
            SettingReader.DockSizeWidth = _mainMDIView.DockSizeWidth;

            _log.Debug("WindowTop=" + SettingReader.WindowTop);
            _log.Debug("WindowLeft=" + SettingReader.WindowLeft);
            _log.Debug("WindowWidth=" + SettingReader.WindowWidth);
            _log.Debug("WindowHeight=" + SettingReader.WindowHeight);
            _log.Debug("DockHeight=" + SettingReader.DockSizeHeight);
            _log.Debug("DockWidth=" + SettingReader.DockSizeWidth);
        }

        #endregion Viewから受け取った処理
    }
}