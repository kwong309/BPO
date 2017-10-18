namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_Vote
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? KeywordId { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        public int? UserCount { get; set; }

        public int? PvCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

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

        [StringLength(18)]
        public string ContentIsImageOption { get; set; }

        [StringLength(18)]
        public string ContentIsCheckBox { get; set; }

        [StringLength(50)]
        public string ContentResultVisible { get; set; }

        [StringLength(255)]
        public string EndTitle { get; set; }

        [StringLength(200)]
        public string EndImageUrl { get; set; }

        [StringLength(255)]
        public string EndSummary { get; set; }
    }
}
