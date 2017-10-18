namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_ConferenceContent
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ConferenceId { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(50)]
        public string CookieSn { get; set; }

        [StringLength(200)]
        public string WxOpenId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Company { get; set; }

        [StringLength(255)]
        public string Position { get; set; }

        [StringLength(255)]
        public string Note { get; set; }
    }
}
