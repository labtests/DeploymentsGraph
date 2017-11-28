namespace SlackDeploy.Graph.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DriveTrackDB : DbContext
    {
        public DriveTrackDB()
            : base("name=DriveTrackDB")
        {
        }


        public virtual DbSet<Deployment> deployments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
