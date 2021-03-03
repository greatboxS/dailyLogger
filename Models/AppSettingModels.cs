using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLogger.Models
{
    public class AppSettingModels
    {
        public ShotKeysSettingModels ShotKeysSettingModels { get; set; }
        public DirectoriesSetting DirectoriesSetting { get; set; }

        public bool  AutoSave { get; set; }
        public int AutoSaveTime { get; set; }//min 
        public bool AlwaysOnTop { get; set; } = false;
        public System.Drawing.Font Font { get; set; }
        public AppSettingModels()
        {
            AutoSave = false;
            AutoSaveTime = 5; // 5 mins
            ShotKeysSettingModels = new ShotKeysSettingModels();
            DirectoriesSetting = new DirectoriesSetting();
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
