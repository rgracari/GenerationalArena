using System;
using System.Collections.Generic;
using System.Text;

namespace GenerationalArena
{
    public abstract class Entry
    {

    }

    public class OccupiedEntry<T> : Entry
    {
        public uint generation;
        public T value;

        public OccupiedEntry(uint generation, T value)
        {
            this.generation = generation;
            this.value = value;
        }

        public override string ToString()
        {
            return $"OccupiedEntry -> Generation: {generation}, value: {value}";
        }
    }

    public class FreeEntry : Entry
    {
        public int nextFree;

        public FreeEntry(int nextFree)
        {
            this.nextFree = nextFree;
        }

        public override string ToString()
        {
            return $"FreeEntry -> Next free entry: {nextFree}";
        }
    }
}
