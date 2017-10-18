namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class model_WCM_GovPublic
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

        public int? DepartmentID { get; set; }

        public int? Category1ID { get; set; }

        public int? Category2ID { get; set; }

        public int? Category3ID { get; set; }

        public int? Category4ID { get; set; }

        public int? Category5ID { get; set; }

        public int? Category6ID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Identifier { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime? PublishDate { get; set; }

        public DateTime? EffectDate { get; set; }

        [StringLength(18)]
        public string IsAbolition { get; set; }

        public DateTime? AbolitionDate { get; set; }

        [StringLength(255)]
        public string DocumentNo { get; set; }

        [StringLength(255)]
        public string Publisher { get; set; }

        [StringLength(255)]
        public string Keywords { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string FileUrl { get; set; }

        [StringLength(18)]
        public string IsRecommend { get; set; }

        [StringLength(18)]
        public string IsHot { get; set; }

        [StringLength(18)]
        public string IsColor { get; set; }

        [StringLength(18)]
        public string IsTop { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
