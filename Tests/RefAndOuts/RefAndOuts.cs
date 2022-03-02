using System;
using Xunit;


namespace Tests
{
    public class RefAndOuts
    {
        [Fact]
        public void Ref()
        {
            //arrange
            var p1 = new RefType(1);

            //act
            var p2 = p1;
            p2.X++;

            //assert

            Assert.Equal(p2 , p1); 



        }
        [Fact]
        public void Out()
        {
            //arrange
            var o = new RefType(15);
            var s = o.X;



            //act
            o.Out(out s);

            //assert
            Assert.NotEqual(s , o.X);
            



        }

    }
}