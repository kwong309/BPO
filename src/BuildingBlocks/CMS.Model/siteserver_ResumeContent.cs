namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_ResumeContent
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? JobContentId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(18)]
        public string IsView { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(50)]
        public string LastSchoolName { get; set; }

        [StringLength(50)]
        public string Education { get; set; }

        [StringLength(50)]
        public string IdCardType { get; set; }

        [StringLength(50)]
        public string IdCardNo { get; set; }

        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(50)]
        public string Marriage { get; set; }

        [StringLength(50)]
        public string WorkYear { get; set; }

        [StringLength(50)]
        public string Profession { get; set; }

        [StringLength(50)]
        public string ExpectSalary { get; set; }

        [StringLength(50)]
        public string AvailabelTime { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        public int? Exp_Count { get; set; }

        [StringLength(50)]
        public string Exp_FromYear { get; set; }

        [StringLength(50)]
        public string Exp_FromMonth { get; set; }

        [StringLength(50)]
        public string Exp_ToYear { get; set; }

        [StringLength(50)]
        public string Exp_ToMonth { get; set; }

        [StringLength(255)]
        public string Exp_EmployerName { get; set; }

        [StringLength(255)]
        public string Exp_Department { get; set; }

        [StringLength(255)]
        public string Exp_EmployerPhone { get; set; }

        [StringLength(255)]
        public string Exp_WorkPlace { get; set; }

        [StringLength(255)]
        public string Exp_PositionTitle { get; set; }

        [StringLength(255)]
        public string Exp_Industry { get; set; }

        [Column(TypeName = "ntext")]
        public string Exp_Summary { get; set; }

        [Column(TypeName = "ntext")]
        public string Exp_Score { get; set; }

        public int? Pro_Count { get; set; }

        [StringLength(50)]
        public string Pro_FromYear { get; set; }

        [StringLength(50)]
        public string Pro_FromMonth { get; set; }

        [StringLength(50)]
        public string Pro_ToYear { get; set; }

        [StringLength(50)]
        public string Pro_ToMonth { get; set; }

        [StringLength(255)]
        public string Pro_ProjectName { get; set; }

        [Column(TypeName = "ntext")]
        public string Pro_Summary { get; set; }

        public int? Edu_Count { get; set; }

        [StringLength(50)]
        public string Edu_FromYear { get; set; }

        [StringLength(50)]
        public string Edu_FromMonth { get; set; }

        [StringLength(50)]
        public string Edu_ToYear { get; set; }

        [StringLength(50)]
        public string Edu_ToMonth { get; set; }

        [StringLength(255)]
        public string Edu_SchoolName { get; set; }

        [StringLength(255)]
        public string Edu_Education { get; set; }

        [StringLength(255)]
        public string Edu_Profession { get; set; }

        [Column(TypeName = "ntext")]
        public string Edu_Summary { get; set; }

        public int? Tra_Count { get; set; }

        [StringLength(50)]
        public string Tra_FromYear { get; set; }

        [StringLength(50)]
        public string Tra_FromMonth { get; set; }

        [StringLength(50)]
        public string Tra_ToYear { get; set; }

        [StringLength(50)]
        public string Tra_ToMonth { get; set; }

        [StringLength(255)]
        public string Tra_TrainerName { get; set; }

        [StringLength(255)]
        public string Tra_TrainerAddress { get; set; }

        [StringLength(255)]
        public string Tra_Lesson { get; set; }

        [StringLength(255)]
        public string Tra_Centification { get; set; }

        [StringLength(255)]
        public string Tra_Summary { get; set; }

        public int? Lan_Count { get; set; }

        [StringLength(255)]
        public string Lan_Language { get; set; }

        [StringLength(255)]
        public string Lan_Level { get; set; }

        public int? Ski_Count { get; set; }

        [StringLength(255)]
        public string Ski_SkillName { get; set; }

        [StringLength(255)]
        public string Ski_UsedTimes { get; set; }

        [StringLength(255)]
        public string Ski_Ability { get; set; }

        public int? Cer_Count { get; set; }

        [StringLength(255)]
        public string Cer_CertificationName { get; set; }

        [StringLength(255)]
        public string Cer_EffectiveDate { get; set; }
    }
}
