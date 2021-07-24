using System;
using Siemens;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Android", "Hi, I am from Android")]
        [InlineData("Windows", "Hi, I am from Windows")]
        [InlineData("Ios", "Hi, I am from Ios")]
      

        public void Print_PrintsAppropriateMessage_WhenInputIsValid(string device,string expectedOutput)
        {
            //Arrange
            DeviceService sut=new DeviceService(new DeviceFactory());
            var userInput = device;
            //Act
           var response= sut.GetMessage(userInput);
            //Assert

            Assert.Equal(response, expectedOutput);
        }

        [Fact]
        public void Print_PrintsAppropriateMessage_WhenInputIsInvalid()
        {
            //Arrange
            DeviceService sut=new DeviceService(new DeviceFactory());
            var userInput = "InvalidInput";
            //Act
           var response= sut.GetMessage(userInput);
            //Assert

            Assert.Equal(response, "Invalid Selection");
        }
    }
}
