using System.Data.Common;
using System.Data.Entity; 

namespace HairDresserService.Data
{
    public abstract class BaseDataContext : DbContext
    {
        protected class DatabaseLogger
        {
            public static void Log(string logInfo)
            {
                System.Diagnostics.Debug.WriteLine(logInfo);
            }
        }

        public BaseDataContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {
            //Database.Log = logInfo => DatabaseLogger.Log(logInfo);
        }

        public BaseDataContext(string connectionStringName)
            : base(connectionStringName)
        {
            //Database.Log = logInfo => DatabaseLogger.Log(logInfo);
        }

        public void InitializeDatabase()
        {
            this.Database.Initialize(false);
        }

        #region DbContext override

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

        #endregion
    }
}
