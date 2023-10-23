using System.IO;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Example
{
	public class XmlInOut<T>
	{
        public static T LoadFromStream(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			return (T)serializer.Deserialize(stream);
		}

        public static void SaveToStream(Stream stream, T data)
		{
			var serializer = new XmlSerializer(typeof(T));
			serializer.Serialize(stream, data);
		}
    }
}
