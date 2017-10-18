namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_MessageContent
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? MessageId { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(50)]
        public string CookieSn { get; set; }

        [StringLength(200)]
        public string WxOpenId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public int? ReplyCount { get; set; }

        public int? LikeCount { get; set; }

        [Column(TypeName = "ntext")]
        public string LikeCookieSnCollection { get; set; }

        [StringLength(18)]
        public string IsReply { get; set; }

        public int? ReplyId { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(255)]
        public string Content { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
