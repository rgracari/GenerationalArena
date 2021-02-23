using System;
using System.Collections.Generic;
using System.Text;

namespace GenerationalArena
{
    public struct GenerationalIndex
    {
        public int index;
        public uint generation;
    
        public GenerationalIndex(int index, uint generation)
        {
            this.index = index;
            this.generation = generation;
        }

        public override string ToString()
        {
            return $"GenerationalIndex -> index: {index}, generation: {generation}";
        }
    }
}
