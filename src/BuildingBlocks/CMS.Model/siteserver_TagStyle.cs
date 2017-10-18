namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_TagStyle
    {
        [Key]
        public int StyleId { get; set; }

        [StringLength(50)]
        public string StyleName { get; set; }

        [StringLength(50)]
        public string ElementName { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(18)]
        public string IsTemplate { get; set; }

        [Column(TypeName = "ntext")]
        public string StyleTemplate { get; set; }

        [Column(TypeName = "ntext")]
        public string ScriptTemplate { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentTemplate { get; set; }

        [Column(TypeName = "ntext")]
        public string SuccessTemplate { get; set; }

        [Column(TypeName = "ntext")]
        public string FailureTemplate { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }
    }
}
