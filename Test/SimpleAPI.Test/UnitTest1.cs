using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        SimpleAPIController controller = new SimpleAPIController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);  
            Assert.Equal("Somthing else", returnValue.Value); 
        }


        [Fact]
        public void Test1()
        { 

        }
    }
}
