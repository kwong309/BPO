namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_PublishmentSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string PublishmentSystemName { get; set; }

        [StringLength(50)]
        public string PublishmentSystemType { get; set; }

        [StringLength(50)]
        public string AuxiliaryTableForContent { get; set; }

        [StringLength(50)]
        public string AuxiliaryTableForGovPublic { get; set; }

        [StringLength(50)]
        public string AuxiliaryTableForGovInteract { get; set; }

        [StringLength(50)]
        public string AuxiliaryTableForVote { get; set; }

        [StringLength(50)]
        public string AuxiliaryTableForJob { get; set; }

        [StringLength(18)]
        public string IsCheckContentUseLevel { get; set; }

        public int? CheckContentLevel { get; set; }

        [StringLength(50)]
        public string PublishmentSystemDir { get; set; }

        [StringLength(200)]
        public string PublishmentSystemUrl { get; set; }

        [StringLength(18)]
        public string IsHeadquarters { get; set; }

        public int? ParentPublishmentSystemId { get; set; }

        public int? Taxis { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }
    }
}
