namespace CMS.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wcm_GovInteractChannel
    {

        public wcm_GovInteractChannel()
        {
            wcm_GovInteractPermissions = new HashSet<wcm_GovInteractPermissions>();
            wcm_GovInteractReply = new HashSet<wcm_GovInteractReply>();
            wcm_GovInteractRemark = new HashSet<wcm_GovInteractRemark>();
            wcm_GovInteractType = new HashSet<wcm_GovInteractType>();
            wcm_GovInteractLog = new HashSet<wcm_GovInteractLog>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NodeId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ApplyStyleId { get; set; }

        public int? QueryStyleId { get; set; }

        [StringLength(255)]
        public string DepartmentIdCollection { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovInteractPermissions> wcm_GovInteractPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovInteractReply> wcm_GovInteractReply { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovInteractRemark> wcm_GovInteractRemark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovInteractType> wcm_GovInteractType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovInteractLog> wcm_GovInteractLog { get; set; }
    }
}
