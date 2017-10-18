namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_StoreCategory
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public int? ParentId { get; set; }

        public int? Taxis { get; set; }

        public int? ChildCount { get; set; }

        public int? ParentsCount { get; set; }

        [StringLength(100)]
        public string ParentsPath { get; set; }

        public int? StoreCount { get; set; }

        [StringLength(18)]
        public string IsLastNode { get; set; }
    }
}
