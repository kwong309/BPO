namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_TableMetadata
    {
        [Key]
        public int TableMetadataId { get; set; }

        [Required]
        [StringLength(50)]
        public string AuxiliaryTableEnName { get; set; }

        [StringLength(50)]
        public string AttributeName { get; set; }

        [StringLength(50)]
        public string DataType { get; set; }

        public int? DataLength { get; set; }

        public int? Taxis { get; set; }

        [StringLength(18)]
        public string IsSystem { get; set; }

        public virtual bairong_TableCollection bairong_TableCollection { get; set; }
    }
}
