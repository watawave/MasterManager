using System.Collections.Generic;

namespace MasterManager.Data.Models
{
    /// <summary>
    /// 各病院のMDBフォルダ配下のMDBリストを格納するクラス
    /// このクラスをそのままXMLにシリアライズする仕様
    /// キーはpath
    /// </summary>
    [System.Xml.Serialization.XmlRoot("HospInfo")]
    public class HospMDB
    {
        [System.Xml.Serialization.XmlAttribute("Path")]
        public string FolderPath { get; set; }

        public string Title { get; set; }

        [System.Xml.Serialization.XmlArray("MDBInfo")]
        [System.Xml.Serialization.XmlArrayItem("MDB")]
        public List<HospTable> TableCollection { get; set; }
    }
}