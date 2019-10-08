using INTEC.Med.CommonLibrary;                           //add
using INTEC.Med.MasterManager.ViewsAbstraction;     //add
using log4net;                                           //add(ログ取得用）
using MaterialSkin;                                      //add(マテリアルスキン)
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;	                     //add(dockpanel)

namespace INTEC.Med.MasterManager
{
    public partial class MainMDIForm : MaterialSkin.Controls.MaterialForm, IMainMDIView
    {
        #region _member変数

        private ILog _log = LogFetcher.GetLogger();

        public event ShowTableViewHandler _showTableView;

        public event ShowHospViewHandler _showHospView;

        public event SaveWindowSizeHandler _saveWindowSize;

        #endregion _member変数

        #region プロパティ（インタフェース用）

        public string FormTitle {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int WindowTop {
            get { return this.Top; }
            set { this.Top = value; }
        }

        public int WindowLeft {
            get { return this.Left; }
            set { this.Left = value; }
        }

        public int WindowHeight {
            get { return this.Height; }
            set { this.Height = value; }
        }

        public int WindowWidth {
            get { return this.Width; }
            set { this.Width = value; }
        }

        public double DockSizeHeight {
            get { return uxMainDockPanel.DockTopPortion; }
            set { uxMainDockPanel.DockTopPortion = value; }
        }

        public double DockSizeWidth {
            get { return uxMainDockPanel.DockLeftPortion; }
            set { uxMainDockPanel.DockLeftPortion = value; }
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

        public void ShowView()
        {
            _log.Info(this.Text + " 表示");
            this.ShowDialog();
        }

        public void HandleError(Exception ex)
        {
            _log.Info("エラーメッセージ表示");
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion イベントPRESENTER⇒VIEW
    }
}