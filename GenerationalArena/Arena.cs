using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GenerationalArena
{
    public class Arena<T>
    {
        private List<Entry> _items;
        private int _freeListHeadIndex;
        private uint _generation;
        private int _listLength;

        public Arena()
        {
            _listLength = 4;
            _items = new List<Entry>(_listLength);
            _freeListHeadIndex = 0;
            _generation = 0;

            for (int i = 0; i < _listLength; i++)
            {
                _items.Add(new FreeEntry(i+1));
            }
        }

        public GenerationalIndex Add(T value)
        {
            Debug.Assert(_items[_freeListHeadIndex] is FreeEntry, "The item must be a freeEntry");

            FreeEntry freeEntry = _items[_freeListHeadIndex] as FreeEntry;
            
            if (freeEntry.nextFree == _listLength)
            {
                throw new NotImplementedException("Il faut implémenter quand la liste dépasse");
            }

            int nextFreeEntry = freeEntry.nextFree;

            GenerationalIndex generationalIndex = new GenerationalIndex(_freeListHeadIndex, 0);

            _items[_freeListHeadIndex] = new OccupiedEntry<T>(0, value);
            _freeListHeadIndex = nextFreeEntry;

            return generationalIndex;
        }

        public void Remove(GenerationalIndex generationalIndex)
        {

        }

        public bool Contains(GenerationalIndex generationalIndex)
        {
            return false;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Entry item in _items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
