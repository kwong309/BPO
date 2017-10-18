namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class model_WCM_GovInteract
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

        [StringLength(255)]
        public string DepartmentName { get; set; }

        [StringLength(255)]
        public string QueryCode { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(18)]
        public string IsRecommend { get; set; }

        [StringLength(18)]
        public string IsTop { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string RealName { get; set; }

        [StringLength(255)]
        public string Organization { get; set; }

        [StringLength(255)]
        public string CardType { get; set; }

        [StringLength(255)]
        public string CardNo { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        public int? TypeID { get; set; }

        [StringLength(18)]
        public string IsPublic { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(255)]
        public string FileUrl { get; set; }

        public int? DepartmentID { get; set; }
    }
}
