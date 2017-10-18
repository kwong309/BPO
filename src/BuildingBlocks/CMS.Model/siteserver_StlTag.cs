namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_StlTag
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TagName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string TagDescription { get; set; }

        [Column(TypeName = "ntext")]
        public string TagContent { get; set; }
    }
}
