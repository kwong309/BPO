namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Log
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string Action { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }
    }
}
