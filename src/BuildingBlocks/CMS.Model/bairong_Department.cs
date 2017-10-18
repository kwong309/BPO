namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

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

        public int? CountOfAdmin { get; set; }
    }
}
