namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_InnerLink
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string InnerLinkName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [StringLength(200)]
        public string LinkUrl { get; set; }
    }
}
