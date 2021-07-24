using System;
using System.Collections.Generic;
using System.Text;

namespace Siemens
{
    public interface IDeviceFactory
    {
        IDevice CreateDevice(DeviceEnum deviceEnum);

    }
}
