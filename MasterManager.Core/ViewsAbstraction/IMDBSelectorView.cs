namespace INTEC.Med.MasterManager.Core.ViewsAbstraction
{
    public interface IMDBSelectorView : IBaseView
    {
        string FormTitle { get; set; }

        //List<string> MDBSelector { get; set; }
        string DefaultOpenPath { get; set; }
    }
}