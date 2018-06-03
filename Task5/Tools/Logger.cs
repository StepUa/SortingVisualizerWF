using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.ComponentModel;


namespace Task5.Tools
{
    public enum LoggingLevels
    {
        Debug,
        Info,
        Warn,
        Error,
        Fatal
    };

    public class FileLogger
    {
        const string _fileName = "Log.txt";

        string _message;
        LoggingLevels _messageLevel;

        FileLogger()
        {

        }

        public FileLogger(LoggingLevels messageLevel, string message)
        {
            _message = message;
            _messageLevel = messageLevel;
        }

        static public void AddMessageToLog(FileLogger messageInfo)
        {
            string path = string.Format(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                "\\" + _fileName);

            DateTime localDate = DateTime.Now;

            string currentCulture = Thread.CurrentThread.CurrentCulture.Name;

            if (currentCulture == null)
            {
                currentCulture = "en-US";
            }

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    streamWriter.WriteLine("[{0}] [{1}] {2}",
                        localDate.ToString(new CultureInfo(currentCulture)), messageInfo._messageLevel.ToString(), messageInfo._message);
                }
            }
            catch (Exception)
            {

            }
        }

        static public void AddMessageToLog(object sender, DoWorkEventArgs e)
        {
            FileLogger messageInfo = (FileLogger)e.Argument;

            FileLogger.AddMessageToLog(messageInfo);
        }
    }
}
