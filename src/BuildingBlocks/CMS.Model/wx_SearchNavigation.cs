namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_SearchNavigation
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? SearchId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        [StringLength(200)]
        public string ImageCssClass { get; set; }

        [StringLength(50)]
        public string NavigationType { get; set; }

        [StringLength(50)]
        public string KeywordType { get; set; }

        public int? FunctionId { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }
    }
}
