namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_VoteOperation
    {
        [Key]
        public int OperationId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? NodeId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
