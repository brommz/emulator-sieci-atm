using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /* Tablica forwardingu chmury */
    public class ForwardingTable
    {
        private Dictionary<HalfEntryForwarding, HalfEntryForwarding> fTable; // Tabela
        private Dictionary<int, HalfEntryForwarding> fMap; // Mapa, służy do odnajdowania wpisu z fTable

        /* Zwraca wpis z tablicy */
        public HalfEntryForwarding this[HalfEntryForwarding entry] { get { return fTable[entry]; } }
        public HalfEntryForwarding this[int id] { get { return fMap[id]; } }

        public ForwardingTable()
        {
            fTable = new Dictionary<HalfEntryForwarding, HalfEntryForwarding>(new HalfEntryForwarding.EntryComparerForwarding());
            fMap = new Dictionary<int, HalfEntryForwarding>();
        }

        /* Dodanie nowego wpisu */
        public void Add(HalfEntryForwarding start, HalfEntryForwarding end, int id)
        {
            fTable.Add(start, end);
            if (id >= 0) fMap.Add(id, start);
        }

        /* Usunięcie wpisu z tablicy */
        public bool Remove(HalfEntryForwarding e)
        {
            if (fMap.ContainsValue(e)) return false;
            else return fTable.Remove(e);
        }

        public bool Remove(int id)
        {
            if (fMap.ContainsKey(id)) fTable.Remove(fMap[id]);
            return fMap.Remove(id);
        }

        /* Zwraca następny wpis */
        public IEnumerable<EntryForwarding> GetNextEntry()
        {
            foreach (KeyValuePair<HalfEntryForwarding, HalfEntryForwarding> entry in fTable)
            {
                EntryForwarding tempEntry = new EntryForwarding();
                tempEntry.start = entry.Key;
                tempEntry.end = entry.Value;
                yield return tempEntry;
            }
        }

        public bool ContainsKey(HalfEntryForwarding e)
        {
            return fTable.ContainsKey(e);
        }

        public bool ContainsValue(HalfEntryForwarding e)
        {
            return fTable.ContainsValue(e);
        }

        public Dictionary<HalfEntryForwarding, HalfEntryForwarding>.Enumerator GetEnumerator()
        {
            return fTable.GetEnumerator();
        }
    }


    /*
    * Wpis w tablicy, dwa wpisy w wierszu tablicy to mapowanie 
    */
    public class HalfEntryForwarding : System.IEquatable<HalfEntryForwarding>
    {
        private int id;
        public int ID { get { return id; } set { id = value; } }

        private int port;
        public int Port { get { return port; } set { port = value; } }

        public HalfEntryForwarding(int id, int port)
        {
            this.id = id; this.port = port;
        }

        public HalfEntryForwarding(HalfEntryForwarding entry)
        {
            this.id = entry.ID;
            this.port = entry.Port;
        }

        public static IEqualityComparer<HalfEntryForwarding> Default // def porównywacza
        { get { return (IEqualityComparer<HalfEntryForwarding>)(new EntryComparerForwarding()); } }

        /* Porównanie dwóch wpisów HalfEntry */
        public bool Equals(HalfEntryForwarding entry)
        {
            if (this.ID == entry.ID && this.Port == entry.Port) return true;
            else return false;
        }

        /* Klasa odpowiedzialna za porównywanie*/
        public class EntryComparerForwarding : IEqualityComparer<HalfEntryForwarding> //potrzebne do określenia jak porównywać
        {
            /* Zawarta jest tutaj logika tego jak ma być porównywane */
            public bool Equals(HalfEntryForwarding entry1, HalfEntryForwarding entry2)
            {
                if (entry1.ID == entry2.ID && entry1.Port == entry2.Port) return true;
                else return false;
            }

            /* Liczenie hashCode */
            public int GetHashCode(HalfEntryForwarding entry)
            {
                return entry.ID ^ entry.port; // znalezione na stackoverflow
            }
        }
    }

    public struct EntryForwarding
    {
        public HalfEntryForwarding start;
        public HalfEntryForwarding end;
    }
}
