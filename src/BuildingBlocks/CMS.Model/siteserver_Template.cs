namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Template
    {
        [Key]
        public int TemplateId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string TemplateName { get; set; }

        [StringLength(50)]
        public string TemplateType { get; set; }

        [StringLength(50)]
        public string RelatedFileName { get; set; }

        [StringLength(50)]
        public string CreatedFileFullName { get; set; }

        [StringLength(50)]
        public string CreatedFileExtName { get; set; }

        [StringLength(50)]
        public string Charset { get; set; }

        [StringLength(18)]
        public string IsDefault { get; set; }
    }
}
