namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_Wifi
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? KeywordId { get; set; }

        public int? PvCount { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(100)]
        public string BusinessId { get; set; }

        [Column(TypeName = "ntext")]
        public string CallBackString { get; set; }
    }
}
