namespace SlackDeploy.Graph.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deploys")]
    public partial class Deployment
    {
        public int id { get; set; }

        [StringLength(50)]
        public string sha { get; set; }      

        [StringLength(50)]
        public string action { get; set; }

        [StringLength(50)]
        public string engineer { get; set; }
        
        public DateTime date { get; set; }
    }
}
