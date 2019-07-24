using log4net;           //add
using System.Reflection;

namespace INTEC.Med.CommonLibrary
{
    /// <summary>
    /// ログ取得用のロガー提供クラス
    /// private ILog log = LogFetcher.GetLogger();<br></br>
    ///
    ///logger.Debug("開発中のデバッグ／トレースに使用する");
    ///logger.Info("情報（操作履歴等）");
    ///logger.Warn("注意／警告（障害の一歩手前）");
    ///logger.Error("システムが停止するまではいかない障害が発生");
    ///logger.Fatal("システムが停止する致命的な障害が発生");
    /// </summary>
    public class LogFetcher
    {
        #region _member変数

        private static ILog _logger = null;

        #endregion _member変数

        public static ILog GetLogger()
        {
            if (_logger == null)
            {
                _logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().FullName);
            }
            return _logger;
        }
    }
}