using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLogger
{
    public class SqlLiteDbContext: DbContext
    {
        public SqlLiteDbContext(string connectionString): base(connectionString)
        {

        }

        public DbSet<DailyLoggerCommit> DailyLoggerCommit { get; set; }
    }
}
