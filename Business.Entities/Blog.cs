using System.Runtime.Serialization;

namespace Business.Entities
{
    [DataContract]
    public class Blog : IExtensibleDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string URL { get; set; }

        [DataMember]
        public string Owner { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}
