namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_GatherDatabaseRule
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string GatherRuleName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string ConnectionString { get; set; }

        [StringLength(255)]
        public string RelatedTableName { get; set; }

        [StringLength(255)]
        public string RelatedIdentity { get; set; }

        [StringLength(255)]
        public string RelatedOrderBy { get; set; }

        [StringLength(255)]
        public string WhereString { get; set; }

        public int? TableMatchId { get; set; }

        public int? NodeId { get; set; }

        public int? GatherNum { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        [StringLength(18)]
        public string IsAutoCreate { get; set; }

        [StringLength(18)]
        public string IsOrderByDesc { get; set; }

        public DateTime? LastGatherDate { get; set; }
    }
}
