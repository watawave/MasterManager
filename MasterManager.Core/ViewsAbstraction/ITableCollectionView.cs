namespace INTEC.Med.MasterManager.Core.ViewsAbstraction
{
    public interface ITableCollectionView : IBaseView
    {
        string TabTitle { get; set; }
        string TableFilterText { get; set; }
    }
}