using INTEC.Med.MasterManager.Core.ViewsAbstraction;
using INTEC.Med.MasterManager.Data;

namespace INTEC.Med.MasterManager.Core.Presenters
{
    public class MDBSelectorPresenter
    {
        #region メンバ変数

        private readonly IMDBSelectorView _MDBSelectorView;

        #endregion メンバ変数

        public MDBSelectorPresenter(IMDBSelectorView MDBSelectorView)
        {
            _MDBSelectorView = MDBSelectorView;

            _MDBSelectorView.FormTitle = CommonConstant.Forms.mdbSelectorTitleConst;
            _MDBSelectorView.DefaultOpenPath = CommonConstant.Commons.defaultOpenPathConst;
        }
    }
}