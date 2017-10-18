namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Star
    {
        [Key]
        public int StarId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public int? Point { get; set; }

        [StringLength(255)]
        public string Message { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
