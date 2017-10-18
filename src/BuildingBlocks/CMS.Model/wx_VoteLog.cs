namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_VoteLog
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? VoteId { get; set; }

        [StringLength(200)]
        public string ItemIdCollection { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(50)]
        public string CookieSn { get; set; }

        [StringLength(200)]
        public string WxOpenId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
