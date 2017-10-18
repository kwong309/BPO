namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_NodeGroup
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string NodeGroupName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        public int? Taxis { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }
    }
}
