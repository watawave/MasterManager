using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEC.Med.MasterManager.Data
{

    /// <summary>
    /// settings.settingの情報を読み書きする
    /// プロパティ郡クラス
    /// </summary>
    public static class SettingReader
    {
        #region     プロパティ

        
        public static int WindowTop {
            get { return Properties.Settings.Default.WindowTop; }
            set {
                Properties.Settings.Default.WindowTop = value;
                Properties.Settings.Default.Save();
            }
        }
        
        public static int WindowLeft {
            get { return Properties.Settings.Default.WindowLeft; }
            set {
                Properties.Settings.Default.WindowLeft = value;
                Properties.Settings.Default.Save();
            }
        }

        
        public static int WindowHeight {
            get { return Properties.Settings.Default.WindowHeight; }
            set {
                Properties.Settings.Default.WindowHeight = value;
                Properties.Settings.Default.Save();
            }
        }
        
        public static int WindowWidth {
            get { return Properties.Settings.Default.WindowWidth; }
            set {
                Properties.Settings.Default.WindowWidth = value;
                Properties.Settings.Default.Save();
            }
        }
        
        public static double DockSizeHeight {
            get { return Properties.Settings.Default.DockSizeHeight; }
            set {
                Properties.Settings.Default.DockSizeHeight = value;
                Properties.Settings.Default.Save();
            }
        }
       
        public static double DockSizeWidth {
            get { return Properties.Settings.Default.DockSizeWidth; }
            set {
                Properties.Settings.Default.DockSizeWidth = value;
                Properties.Settings.Default.Save();
            }
        }
        #endregion

    }
}
