namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_CardEntitySn
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? CardId { get; set; }

        [StringLength(200)]
        public string Sn { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public decimal? Amount { get; set; }

        public int? Credits { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(18)]
        public string IsBinding { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
