using INTEC.Med.CommonLibrary;                           //add
using INTEC.Med.MasterManager.Core.ViewsAbstraction;     //add
using log4net;                                           //add(ログ取得用）
using MaterialSkin;                                      //add(マテリアルスキン)
using WeifenLuo.WinFormsUI.Docking;	                     //add(dockpanel)
using System;
using System.Reflection;
using System.Windows.Forms;

namespace INTEC.Med.MasterManager.Forms
{
    public partial class MainMDIForm : MaterialSkin.Controls.MaterialForm, IMainMDIView
    {
        #region _member変数

        private ILog _log = LogFetcher.GetLogger();

        public event ShowTableViewHandler _showTableView;

        public event ShowHospViewHandler _showHospView;

        public event SaveWindowSizeHandler _saveWindowSize;

        private int _windowTop;
        private int _windowLeft;
        private int _windowWidth;
        private int _windowHeight;
        private double _dockSizeHeight;
        private double _dockSizeWidth;


        #endregion _member変数

        #region プロパティ（インタフェース用）

        public string FormTitle {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int WindowTop {
            get { return _windowTop; }
            set { _windowTop = value; }
        }
        public int WindowLeft {
            get { return _windowLeft; }
            set { _windowLeft = value; }
        }
        public int WindowHeight {
            get { return _windowHeight; }
            set { _windowHeight = value; }
        }
        public int WindowWidth {
            get { return _windowWidth; }
            set { _windowWidth = value; }
        }
        public double DockSizeHeight {
            get { return _dockSizeHeight; }
            set { _dockSizeHeight = value; }
        }
        public double DockSizeWidth {
            get { return _dockSizeWidth; }
            set { _dockSizeWidth = value; }
        }


        #endregion プロパティ（インタフェース用）

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainMDIForm()
        {
            _log.Info(this.Text + " Initialize");
            InitializeComponent();

            //①見た目をMaterial風Skinに設定
            _log.Debug("MaterialSkin表示設定");
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            //②MDIコンテナ表示の設定
            _log.Debug("MDIコンテナ表示設定");
            this.IsMdiContainer = true;
            var theme = new VS2015LightTheme();
            theme.Measures.DockPadding = 0;
            theme.Measures.SplitterSize = 2;
            this.uxMainDockPanel.Theme = theme;
        }

        /// <summary>
        /// Program.csからキックされる。子フォームの作成処理
        /// </summary>
        public void ShowMDIChildForm()
        {
            //①MainFormが子フォームのインスタンスを持つ
            ITableCollectionView tableCollectionView = new TableCollectionForm();
            IHospCollectionView hospCollectionView = new HospCollectionForm();

            //②MainPresenterに子プレゼンターのインスタンスを持たせるべく、処理を依頼
            _showTableView?.Invoke(tableCollectionView);
            _showHospView?.Invoke(hospCollectionView);

            //③MDIフォームとして配置する
            DockContent MDIFormLeft = (DockContent)tableCollectionView;
            DockContent MDIFormTop = (DockContent)hospCollectionView;
            MDIFormLeft.Show(uxMainDockPanel, DockState.DockLeft);
            MDIFormTop.Show(uxMainDockPanel, DockState.DockTop);
        }


        private void MainMDIForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _saveWindowSize?.Invoke();
        }

        #region イベントPRESENTER⇒VIEW
        //TODO:インターフェイス経由していないのでダメ
        public void ShowView()
        {
            //TODO:ここで処理しなくてもプロパティでバインドさせて、フォームロードメソッドでやれば？
            _log.Debug("Propertyからウィンドウサイズの取得・設定");
            this.Top = _windowTop;
            this.Left = _windowLeft;
            this.Height = _windowHeight;
            this.Width = _windowWidth;
            uxMainDockPanel.DockTopPortion = _dockSizeHeight;
            uxMainDockPanel.DockLeftPortion = _dockSizeWidth;

            _log.Info(this.Text + " 表示");
            this.ShowDialog();
        }



        //TODO:インターフェイス経由していないのでダメ
        public void HandleError(Exception ex)
        {
            
            _log.Error(ex.Message);
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion イベントPRESENTER⇒VIEW
    }
}