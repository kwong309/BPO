namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wcm_GovPublicChannel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }
    }
}
