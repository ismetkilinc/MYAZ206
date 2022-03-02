using System;
using Xunit;


namespace Tests
{
    public class RangeofTypes
    {
        [Fact]
        public void ValueRangeOfByte()
        {
            //arrange 
            byte minValue, maxValue;
            //act 
            minValue = 0;
            maxValue = 255;
            //assert
            Assert.Equal(minValue, byte.MinValue);
            Assert.Equal(maxValue, byte.MaxValue);
        }
        [Fact]
        public void ValueRangeOfSbyte()
        {
            //arrange
            sbyte minValue, maxValue;

            //act
            minValue = -128;
            maxValue = 127;

            //assert
            Assert.Equal(minValue, sbyte.MinValue);
            Assert.Equal(maxValue, sbyte.MaxValue);
        }
        [Fact]
        public void ValueRangeOfInt()
        {
            //arrange
            int minValue, maxValue;

            //act
            minValue = -32768;
            maxValue = 32767;

            //assert
            Assert.Equal(minValue, Int16.MinValue);
            Assert.Equal(maxValue, Int16.MaxValue);
        }
    }
}