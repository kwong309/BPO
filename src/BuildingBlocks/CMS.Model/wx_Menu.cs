namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_Menu
    {
        [Key]
        public int MenuId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string MenuName { get; set; }

        [StringLength(50)]
        public string MenuType { get; set; }

        [StringLength(50)]
        public string Keyword { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        public int? ParentId { get; set; }

        public int? Taxis { get; set; }
    }
}
