namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_ContentModel
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ModelId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SiteId { get; set; }

        [StringLength(50)]
        public string ModelName { get; set; }

        [StringLength(18)]
        public string IsSystem { get; set; }

        [StringLength(200)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string TableType { get; set; }

        [StringLength(50)]
        public string IconUrl { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
