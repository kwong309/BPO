namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Comment
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? NodeId { get; set; }

        public int? ContentId { get; set; }

        public int? GoodCount { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(500)]
        public string Content { get; set; }
    }
}
