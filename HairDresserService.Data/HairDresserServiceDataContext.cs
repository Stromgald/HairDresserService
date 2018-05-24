using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;
using HairDresserService.Data.Model;

namespace HairDresserService.Data
{
    public class HairDresserServiceDataContext : BaseDataContext
    {
        public HairDresserServiceDataContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HairDresserServiceDataContext, HairDresserService.Data.Migrations.Configuration>(true));

            this.SessionID = Guid.NewGuid();

            //System.Diagnostics.Debug.WriteLine("New PromotionProfessionalServiceDataContext ... " + this.SessionID);
        }

        public HairDresserServiceDataContext() : base("PromotionProfessionalServiceDataContext")
        {
            this.SessionID = Guid.NewGuid();

            this.Database.Connection.Open();

            //System.Diagnostics.Debug.WriteLine("New PromotionProfessionalServiceDataContext ... " + this.SessionID);
        }

        
        public Guid SessionID { get; private set; }

        public virtual DbSet<Contact> Contacts { get; set; }


        #region DbContext override

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public override System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            try
            {
                return base.SaveChangesAsync();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public override System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            try
            {
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        #endregion
    }
}
