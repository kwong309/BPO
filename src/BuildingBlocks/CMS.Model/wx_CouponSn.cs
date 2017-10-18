namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_CouponSn
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? CouponId { get; set; }

        [StringLength(200)]
        public string Sn { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? HoldDate { get; set; }

        [StringLength(255)]
        public string HoldRealName { get; set; }

        [StringLength(200)]
        public string HoldMobile { get; set; }

        [StringLength(200)]
        public string HoldEmail { get; set; }

        [StringLength(255)]
        public string HoldAddress { get; set; }

        [StringLength(50)]
        public string CookieSn { get; set; }

        [StringLength(200)]
        public string WxOpenId { get; set; }

        public DateTime? CashDate { get; set; }

        [StringLength(50)]
        public string CashUserName { get; set; }
    }
}
