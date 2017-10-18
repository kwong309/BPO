namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wcm_GovInteractPermissions
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeId { get; set; }

        [StringLength(255)]
        public string Permissions { get; set; }

        public virtual wcm_GovInteractChannel wcm_GovInteractChannel { get; set; }
    }
}
