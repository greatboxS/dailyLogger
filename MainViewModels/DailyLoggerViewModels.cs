using DailyLogger.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLogger.MainViewModels
{
    public class DailyLoggerViewModels
    {
        public AppSettingModels AppSettingModels { get; set; }
        public List<string> OldCommit { get; set; }
        public DailyLoggerViewModels()
        {
            AppSettingModels = new AppSettingModels();
            OldCommit = new List<string>();
        }
    }

    public static class DailyExtension
    {
        public static void SaveSetting(this DailyLoggerViewModels md)
        {
            DailyLoggerSetting.Default.DailyLoggerViewModels = JsonConvert.SerializeObject(md);
            DailyLoggerSetting.Default.Save();
        }

        public static void UpdateSetting(this DailyLoggerViewModels md, Font font)
        {
            md.AppSettingModels.Font = font;
            md.SaveSetting();
        }

        public static void UpdateSetting(this DailyLoggerViewModels md, string baseFolder)
        {
            md.AppSettingModels.DirectoriesSetting.BaseFolder = baseFolder;
            md.SaveSetting();
        }
    }

}
