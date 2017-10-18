namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_View360
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
        public string ContentImageUrl1 { get; set; }

        [StringLength(200)]
        public string ContentImageUrl2 { get; set; }

        [StringLength(200)]
        public string ContentImageUrl3 { get; set; }

        [StringLength(200)]
        public string ContentImageUrl4 { get; set; }

        [StringLength(200)]
        public string ContentImageUrl5 { get; set; }

        [StringLength(200)]
        public string ContentImageUrl6 { get; set; }
    }
}
