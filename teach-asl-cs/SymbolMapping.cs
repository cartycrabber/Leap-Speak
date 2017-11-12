using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachAslCsharp
{
    class SymbolMapping
    {
        // TODO: add thread safety

        private static SymbolMapping instance = null;

        private Dictionary<int, string> mapping = new Dictionary<int, string>();

        private SymbolMapping()
        {
            int id = 0;
            for (char letter = 'A'; letter <= 'Z'; ++letter)
            {
                AddMapping(id, letter.ToString());
                ++id;
            }

            AddMapping(id++, "Hello");
            AddMapping(id++, "Yes");
            AddMapping(id++, "No");
        }

        public IEnumerable<string> AllSymbols()
        {
            return mapping.Values;
        }

        public void AddMapping(int id, string name)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            mapping.Add(id, name);
        }

        public string GetId(int id)
        {
            return mapping[id];
        }

        public int GetName(string name)
        {
            var pair = mapping.FirstOrDefault(p => p.Value == name);
            if (Object.ReferenceEquals(pair, null))
            {
                return -1;
            }
            return pair.Key;
        }

        public static SymbolMapping GetInstance()
        {
            if (Object.ReferenceEquals(instance, null))
            {
                instance = new SymbolMapping();
            }
            return instance;
        }
    }
}
