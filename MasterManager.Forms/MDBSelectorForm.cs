using INTEC.Med.CommonLibrary;                           //add
using INTEC.Med.MasterManager.ViewsAbstraction;     //add
using log4net;                                           //add
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INTEC.Med.MasterManager
{
    public partial class MDBSelectorForm : MaterialSkin.Controls.MaterialForm, IMDBSelectorView
    {
        #region _member変数

        private ILog _log = LogFetcher.GetLogger();
        private string _defaultOpenPath;

        public event GetLastOpenPathHandler _getLastOpenPath;

        public event SetLastOpenPathHandler _setLastOpenPath;

        public event IsContainsMDBHandler _isContaninsMDB;

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

        #endregion プロパティ（インタフェース用）

        public MDBSelectorForm()
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

        private void UxSelectMDBFolderCommand_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                //_getLastOpenPathはMasterManagerのSettingIni
                //_defaultOpenPathはMasterManagerのCommonConstant
                dialog.InitialDirectory = string.IsNullOrEmpty(_getLastOpenPath()) ? _defaultOpenPath : _getLastOpenPath();

                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    /*
                    //MDB含んでるフォルダならスプレッドを返す
                    List<string> mdbFileList = _isContaninsMDB(dialog.FileName);
                    */


                    if (_isContaninsMDB(dialog.FileName))
                    {
                        //todo:スプレッドに表示
                        /*
                        uxSelectedMDBFolderItemsDataListView.BeginUpdate();
                        uxSelectedMDBFolderItemsDataListView.DataSource = mdbFileList;
                        uxSelectedMDBFolderItemsDataListView.EndUpdate();
                        */

                    }
                    _setLastOpenPath(dialog.FileName);
                }
            }
        }
    }
}
