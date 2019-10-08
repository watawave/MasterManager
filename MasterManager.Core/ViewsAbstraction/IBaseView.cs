using System;

namespace INTEC.Med.MasterManager.ViewsAbstraction
{
    public interface IBaseView
    {
        void ShowView();                    //Form表示用メソッド

        void HandleError(Exception ex);     //エラー処理用メソッド
    }
}