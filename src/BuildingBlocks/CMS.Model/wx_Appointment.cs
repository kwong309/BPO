namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_Appointment
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? KeywordId { get; set; }

        public int? UserCount { get; set; }

        public int? PvCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(18)]
        public string ContentIsSingle { get; set; }

        [StringLength(200)]
        public string ContentImageUrl { get; set; }

        [StringLength(255)]
        public string ContentDescription { get; set; }

        [StringLength(200)]
        public string ContentResultTopImageUrl { get; set; }

        [StringLength(255)]
        public string EndTitle { get; set; }

        [StringLength(200)]
        public string EndImageUrl { get; set; }

        [StringLength(255)]
        public string EndSummary { get; set; }

        [StringLength(18)]
        public string IsFormRealName { get; set; }

        [StringLength(50)]
        public string FormRealNameTitle { get; set; }

        [StringLength(18)]
        public string IsFormMobile { get; set; }

        [StringLength(50)]
        public string FormMobileTitle { get; set; }

        [StringLength(18)]
        public string IsFormEmail { get; set; }

        [StringLength(50)]
        public string FormEmailTitle { get; set; }
    }
}
