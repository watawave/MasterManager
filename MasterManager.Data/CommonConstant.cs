namespace INTEC.Med.MasterManager
{
    public static class CommonConstant
    {
        /// <summary>
        /// フォーム情報の定数クラス
        /// </summary>
        public static class Forms
        {
            //メインウィンドウのフォームタイトル
            public static readonly string mainMDITitleConst = "        MasterManager";

            //フォルダ一覧フォームのタイトル
            public static readonly string hospCollectionTabTilteConst = "フォルダ一覧";

            //テーブル一覧フォームのタイトル
            public static readonly string tableCollectionTabTitleConst = "テーブル一覧";

            //フォルダ選択画面のフォームタイトル
            public static readonly string mdbSelectorTitleConst = "フォルダ選択";
        }

        /// <summary>
        /// メッセージ内容の定数
        /// </summary>
        public static class Messages
        {
            public static readonly string noMDBFoundConst = "指定したフォルダにMDBファイルが見つかりませんでした。";
        }

        /// <summary>
        /// その他の定数
        /// fixme:できるだけCommon定数から細分化したい
        /// </summary>
        public static class Commons
        {
            //フォルダを開くときの初期フォルダ
            public static readonly string defaultOpenPathConst = @"C:\egmain-ex\Data\mdb";

            //フォルダを開くときの絞り込み拡張子
            public static readonly string filterExtensionConst = "*.mdb";
        }
    }
}