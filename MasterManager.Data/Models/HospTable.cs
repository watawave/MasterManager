using System.Collections.Generic;

namespace MasterManager.Data.Models
{
    /// <summary>
    /// 各MDBのテーブル名を格納するクラス
    /// このクラスもXMLシリアライズ対象
    /// </summary>
    public class HospTable
    {
        [System.Xml.Serialization.XmlAttribute("fileName")]
        public string MDBName { get; set; }

        [System.Xml.Serialization.XmlArray("tableInfo")]
        [System.Xml.Serialization.XmlArrayItem("tableName")]
        public List<string> TableCollection { get; set; }

        [System.Xml.Serialization.XmlArray("descriptionInfo")]
        [System.Xml.Serialization.XmlArrayItem("explain")]
        public List<string> DescriptionCollection { get; set; }
    }
}