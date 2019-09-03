using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndExtensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
