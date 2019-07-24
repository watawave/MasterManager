using INTEC.Med.CommonLibrary;
using INTEC.Med.MasterManager.Core.ViewsAbstraction;
using INTEC.Med.MasterManager.Data;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace INTEC.Med.MasterManager.Core.Presenters
{
    public class HospCollectionPresenter
    {
        #region _member変数

        private ILog _log = LogFetcher.GetLogger();
        private readonly IHospCollectionView _HospCollectionView;

        #endregion _member変数

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="HospCollectionView"></param>
        public HospCollectionPresenter(IHospCollectionView HospCollectionView)
        {
            _HospCollectionView = HospCollectionView;
            _HospCollectionView._showMDBSelectorView += ShowMDBSelectorView;

            //各値を定数クラスから持ってくる
            _HospCollectionView.TabTitle = CommonConstant.Forms.hospCollectionTabTilteConst;
        }

        #region Viewから受け取った処理

        /// <summary>
        /// 選択したフォルダ内のMDBを一覧化してXMLシリアライズ
        /// </summary>
        /// <param name="arg"></param>
        private void _FetchHospInfo(string selectedPath)
        {
            //フォルダ内にあるMDBをLISTで取得する
            List<string> MDBSelector = GetMDBSelector(selectedPath);
        }

        /// <summary>
        /// 子プレゼンターに子フォームのインスタンスを持たせる
        /// ※子フォームのインスタンスは親フォームで作る
        /// </summary>
        /// <param name="MDBSelectorView"></param>
        private void ShowMDBSelectorView(IMDBSelectorView MDBSelectorView)
        {
            var MDBSelectorPresenter = new MDBSelectorPresenter(MDBSelectorView);
            MDBSelectorView.ShowView();
        }

        #endregion Viewから受け取った処理

        /// <summary>
        /// 指定フォルダ内のMDBファイル一覧を取得する
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<string> GetMDBSelector(string path)
        {
            _log.Info(path + "配下のMDB一覧を取得します。");
            List<string> MDBSelector = Directory.GetFiles(path)
                        .Where(x => Path.GetExtension(x) == CommonConstant.Commons.filterExtensionConst)
                        .Select(x => Path.GetFileName(x)).ToList();

            //MDBファイルが見つからなければエラーとする
            if (MDBSelector.Count() == 0)
            {
                System.ArgumentException ex = new ArgumentException(CommonConstant.Messages.noMDBFoundConst, path);
                _HospCollectionView.HandleError(ex);
                _log.Info(path + ex.Message);
                return null;
            }

            return MDBSelector;
        }
    }
}