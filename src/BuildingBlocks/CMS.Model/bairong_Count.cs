namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_Count
    {
        [Key]
        public int CountId { get; set; }

        [StringLength(255)]
        public string RelatedTableName { get; set; }

        [StringLength(255)]
        public string RelatedIdentity { get; set; }

        [StringLength(50)]
        public string CountType { get; set; }

        public int? CountNum { get; set; }
    }
}
