namespace CMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wcm_GovPublicApply
    {

        public wcm_GovPublicApply()
        {
            wcm_GovPublicApplyLog = new HashSet<wcm_GovPublicApplyLog>();
            wcm_GovPublicApplyRemark = new HashSet<wcm_GovPublicApplyRemark>();
            wcm_GovPublicApplyReply = new HashSet<wcm_GovPublicApplyReply>();
        }

        public int Id { get; set; }

        public int? StyleId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(18)]
        public string IsOrganization { get; set; }

        [StringLength(255)]
        public string CivicName { get; set; }

        [StringLength(255)]
        public string CivicOrganization { get; set; }

        [StringLength(255)]
        public string CivicCardType { get; set; }

        [StringLength(255)]
        public string CivicCardNo { get; set; }

        [StringLength(50)]
        public string CivicPhone { get; set; }

        [StringLength(50)]
        public string CivicPostCode { get; set; }

        [StringLength(255)]
        public string CivicAddress { get; set; }

        [StringLength(255)]
        public string CivicEmail { get; set; }

        [StringLength(50)]
        public string CivicFax { get; set; }

        [StringLength(255)]
        public string OrgName { get; set; }

        [StringLength(255)]
        public string OrgUnitCode { get; set; }

        [StringLength(255)]
        public string OrgLegalPerson { get; set; }

        [StringLength(255)]
        public string OrgLinkName { get; set; }

        [StringLength(50)]
        public string OrgPhone { get; set; }

        [StringLength(50)]
        public string OrgPostCode { get; set; }

        [StringLength(255)]
        public string OrgAddress { get; set; }

        [StringLength(255)]
        public string OrgEmail { get; set; }

        [StringLength(50)]
        public string OrgFax { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(255)]
        public string Purpose { get; set; }

        [StringLength(18)]
        public string IsApplyFree { get; set; }

        [StringLength(50)]
        public string ProvideType { get; set; }

        [StringLength(50)]
        public string ObtainType { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        public int? DepartmentId { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string QueryCode { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovPublicApplyLog> wcm_GovPublicApplyLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovPublicApplyRemark> wcm_GovPublicApplyRemark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wcm_GovPublicApplyReply> wcm_GovPublicApplyReply { get; set; }
    }
}
