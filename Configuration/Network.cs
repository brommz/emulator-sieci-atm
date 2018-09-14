using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Configuration
{
    /*
     Konfiguracja sieci - połączenia węzłów
     */
    [Serializable]
    public class Network
    {
        private NetworkInfo info = new NetworkInfo(); // informacje potrzebne do podłączenia zarządcy, chmury
        [XmlElement("Info")]
        public NetworkInfo Info { get { return info; } set { info = value; } }

        private List<Link> links = new List<Link>(); // łącza w sieci
        [XmlArray("Links"), XmlArrayItem(typeof(Link), ElementName = "Link")]
        public List<Link> Links { get { return links; } set { links = value; } }

        public void serialize(string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Network));
                using (TextWriter writer = new StreamWriter(filename))
                {
                    serializer.Serialize(writer, this);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return;
            }

        }

        public static Network deserialize(string filename)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Network));
                TextReader reader = new StreamReader(filename);
                object obj = deserializer.Deserialize(reader);
                Network ne = (Network)obj;
                reader.Close();

                StaticInfo.cloudHost = ne.info.CloudHost;
                StaticInfo.cloudPort1 = ne.info.CloudPort1;
                StaticInfo.cloudPort2 = ne.info.CloudPort2;
                StaticInfo.managerHost = ne.info.ManagerHost;
                StaticInfo.managerPort1 = ne.info.ManagerPort1;
                return ne;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }
        }
    }

    public class Link
    {
        private int capacity = 10; // przepustowość łącza
        [XmlAttribute("Capacity")]
        public int Name { get { return capacity; } set { capacity = value; } }

        private string type = ""; // typ łącza: Client, Transport
        [XmlAttribute("Type")]
        public string Type { get { return type; } set { type = value; } }

        private Source source;
        [XmlElement("Source")]
        public Source Source { get { return source; } set { source = value; } }

        private Destination destination;
        [XmlElement("Destination")]
        public Destination Destination { get { return destination; } set { destination = value; } }

    }

    public class NetworkInfo
    {
        private int cloudPort1; // port do chmury kablowej
        [XmlAttribute("CloudPort1")]
        public int CloudPort1 { get { return cloudPort1; } set { cloudPort1 = value; } }

        private int cloudPort2; // port do chmury kablowej
        [XmlAttribute("CloudPort2")]
        public int CloudPort2 { get { return cloudPort2; } set { cloudPort2 = value; } }

        private string cloudHost; // adres chmury
        [XmlAttribute("CloudHost")]
        public string CloudHost { get { return cloudHost; } set { cloudHost = value; } }

        private string managerHost; // adres zarządcy
        [XmlAttribute("ManagerHost")]
        public string ManagerHost { get { return managerHost; } set { managerHost = value; } }

        private int managerPort1; // port do zarządcy
        [XmlAttribute("ManagerPort1")]
        public int ManagerPort1 { get { return managerPort1; } set { managerPort1 = value; } }

        private string name; // nazwa sieci
        [XmlAttribute("Name")]
        public string Name { get { return name; } set { name = value; } }
    }

    public class Source
    {
        private int id;
        [XmlAttribute("ElementId")]
        public int Id { get { return id; } set { id = value; } }

        private int portId;
        [XmlAttribute("PortId")]
        public int PortId { get { return portId; } set { portId = value; } }
    }


    public class Destination
    {
        private int id;
        [XmlAttribute("ElementId")]
        public int Id { get { return id; } set { id = value; } }

        private int portId;
        [XmlAttribute("PortId")]
        public int PortId { get { return portId; } set { portId = value; } }
    }

    public static class StaticInfo
    {
        public static string managerHost;
        public static string cloudHost;
        public static int managerPort1;
        public static int cloudPort1;
        public static int cloudPort2;
        public const int CBUFFER = 1024; // rozmiar bufora danych odbieranych z Socketa
        public const int MAXNODES = 100; // max liczba węzłów podłączonych
    }

}
