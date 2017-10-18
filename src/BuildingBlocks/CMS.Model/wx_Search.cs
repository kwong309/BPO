namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_Search
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? KeywordId { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        public int? PvCount { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(200)]
        public string ContentImageUrl { get; set; }

        [StringLength(18)]
        public string IsOutsiteSearch { get; set; }

        [StringLength(18)]
        public string IsNavigation { get; set; }

        [StringLength(50)]
        public string NavTitleColor { get; set; }

        [StringLength(50)]
        public string NavImageColor { get; set; }

        [StringLength(50)]
        public string ImageAreaTitle { get; set; }

        public int? ImageAreaChannelId { get; set; }

        [StringLength(50)]
        public string TextAreaTitle { get; set; }

        public int? TextAreaChannelId { get; set; }
    }
}
