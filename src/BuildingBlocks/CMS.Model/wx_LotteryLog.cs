namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_LotteryLog
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? LotteryId { get; set; }

        [StringLength(50)]
        public string CookieSn { get; set; }

        [StringLength(200)]
        public string WxOpenId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public int? LotteryCount { get; set; }

        public int? LotteryDailyCount { get; set; }

        public DateTime? LastLotteryDate { get; set; }
    }
}
