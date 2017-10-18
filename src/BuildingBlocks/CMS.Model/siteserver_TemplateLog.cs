namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_TemplateLog
    {
        public int Id { get; set; }

        public int? TemplateId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string AddUserName { get; set; }

        public int? ContentLength { get; set; }

        [Column(TypeName = "ntext")]
        public string TemplateContent { get; set; }
    }
}
