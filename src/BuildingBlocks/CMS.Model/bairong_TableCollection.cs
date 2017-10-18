namespace CMS.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_TableCollection
    {
        public bairong_TableCollection()
        {
            bairong_TableMetadata = new HashSet<bairong_TableMetadata>();
        }

        [Key]
        [StringLength(50)]
        public string TableEnName { get; set; }

        [StringLength(50)]
        public string TableCnName { get; set; }

        public int? AttributeNum { get; set; }

        [StringLength(50)]
        public string AuxiliaryTableType { get; set; }

        [StringLength(18)]
        public string IsCreatedInDb { get; set; }

        [StringLength(18)]
        public string IsChangedAfterCreatedInDb { get; set; }

        [StringLength(18)]
        public string IsDefault { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public virtual ICollection<bairong_TableMetadata> bairong_TableMetadata { get; set; }
    }
}
