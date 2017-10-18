namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_LotteryAward
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? LotteryId { get; set; }

        [StringLength(255)]
        public string AwardName { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public int? TotalNum { get; set; }

        public decimal? Probability { get; set; }

        public int? WonNum { get; set; }
    }
}
