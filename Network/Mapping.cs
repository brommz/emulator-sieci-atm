using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /*
     * Tablica mapowania komórek ATM
     */

    public class MappingTable
    {
        /* tablica routingu */
        private Dictionary<HalfEntryMapping, HalfEntryMapping> Table;
        private Dictionary<int, HalfEntryMapping> Map; // żeby móc znaleźć wpis w tablicy po numerze w tablicy
        private int currentID = 0; // potrzebne do mapy

        /* Zwraca wpis z tablicy */
        public HalfEntryMapping this[HalfEntryMapping entry] { get { return Table[entry]; } }
        public HalfEntryMapping this[int id] { get { return Map[id]; } }

        public MappingTable()
        {
            Table = new Dictionary<HalfEntryMapping, HalfEntryMapping>(new HalfEntryMapping.EntryComparerMapping());
            Map = new Dictionary<int, HalfEntryMapping>();
        }

        /* Dodanie nowego wpisu */
        public void Add(HalfEntryMapping start, HalfEntryMapping end)
        {
            Table.Add(start, end);
            if (currentID >= 0) Map.Add(currentID, start);
            currentID++;
        }

        /* Usunięcie wpisu na podstawie jego ID */
        public bool DeleteEntry(int entryID)
        {
            if (Map.ContainsKey(entryID)) Table.Remove(Map[entryID]);
            return Map.Remove(entryID);
        }

        /* Modyfikacja wpisu na podstawie jego ID */
        public void Update(int entryID, EntryMapping entry)
        {
            if (Map.ContainsKey(entryID))
            {
                Table.Remove(Map[entryID]);
                Map.Remove(entryID);
                Table.Add(entry.start, entry.end);
                Map.Add(entryID, entry.start);
            } 
        }

        /* Zwraca następny wpis */
        public IEnumerable<EntryMapping> GetNextEntry()
        {
            foreach (KeyValuePair<HalfEntryMapping,HalfEntryMapping> entry in Table)
            {
                EntryMapping tempEntry = new EntryMapping();
                tempEntry.start = entry.Key;
                tempEntry.end = entry.Value;
                yield return tempEntry;
            }
        }

        public bool ContainsKey(HalfEntryMapping e)
        {
            return Table.ContainsKey(e);
        }

        public bool ContainsValue(HalfEntryMapping e)
        {
            return Table.ContainsValue(e);
        }

        public Dictionary<HalfEntryMapping, HalfEntryMapping>.Enumerator GetEnumerator()
        {
            return Table.GetEnumerator();
        }
    }

    /*
    * Połowa wpisu w tablicy, dwa wpisy w wierszu tablicy to mapowanie 
    */
    public class HalfEntryMapping : System.IEquatable<HalfEntryMapping>
    {
        private int port;
        public int Port { get { return port; } set { port = value; } }

        private int vpi;
        public int VPI { get { return vpi; } set { vpi = value; } }

        private int vci; // gdy VCI < 0 == VCI jest dowolne
        public int VCI { get { return vci; } set { vci = value; } }

        public HalfEntryMapping(int port, int vpi, int vci)
        {
            this.port = port; this.vpi = vpi; this.vci = vci;
        }

        public HalfEntryMapping(int port, int vpi) // gdy VCI jest dowolne
        {
            this.port = port; this.vpi = vpi; this.vci = -1;
        }

        public HalfEntryMapping(HalfEntryMapping entry)
        {
            this.port = entry.Port;
            this.vpi = entry.VPI;
            this.vci = entry.VCI;
        }

        public static IEqualityComparer<HalfEntryMapping> Default // def porównywacza
        { get { return (IEqualityComparer<HalfEntryMapping>)(new EntryComparerMapping()); } }

        /* Porównanie dwóch wierszy */
        public bool Equals(HalfEntryMapping entry)
        {
            if (this.VCI < 0 || entry.VCI < 0) // nie patrz na VCI
            {
                if (this.Port == entry.Port && this.VPI == entry.VPI) return true;
                else return false;
            }
            else if (this.Port == entry.Port && this.VPI == entry.VPI && this.VCI == entry.VCI) return true;
            else return false;
        }

        /* Klasa odpowiedzialna za porównywanie*/
        public class EntryComparerMapping : IEqualityComparer<HalfEntryMapping> //potrzebne do określenia jak porównywać
        {
            /* Zawarta jest tutaj logika tego jak ma być porównywane */
            public bool Equals(HalfEntryMapping entry1, HalfEntryMapping entry2)
            {
                if (entry1.VCI < 0 || entry2.VCI < 0) // nie patrz na VCI
                {
                    if (entry1.Port == entry2.Port && entry1.VPI == entry2.VPI) return true;
                    else return false;
                }
                else if (entry1.Port == entry2.Port && entry1.VPI == entry2.VPI && entry1.VCI == entry2.VCI) return true;
                else return false;
            }

            /* Liczenie hashCode */
            public int GetHashCode(HalfEntryMapping entry)
            {
                return entry.Port ^ entry.VPI; // znalezione na stackoverflow
            }
        }
    }

    /* Pomocnicza struktura, żeby móc odczytywać cały wpis lub modyfikować */
    public struct EntryMapping
    {
        public HalfEntryMapping start;
        public HalfEntryMapping end;
    }
}
