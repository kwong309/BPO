namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class model_Vote
    {
        public int ID { get; set; }

        public int? NodeID { get; set; }

        public int? PublishmentSystemID { get; set; }

        [StringLength(255)]
        public string AddUserName { get; set; }

        [StringLength(255)]
        public string LastEditUserName { get; set; }

        [StringLength(255)]
        public string WritingUserName { get; set; }

        public DateTime? LastEditDate { get; set; }

        public int? Taxis { get; set; }

        [StringLength(255)]
        public string ContentGroupNameCollection { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        public int? SourceID { get; set; }

        public int? ReferenceID { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        public int? CheckedLevel { get; set; }

        public int? Comments { get; set; }

        public int? Photos { get; set; }

        public int? Hits { get; set; }

        public int? HitsByDay { get; set; }

        public int? HitsByWeek { get; set; }

        public int? HitsByMonth { get; set; }

        public DateTime? LastHitsDate { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXML { get; set; }

        [StringLength(18)]
        public string IsImageVote { get; set; }

        [StringLength(18)]
        public string IsSummary { get; set; }

        public int? Participants { get; set; }

        [StringLength(18)]
        public string IsClosed { get; set; }

        [StringLength(18)]
        public string IsTop { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string SubTitle { get; set; }

        public int? MaxSelectNum { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [Column(TypeName = "ntext")]
        public string Summary { get; set; }

        public DateTime? AddDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(18)]
        public string IsVotedView { get; set; }

        [Column(TypeName = "ntext")]
        public string HiddenContent { get; set; }
    }
}
