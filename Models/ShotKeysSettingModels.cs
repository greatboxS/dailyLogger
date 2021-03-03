using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyLogger.Models
{
    public class ShotKeysSettingModels
    {
        public List<Keys> OpenCurrentLogFolder { get; set; }
        public List<Keys> ShowHideForm { get; set; }
        public List<Keys> ShowHideNewCommit { get; set; }
        public List<Keys> ShowLogFile { get; set; }
        public List<Keys> LogCommit { get; set; }
        public List<Keys> AlwaysOnTop { get; set; }
        public List<Keys> Searching { get; set; }
        public List<Keys> AutoSave { get; set; }
        public List<Keys> FullScreen { get; set; }

        public ShotKeysSettingModels()
        {
            OpenCurrentLogFolder = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.O }); //Ctrl+Alt+O
            ShowHideForm = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.F });       //Ctrl+Alt+F
            ShowHideNewCommit = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.C });  //Ctrl+Alt+C
            LogCommit = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.L });          //Ctrl+Alt+L
            ShowLogFile = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.I });        //Ctrl+Alt+I
            AlwaysOnTop = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.T });        //Ctrl+Alt+T
            Searching = new List<Keys>(new Keys[] { Keys.Control, Keys.F });        //Ctrl+F
            AutoSave = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.K });        //Ctrl+Alt+K
            FullScreen = new List<Keys>(new Keys[] { Keys.Control, Keys.Alt, Keys.M });        //Ctrl+Alt+K
        }
    }
}


