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
     Konfiguracja węzła sieciowego
     */
    [Serializable]
    public class NetworkElement
    {
        private NetworkElementInfo info = new NetworkElementInfo(); // informacje potrzebne do węzła
        [XmlElement("Info")]
        public NetworkElementInfo Info { get { return info; } set { info = value; } }

        private List<PortInput> portsIn = new List<PortInput>(); // porty wejściowe węzła
        [XmlArray("InputPorts"), XmlArrayItem(typeof(PortInput), ElementName = "Port")]
        public List<PortInput> PortsIn { get { return portsIn; } set { portsIn = value; } }

        private List<PortOutput> portsOut = new List<PortOutput>(); // porty wejściowe węzła
        [XmlArray("OutputPorts"), XmlArrayItem(typeof(PortOutput), ElementName = "Port")]
        public List<PortOutput> PortsOut { get { return portsOut; } set { portsOut = value; } }

        private List<RoutingEntry> routingTable = new List<RoutingEntry>(); // konfiuracja tablicy routingu węzła
        [XmlArray("RoutingTable"), XmlArrayItem(typeof(RoutingEntry), ElementName = "Entry")]
        public List<RoutingEntry> RoutingTable { get { return routingTable; } set { routingTable = value; } }

        public void serialize(string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(NetworkElement));
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

        public static NetworkElement deserialize(string filename)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(NetworkElement));
                TextReader reader = new StreamReader(filename);
                object obj = deserializer.Deserialize(reader);
                NetworkElement ne = (NetworkElement)obj;
                reader.Close();
                return ne;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }
        }
    }

    public class NetworkElementInfo
    {
        private int id; // id węzła
        [XmlAttribute("Id")]
        public int ID { get { return id; } set { id = value; } }

        private string type; // typ węzła: Switch, Source, Sink
        [XmlAttribute("Type")]
        public string Type { get { return type; } set { type = value; } }

        private string name; // nazwa węzła
        [XmlAttribute("Name")]
        public string Name { get { return name; } set { name = value; } }
    }

    public class PortInput
    {
        private int id;
        [XmlAttribute("Id")]
        public int Id { get { return id; } set { id = value; } }

        private string type = ""; // typ portu: Client, Transport
        [XmlAttribute("Type")]
        public string Type { get { return type; } set { type = value; } }
    }

    /* może być jedna klasa Port dla konfiguracji -> ale może coś będzie się jeszcze różniło */
    public class PortOutput
    {
        private int id;
        [XmlAttribute("Id")]
        public int Id { get { return id; } set { id = value; } }

        private string type = ""; // typ portu: Client, Transport
        [XmlAttribute("Type")]
        public string Type { get { return type; } set { type = value; } }
    }

    /* reprezentuje wpis w tablicy routingu węzła */
    public class RoutingEntry
    {
        private int portIn;
        [XmlAttribute("PortIn")]
        public int PortIn { get { return portIn; } set { portIn = value; } }

        private int vpiIN;
        [XmlAttribute("VpiIn")]
        public int VpiIN { get { return vpiIN; } set { vpiIN = value; } }

        private int vciIN;
        [XmlAttribute("VciIn")]
        public int VciIN { get { return vciIN; } set { vciIN = value; } }

        private int portOut;
        [XmlAttribute("PortOut")]
        public int PortOut { get { return portOut; } set { portOut = value; } }

        private int vpiOUT;
        [XmlAttribute("VpiOut")]
        public int VpiOUT { get { return vpiOUT; } set { vpiOUT = value; } }

        private int vciOUT;
        [XmlAttribute("VciOut")]
        public int VciOUT { get { return vciOUT; } set { vciOUT = value; } }
    }

}
