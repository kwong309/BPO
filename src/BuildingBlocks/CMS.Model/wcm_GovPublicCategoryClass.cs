namespace CMS.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wcm_GovPublicCategoryClass
    {

        public wcm_GovPublicCategoryClass()
        {
            wcm_GovPublicCategory = new HashSet<wcm_GovPublicCategory>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ClassCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string ClassName { get; set; }

        [StringLength(18)]
        public string IsSystem { get; set; }

        [StringLength(18)]
        public string IsEnabled { get; set; }

        [StringLength(50)]
        public string ContentAttributeName { get; set; }

        public int? Taxis { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovPublicCategory> wcm_GovPublicCategory { get; set; }
    }
}
