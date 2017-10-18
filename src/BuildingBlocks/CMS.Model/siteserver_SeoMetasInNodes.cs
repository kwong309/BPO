namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_SeoMetasInNodes
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(18)]
        public string IsChannel { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeoMetaId { get; set; }

        public int? PublishmentSystemId { get; set; }
    }
}
