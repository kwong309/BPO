namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_TemplateMatch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ChannelTemplateId { get; set; }

        public int? ContentTemplateId { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(200)]
        public string ChannelFilePathRule { get; set; }

        [StringLength(200)]
        public string ContentFilePathRule { get; set; }
    }
}
