namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wcm_GovPublicIdentifierRule
    {
        [Key]
        public int RuleId { get; set; }

        [StringLength(255)]
        public string RuleName { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string IdentifierType { get; set; }

        public int? MinLength { get; set; }

        [StringLength(50)]
        public string Suffix { get; set; }

        [StringLength(50)]
        public string FormatString { get; set; }

        [StringLength(50)]
        public string AttributeName { get; set; }

        public int? Sequence { get; set; }

        public int? Taxis { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }
    }
}
