namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_CardCashLog
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public int? CardId { get; set; }

        public int? CardSnId { get; set; }

        [StringLength(50)]
        public string CashType { get; set; }

        public decimal? Amount { get; set; }

        public decimal? CurAmount { get; set; }

        [StringLength(50)]
        public string ConsumeType { get; set; }

        [StringLength(255)]
        public string Operator { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
