namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wcm_GovPublicCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string ClassCode { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        public int? ParentId { get; set; }

        [StringLength(255)]
        public string ParentsPath { get; set; }

        public int? ParentsCount { get; set; }

        public int? ChildrenCount { get; set; }

        [StringLength(18)]
        public string IsLastNode { get; set; }

        public int? Taxis { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        public int? ContentNum { get; set; }

        public virtual wcm_GovPublicCategoryClass wcm_GovPublicCategoryClass { get; set; }
    }
}
