using System;
using System.Collections.Generic;
using System.Text;

namespace Siemens
{
 public   class DeviceService
    {
        private readonly IDeviceFactory _factory;

        public DeviceService(IDeviceFactory factory)
        {
            _factory = factory;
        }


        public string GetMessage(string userInput)
        {

            DeviceEnum parsedInput; 
                var userEnum = Enum.TryParse(userInput,out parsedInput);

                if (userEnum)
                {
                    var device = _factory.CreateDevice(parsedInput);
                    return device.Print();
            }

                return "Invalid Selection";
        }
    }
}
