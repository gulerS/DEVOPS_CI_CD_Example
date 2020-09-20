using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(03);
            
            Assert.Equal("Sercan Güler", returnValue);
            
        }



        [Fact]
        public void Test1()
        {




        }
    }
}
