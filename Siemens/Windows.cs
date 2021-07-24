using System;

namespace Siemens
{
    internal class Windows : IDevice
    {
        public string Print()
        {
            return "Hi, I am from Windows";
        }
    }
}