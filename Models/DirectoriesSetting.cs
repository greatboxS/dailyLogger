using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLogger.Models
{
    public class DirectoriesSetting
    {
        public string BaseFolder { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        public string LogFolder { get; set; } = "ulogging";
    }
}
