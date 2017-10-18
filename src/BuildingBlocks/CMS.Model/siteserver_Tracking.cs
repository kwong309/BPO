namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Tracking
    {
        [Key]
        public int TrackingId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string TrackerType { get; set; }

        public DateTime? LastAccessDateTime { get; set; }

        [StringLength(200)]
        public string PageUrl { get; set; }

        public int? PageNodeId { get; set; }

        public int? PageContentId { get; set; }

        [StringLength(200)]
        public string Referrer { get; set; }

        [StringLength(200)]
        public string IpAddress { get; set; }

        [StringLength(200)]
        public string OperatingSystem { get; set; }

        [StringLength(200)]
        public string Browser { get; set; }

        public DateTime? AccessDateTime { get; set; }
    }
}
