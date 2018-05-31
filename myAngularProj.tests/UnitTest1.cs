using System;
using Xunit;
using myAngularProj.Models;

namespace myAngularProj.tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            RegisterModel reg = new RegisterModel();
            Assert.Equal(reg.Name,"ji");
        }
        [Fact]
        public void TestGreetings()
        {
        RegisterController reg=new RegisterController();
        string s= reg.Greetings();
        Assert.Equal(s, "Hello from ASP.NET Core Web API.");
        }
    }
}
