namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_SystemPermissions
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string RoleName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [Column(TypeName = "text")]
        public string NodeIdCollection { get; set; }

        [Column(TypeName = "text")]
        public string ChannelPermissions { get; set; }

        [Column(TypeName = "text")]
        public string WebsitePermissions { get; set; }
    }
}
