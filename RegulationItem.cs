using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace Example
{
    [Serializable, XmlRoot("Regulation")] public class RegulationItem
    {
        #region Constructors
        public RegulationItem()
        {
            LoadCards = new ObservableCollection<LoadCard>();
        }
        #endregion

        #region Properties
        [XmlAttribute("Name")] public string Name { get; set; }
        [XmlArray("LoadCards")] public ObservableCollection<LoadCard> LoadCards { get; set; }
        #endregion
    }
    [Serializable, XmlRoot("LoadCard")] public class LoadCard
    {
        #region Constructors
        public LoadCard()
        {
            Dictionary = new SerializableDictionary<string, byte>();
        }
        #endregion

        #region Properties
        [XmlElement] public SerializableDictionary<string, byte> Dictionary { get; set; }
        #endregion
    }
}
