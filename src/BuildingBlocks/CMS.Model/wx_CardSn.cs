namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_CardSn
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? CardId { get; set; }

        [StringLength(200)]
        public string Sn { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
