using INTEC.Med.MasterManager.ViewsAbstraction;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace INTEC.Med.MasterManager.Presenters
{
    public class MDBSelectorPresenter
    {
        #region メンバ変数

        private readonly IMDBSelectorView _MDBSelectorView;

        #endregion メンバ変数

        public MDBSelectorPresenter(IMDBSelectorView MDBSelectorView)
        {
            _MDBSelectorView = MDBSelectorView;
            _MDBSelectorView._getLastOpenPath += GetLastOpenPath;
            _MDBSelectorView._setLastOpenPath += SetLastOpenPath;
            _MDBSelectorView._isContaninsMDB += IsContainsMDB;

            _MDBSelectorView.FormTitle = CommonConstant.Forms.mdbSelectorTitleConst;
            _MDBSelectorView.DefaultOpenPath = CommonConstant.Commons.defaultOpenPathConst;
        }

        #region Viewから受け取ったイベント

        private string GetLastOpenPath()
        {
            return SettingReader.LastOpenPath;
        }

        private void SetLastOpenPath(string arg)
        {
            SettingReader.LastOpenPath = arg;
        }

        /// <summary>
        /// 対象のフォルダにＭＤＢが含まれているかチェックする
        /// </summary>
        /// <param name="arg">引数のパス</param>
        /// <returns></returns>
        /*
        private List<string> IsContainsMDB(string arg)
        {
            var tmp = Directory.EnumerateFiles(arg, CommonConstant.Commons.filterExtensionConst).ToList();

            if (tmp.Count!=0)
            {
                return tmp;
            }
            else
            {
                _MDBSelectorView.HandleError(new System.Exception(CommonConstant.Messages.noMDBFoundConst));
                return tmp;
            }
        }
        */

        private bool IsContainsMDB(string arg)
        {
            var tmp = Directory.EnumerateFiles(arg, CommonConstant.Commons.filterExtensionConst).Any();
        }

        #endregion Viewから受け取ったイベント
    }
}