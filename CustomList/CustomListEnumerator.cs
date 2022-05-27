using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    public class CustomListEnumerator : IEnumerator<int>
    {
        private readonly int[] _items;
        private int index = 0;
        public CustomListEnumerator(int[] items)
        {
            _items = items;
        }

        public bool MoveNext()
        {
            return index++ < _items.Length;

        }

        public void Reset()
        {
            index = 0;
        }

        public int Current => _items[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}