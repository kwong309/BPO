namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_Count
    {
        [Key]
        public int CountId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? CountYear { get; set; }

        public int? CountMonth { get; set; }

        public int? CountDay { get; set; }

        [StringLength(50)]
        public string CountType { get; set; }

        public int? Count { get; set; }
    }
}
