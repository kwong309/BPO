namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_Coupon
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ActId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public int? TotalNum { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
