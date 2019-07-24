﻿namespace INTEC.Med.MasterManager.Core.ViewsAbstraction
{
    public interface IMainMDIView : IBaseView
    {
        string FormTitle { get; set; }

        int WindowTop { get; set; }
        int WindowLeft { get; set; }
        int WindowHeight { get; set; }
        int WindowWidth { get; set; }
        double DockSizeHeight { get; set; }
        double DockSizeWidth { get; set; }


        event ShowTableViewHandler _showTableView;

        event ShowHospViewHandler _showHospView;

        event SaveWindowSizeHandler _saveWindowSize;
        //event ShowMDBSelectorViewHandler _showMDBSelectorView;

        void ShowMDIChildForm();

        //void ShowMDBSelectorForm();
    }

    public delegate void ShowTableViewHandler(ITableCollectionView t);

    public delegate void ShowHospViewHandler(IHospCollectionView h);

    public delegate void SaveWindowSizeHandler();

    //public delegate void ShowMDBSelectorViewHandler(IMDBSelectorView m);
}