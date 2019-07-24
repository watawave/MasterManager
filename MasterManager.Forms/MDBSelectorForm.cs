using INTEC.Med.CommonLibrary;                           //add
using INTEC.Med.MasterManager.Core.ViewsAbstraction;     //add
using log4net;                                           //add
using MaterialSkin;                                      //add(マテリアルスキン)
using System.Windows.Forms;
using System;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace INTEC.Med.MasterManager.Forms
{
    public partial class MDBSelectorForm : MaterialSkin.Controls.MaterialForm, IMDBSelectorView
    {
        #region _member変数

        private ILog _log = LogFetcher.GetLogger();
        private string _defaultOpenPath;
        private string _lastOpenPath;

        #endregion _member変数

        #region プロパティ（インタフェース用）

        public string FormTitle {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string DefaultOpenPath {
            get { return _defaultOpenPath; }
            set { _defaultOpenPath = value; }
        }

        public string LastOpenPath {
            get { return _lastOpenPath; }
            set { _lastOpenPath = value; }
        }

        #endregion プロパティ（インタフェース用）

        public MDBSelectorForm()
        {
            _log.Info(this.Text + " Initialize");
            InitializeComponent();
        }

        #region イベントPRESENTER⇒VIEW

        /// <summary>
        /// フォーム表示
        /// </summary>
        public void ShowView()
        {
            _log.Info(this.Text + " 表示");
            this.ShowDialog();
        }

        /// <summary>e
        /// エラーメッセージ表示
        /// </summary>
        /// <param name="ex"></param>
        public void HandleError(Exception ex)
        {
            _log.Error(ex.Message);
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion イベントPRESENTER⇒VIEW

        private void uxSelectFolderCommand_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.InitialDirectory = _lastOpenPath;
                if (string.IsNullOrEmpty(_lastOpenPath))
                {
                    dialog.InitialDirectory = _defaultOpenPath;
                }
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    //TODO:サンプルを見ながらMDB登録フォームを出して、名前つけて登録できるようにする。なので、MDBリスト作ったりXMLシリアライズ化するのはそいつからキック（汎用性に注意！

                    //TODO: MODELに移管
                    //Properties.Settings.Default.LastOpenPath = dialog.FileName;
                    //Properties.Settings.Default.Save();
                }
            }
        }
    }
}