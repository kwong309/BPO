namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_KeywordResource
    {
        [Key]
        public int ResourceId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? KeywordId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(50)]
        public string ResourceType { get; set; }

        [StringLength(18)]
        public string IsShowCoverPic { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(200)]
        public string NavigationUrl { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        public int? Taxis { get; set; }
    }
}
