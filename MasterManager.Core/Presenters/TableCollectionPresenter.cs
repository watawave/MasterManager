using INTEC.Med.MasterManager.Core.ViewsAbstraction;
using INTEC.Med.MasterManager.Data;

namespace INTEC.Med.MasterManager.Core.Presenters
{
    public class TableCollectionPresenter
    {
        #region メンバ変数

        private readonly ITableCollectionView _TableCollectionView;

        #endregion メンバ変数

        public TableCollectionPresenter(ITableCollectionView TableCollectionView)
        {
            _TableCollectionView = TableCollectionView;

            _TableCollectionView.TabTitle = CommonConstant.Forms.tableCollectionTabTitleConst;
        }
    }
}