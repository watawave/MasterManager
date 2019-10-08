using INTEC.Med.CommonLibrary;                         //add
using INTEC.Med.MasterManager.ViewsAbstraction;   //add
using log4net;                                         //add(ログ取得用）
using System;
using System.Windows.Forms;

namespace INTEC.Med.MasterManager
{
    public partial class TableCollectionForm : WeifenLuo.WinFormsUI.Docking.DockContent, ITableCollectionView
    {
        #region _member変数

        private ILog _log = LogFetcher.GetLogger();

        #endregion _member変数

        #region プロパティ（インタフェース用）

        public string TabTitle {
            get { return this.TabText; }
            set { this.TabText = value; }
        }

        public string TableFilterText {
            get { return uxTableFilterText.Text; }
            set { uxTableFilterText.Text = value; }
        }

        #endregion プロパティ（インタフェース用）

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TableCollectionForm()
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

        /// <summary>
        /// クリアボタンをクリックでテキストをクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFilterClearCommand_Click(object sender, EventArgs e)
        {
            uxTableFilterText.Clear();
        }
    }
}