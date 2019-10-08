namespace INTEC.Med.MasterManager.ViewsAbstraction
{
    public interface ITableCollectionView : IBaseView
    {
        string TabTitle { get; set; }
        string TableFilterText { get; set; }
    }
}