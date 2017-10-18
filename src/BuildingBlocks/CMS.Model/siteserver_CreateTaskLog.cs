namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_CreateTaskLog
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CreateType { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        public int? TemplateId { get; set; }

        [StringLength(50)]
        public string TaskName { get; set; }

        [StringLength(50)]
        public string TimeSpan { get; set; }

        [StringLength(18)]
        public string IsSuccess { get; set; }

        [StringLength(255)]
        public string ErrorMessage { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
