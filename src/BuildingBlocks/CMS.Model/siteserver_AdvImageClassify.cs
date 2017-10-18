namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_AdvImageClassify
    {
        [Key]
        public int ItemId { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string ItemIndexName { get; set; }

        public int? ParentId { get; set; }

        [StringLength(255)]
        public string ParentsPath { get; set; }

        public int? ParentsCount { get; set; }

        public int? ChildrenCount { get; set; }

        public int? ContentNum { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(18)]
        public string Enabled { get; set; }

        [StringLength(18)]
        public string IsLastItem { get; set; }

        public int? Taxis { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
