namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_WebMenu
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string MenuName { get; set; }

        [StringLength(200)]
        public string IconUrl { get; set; }

        [StringLength(50)]
        public string IconCssClass { get; set; }

        [StringLength(50)]
        public string NavigationType { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(50)]
        public string KeywordType { get; set; }

        public int? FunctionId { get; set; }

        public int? ParentId { get; set; }

        public int? Taxis { get; set; }
    }
}
