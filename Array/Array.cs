using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array : IEnumerable, ICloneable
    {
        public int Length { get; set; }
        protected Object[] InnerList { get; set; }

      
        
        public object DoubleArray()
        {
            InnerList = new Array[Length];
            var array = new Array[Length];
            for (int i = 0; i < Length-1; i++)
            {
                array[i] = (Array)InnerList[i];
            }
            return array;

        }
        public object HalfArray()
        {
            var array = new Object[Length];
            for (int i = Length; i >= Length/2; i--)
            {
                for (int j = 0; j < Length/2; j++)
                {   
                    
                    array[j] = (Array)InnerList[i];
                }
            }
            return $"{array} {InnerList}";       
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public Array(int Length)
        {
            this.Length = Length;
            InnerList = new Object[Length];
        }
        public Object GetValue(int index)
        {
            if (!(index >= 0 && index < InnerList.Length))
            {
                throw new ArgumentOutOfRangeException();
            }
            return InnerList[index];
        }
        public void SetValue(Object value, int index)
        {
            if (!(index >= 0 && index < InnerList.Length))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            InnerList[index] = value;
            
        }
    }
}
