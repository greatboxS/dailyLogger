using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLogger
{
    public class DailyLoggerCommit
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Commit { get; set; }
        public DateTime CommitTime { get; set; }
        public string LoggingFilePath { get; set; }
    }
}
