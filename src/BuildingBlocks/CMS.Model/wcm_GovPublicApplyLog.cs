namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wcm_GovPublicApplyLog
    {
        [Key]
        public int LogId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ApplyId { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string LogType { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        public virtual wcm_GovPublicApply wcm_GovPublicApply { get; set; }
    }
}
