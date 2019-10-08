using System.Collections.Generic;
namespace INTEC.Med.MasterManager.ViewsAbstraction
{
    public interface IMDBSelectorView : IBaseView
    {
        string FormTitle { get; set; }

        string DefaultOpenPath { get; set; }

        event GetLastOpenPathHandler _getLastOpenPath;

        event SetLastOpenPathHandler _setLastOpenPath;

        event IsContainsMDBHandler _isContaninsMDB;
    }

    public delegate string GetLastOpenPathHandler();

    public delegate void SetLastOpenPathHandler(string arg);

    public delegate bool IsContainsMDBHandler(string arg);
}