namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wcm_GovPublicApplyRemark
    {
        [Key]
        public int RemarkId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ApplyId { get; set; }

        [StringLength(50)]
        public string RemarkType { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? AddDate { get; set; }

        public virtual wcm_GovPublicApply wcm_GovPublicApply { get; set; }
    }
}
