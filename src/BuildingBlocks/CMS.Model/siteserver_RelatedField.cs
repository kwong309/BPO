namespace CMS.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_RelatedField
    {

        public siteserver_RelatedField()
        {
            siteserver_RelatedFieldItem = new HashSet<siteserver_RelatedFieldItem>();
        }

        [Key]
        public int RelatedFieldId { get; set; }

        [StringLength(50)]
        public string RelatedFieldName { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? TotalLevel { get; set; }

        [StringLength(255)]
        public string Prefixes { get; set; }

        [StringLength(255)]
        public string Suffixes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siteserver_RelatedFieldItem> siteserver_RelatedFieldItem { get; set; }
    }
}
