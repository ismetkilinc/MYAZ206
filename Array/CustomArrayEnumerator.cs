using System.Collections;

namespace Array
{
    public class CustomArrayEnumerator : IEnumerator
    {
        private Object[] _array;
        private int index;
        public object Current =>_array[index];

        public CustomArrayEnumerator(Object[] sourcearray)
        {
            _array = sourcearray;
            index = -1;
        }

        public bool MoveNext()
        {
            if (index < _array.Length-1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
             index=-1;
        }
    }
}