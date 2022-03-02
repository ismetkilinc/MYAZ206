using System;
using Xunit;


namespace Tests
{
    public class ArrayTest
    {
        [Fact]
        public void SetValue()
        {
            //arrange
            var arr = new object[5];
            
            //act
            arr[0] = 1;
            
            //assert
            Assert.Equal(1, arr[0]);
        }
        [Fact]
        public void GetValue()
        {
            //arrange
            var arr = new object[] { 1, 2 };

            //act
            var arr2 = arr.GetValue(0);

            //assert
            Assert.Equal(1, arr2);
        }
        [Fact]
        public void Clone()
        {
            //arrange 
            var arr = new object[1,2,3];
            
            

            //act
            var arr2 = arr.Clone();
            

            //assert
            Assert.Equal(arr2, arr );
        }

    }
}