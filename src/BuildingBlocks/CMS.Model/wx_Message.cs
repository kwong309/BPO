namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_Message
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? KeywordId { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        public int? UserCount { get; set; }

        public int? PvCount { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(200)]
        public string ContentImageUrl { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentDescription { get; set; }
    }
}
