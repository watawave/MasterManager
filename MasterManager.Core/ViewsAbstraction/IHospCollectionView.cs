namespace INTEC.Med.MasterManager.Core.ViewsAbstraction
{
    public interface IHospCollectionView : IBaseView
    {
        string TabTitle { get; set; }

        event ShowMDBSelectorViewHandler _showMDBSelectorView;
    }

    public delegate void ShowMDBSelectorViewHandler(IMDBSelectorView m);
}