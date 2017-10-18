namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_SeoMeta
    {
        [Key]
        public int SeoMetaId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string SeoMetaName { get; set; }

        [StringLength(18)]
        public string IsDefault { get; set; }

        [StringLength(80)]
        public string PageTitle { get; set; }

        [StringLength(100)]
        public string Keywords { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Copyright { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(50)]
        public string Charset { get; set; }

        [StringLength(50)]
        public string Distribution { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        [StringLength(50)]
        public string Robots { get; set; }

        [StringLength(50)]
        public string RevisitAfter { get; set; }

        [StringLength(50)]
        public string Expires { get; set; }
    }
}
