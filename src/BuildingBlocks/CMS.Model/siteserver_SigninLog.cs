namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_SigninLog
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(18)]
        public string IsSignin { get; set; }

        public DateTime? SigninDate { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }
    }
}
