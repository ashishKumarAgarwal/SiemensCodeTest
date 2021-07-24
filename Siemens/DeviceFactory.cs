using System;
using System.Collections.Generic;
using System.Text;

namespace Siemens
{
    public class DeviceFactory : IDeviceFactory
    {
       public IDevice CreateDevice(DeviceEnum deviceEnum)
        {
            switch (deviceEnum)
            {
                case DeviceEnum.Android:
                    return new Andoid();
                case DeviceEnum.Ios:
                    return new Ios();
                case DeviceEnum.Windows:
                    return new Windows(); 
               default:
                   throw new Exception("Invalid Selection");
            }
        }
    }
}
