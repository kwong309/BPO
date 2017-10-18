namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_Conference
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
        public string BackgroundImageUrl { get; set; }

        [StringLength(255)]
        public string ConferenceName { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Duration { get; set; }

        [Column(TypeName = "ntext")]
        public string Introduction { get; set; }

        [StringLength(18)]
        public string IsAgenda { get; set; }

        [StringLength(255)]
        public string AgendaTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string AgendaList { get; set; }

        [StringLength(18)]
        public string IsGuest { get; set; }

        [StringLength(255)]
        public string GuestTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string GuestList { get; set; }

        [StringLength(255)]
        public string EndTitle { get; set; }

        [StringLength(200)]
        public string EndImageUrl { get; set; }

        [StringLength(255)]
        public string EndSummary { get; set; }
    }
}
