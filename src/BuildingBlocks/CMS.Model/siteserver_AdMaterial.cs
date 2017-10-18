namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_AdMaterial
    {
        [Key]
        public int AdMaterialId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int AdvId { get; set; }

        public int? AdvertId { get; set; }

        [StringLength(50)]
        public string AdMaterialName { get; set; }

        [StringLength(50)]
        public string AdMaterialType { get; set; }

        [Column(TypeName = "ntext")]
        public string Code { get; set; }

        [StringLength(255)]
        public string TextWord { get; set; }

        [StringLength(200)]
        public string TextLink { get; set; }

        [StringLength(10)]
        public string TextColor { get; set; }

        public int? TextFontSize { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string ImageLink { get; set; }

        public int? ImageWidth { get; set; }

        public int? ImageHeight { get; set; }

        [StringLength(50)]
        public string ImageAlt { get; set; }

        public int? Weight { get; set; }

        [StringLength(18)]
        public string IsEnabled { get; set; }

        public virtual siteserver_Adv siteserver_Adv { get; set; }
    }
}
