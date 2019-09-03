using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfacesAndExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            //by using 'using' we are automatically wrapping the streamwriter in an error handling.
            //If an error occurs when trying to write the file, the handle to the file will automatically be disposed.
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
