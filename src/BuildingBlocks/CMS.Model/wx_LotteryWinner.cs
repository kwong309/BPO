namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_LotteryWinner
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string LotteryType { get; set; }

        public int? LotteryId { get; set; }

        public int? AwardId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string CookieSn { get; set; }

        [StringLength(200)]
        public string WxOpenId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string RealName { get; set; }

        [StringLength(200)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(200)]
        public string CashSn { get; set; }

        public DateTime? CashDate { get; set; }
    }
}
