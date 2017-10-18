namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wcm_GovPublicApplyReply
    {
        [Key]
        public int ReplyId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ApplyId { get; set; }

        [Column(TypeName = "ntext")]
        public string Reply { get; set; }

        [StringLength(255)]
        public string FileUrl { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? AddDate { get; set; }

        public virtual wcm_GovPublicApply wcm_GovPublicApply { get; set; }
    }
}
