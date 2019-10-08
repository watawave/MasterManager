using INTEC.Med.CommonLibrary;                           //add
using INTEC.Med.MasterManager.ViewsAbstraction;     //add
using log4net;                                           //add(ログ取得用）
using System;
using System.Windows.Forms;

namespace INTEC.Med.MasterManager
{
    public partial class HospCollectionForm : WeifenLuo.WinFormsUI.Docking.DockContent, IHospCollectionView
    {
        #region メンバ変数

        private ILog _log = LogFetcher.GetLogger();

        public event ShowMDBSelectorViewHandler _showMDBSelectorView;

        #endregion メンバ変数

        #region プロパティ（インタフェース用）

        public string TabTitle {
            get { return this.TabText; }
            set { this.TabText = value; }
        }

        #endregion プロパティ（インタフェース用）

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HospCollectionForm()
        {
            _log.Info(this.Text + " Initialize");
            InitializeComponent();
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

        #region イベントVIEW⇒PRESENTER

        /// <summary>
        /// フォルダオープンボタン押下
        /// フォルダ選択画面を作成して、Presenterに管理を移管する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenFolderCommand_Click(object sender, EventArgs e)
        {
            //フォームのインスタンスを持つ
            IMDBSelectorView MDBSelectorView = new MDBSelectorForm();
            _showMDBSelectorView?.Invoke(MDBSelectorView);
        }

        #endregion イベントVIEW⇒PRESENTER
    }
}