namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wcm_GovInteractRemark
    {
        [Key]
        public int RemarkId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int NodeId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(50)]
        public string RemarkType { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? AddDate { get; set; }

        public virtual wcm_GovInteractChannel wcm_GovInteractChannel { get; set; }
    }
}
