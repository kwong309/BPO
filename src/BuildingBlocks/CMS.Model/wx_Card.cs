namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_Card
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? KeywordId { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        public int? UserCount { get; set; }

        public int? PvCount { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(255)]
        public string CardTitle { get; set; }

        [StringLength(50)]
        public string CardTitleColor { get; set; }

        [StringLength(50)]
        public string CardNoColor { get; set; }

        [StringLength(200)]
        public string ContentFrontImageUrl { get; set; }

        [StringLength(200)]
        public string ContentBackImageUrl { get; set; }

        [StringLength(255)]
        public string ShopName { get; set; }

        [StringLength(255)]
        public string ShopAddress { get; set; }

        [StringLength(255)]
        public string ShopTel { get; set; }

        [StringLength(200)]
        public string ShopPosition { get; set; }

        [StringLength(200)]
        public string ShopPassword { get; set; }

        [Column(TypeName = "ntext")]
        public string ShopOperatorList { get; set; }
    }
}
