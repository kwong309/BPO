namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_AppointmentContent
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? AppointmentId { get; set; }

        public int? AppointmentItemId { get; set; }

        [StringLength(50)]
        public string CookieSn { get; set; }

        [StringLength(200)]
        public string WxOpenId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(255)]
        public string Message { get; set; }

        public DateTime? AddDate { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }
    }
}
