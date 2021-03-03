using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLogger.Models
{
    public class DLogger
    {
        public static string LoggerDirectory { get; set; } =Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "logging_data");
        public static string TodayLoggerFile = Path.Combine(LoggerDirectory, "dlogger_" + DateTime.Now.ToString("MM_dd_yyyy") + ".txt");
        public static string LogFile
        {
            get
            {
                return Path.Combine(LoggerDirectory, "dlogger_" + DateTime.Now.ToString("MM_dd_yyyy") + ".txt"); ;
            }
        }
        public static void WriteCommit(string folder, string commit)
        {
            try
            {
                LoggerDirectory = folder;
                if (!Directory.Exists(LoggerDirectory))
                    Directory.CreateDirectory(LoggerDirectory);

                TodayLoggerFile = Path.Combine(LoggerDirectory, "dlogger_" + DateTime.Now.ToString("MM_dd_yyyy") + ".txt");

                if (!File.Exists(TodayLoggerFile))
                    File.Create(TodayLoggerFile);

                using (StreamWriter wt = new StreamWriter(TodayLoggerFile, true))
                {
                    wt.WriteLine($"--HH-{DateTime.Now.ToString("HH")}");
                    wt.WriteLine($"--HH:mm {DateTime.Now.ToString("HH:mm")}");
                    wt.WriteLine($"------- {DateTime.Now.ToString("HH:mm:ss")} ------");
                    wt.WriteLine();
                    wt.WriteLine(commit);
                    wt.WriteLine();
                    wt.WriteLine($"--HH:mm {DateTime.Now.ToString("HH:mm")}");
                    wt.WriteLine($"--HH-{DateTime.Now.ToString("HH")}");
                    wt.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            catch { }
        }

        public static async Task<string> SearchingData(DateTime searchingDate, int hour, int min, SearchingMode searchingMode)  //time format hh\seperate code -,:\
        {
            try
            {
                string logData = await GetLoggerData(searchingDate);
                if (string.IsNullOrEmpty(logData))
                    return string.Empty;

                switch (searchingMode)
                {
                    case SearchingMode.SDAY:
                        return logData;
                    case SearchingMode.SHOUR:
                        return string.Join("\r\n", SearchingByHour(logData, hour));

                    case SearchingMode.SHOUR_AND_MIN:
                        return string.Join("\r\n", SearchingByHourAndMin(logData, hour, min));
                }
            }
            catch { }
            return string.Empty;
        }

        private static string[] SearchingByHour(string data, int hour)
        {
            string prefix = $"--HH-{hour.ToString("00")}";
            string[] results = data.Split(new string[] { prefix }, StringSplitOptions.None);

            List<string> finalResult = new List<string>();
            foreach (var item in results)
            {
                if ((!string.IsNullOrEmpty(item)) && (item.IndexOf("--HH-") == -1))
                    finalResult.Add(item);
            }
            return finalResult.ToArray();
        }

        private static string[] SearchingByHourAndMin(string data, int hour, int min)
        {
            string prefix = $"--HH:mm {hour.ToString("00")}:{min.ToString("00")}";
            string[] results = data.Split(new string[] { prefix }, StringSplitOptions.None);

            List<string> finalResult = new List<string>();
            foreach (var item in results)
            {
                if ((!string.IsNullOrEmpty(item)) && (item.Contains($"{hour.ToString("00")}:{min.ToString("00")}")))
                    finalResult.Add(item);
            }
            return finalResult.ToArray();
        }

        public static async Task<string> GetLoggerData(DateTime date)
        {
            try
            {
                string[] files = Directory.GetFiles(LoggerDirectory);
                string searchingFileName = "dlogger_" + date.ToString("MM_dd_yyyy") + ".txt";
                foreach (var f in files)
                {
                    if (Path.GetFileName(f) == searchingFileName)
                    {
                        //reading data from log file
                        //$"------- {DateTime.Now.ToString("HH:mm:ss")} ------"
                        using (StreamReader rd = new StreamReader(f))
                        {
                            return await rd.ReadToEndAsync();
                        }
                    }
                }
            }
            catch { }
            return null;
        }

        public enum SearchingMode
        {
            SDAY,
            SHOUR,
            SHOUR_AND_MIN,
        }
    }
}
