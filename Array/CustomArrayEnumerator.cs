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
            index = sourcearray.Length;
        }

        public bool MoveNext()
        {
            if (index > 0)
            {
                index--;
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