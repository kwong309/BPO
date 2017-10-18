namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_Tags
    {
        [Key]
        public int TagId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string ContentIdCollection { get; set; }

        [StringLength(255)]
        public string Tag { get; set; }

        public int? UseNum { get; set; }
    }
}
