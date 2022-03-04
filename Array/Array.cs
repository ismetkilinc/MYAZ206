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

      
        
        public void DoubleArray()
        {

            var array = new Array(Length);
            for (int i = 0; i < Length-1; i++)
            {
                array.SetValue(GetValue(i), i);
                Console.WriteLine(array.GetValue(i));
            }
            
            

        }
        public Object HalfArray()
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
        public Object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomArrayEnumerator(InnerList);
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
        public Array(params Object[] sourcearray):this(sourcearray.Length)
        {
            int c = 0;
            foreach (var item in sourcearray)
            {
                InnerList[c] = item;
                c++;
            }
        }
        

     }
}

