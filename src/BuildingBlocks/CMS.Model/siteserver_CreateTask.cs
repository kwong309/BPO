namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_CreateTask
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CreateType { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        public int? TemplateId { get; set; }
    }
}
