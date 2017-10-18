namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_Advertisement
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string AdvertisementName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string AdvertisementType { get; set; }

        [StringLength(200)]
        public string NavigationUrl { get; set; }

        [StringLength(18)]
        public string IsDateLimited { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string NodeIdCollectionToChannel { get; set; }

        [StringLength(255)]
        public string NodeIdCollectionToContent { get; set; }

        [StringLength(255)]
        public string FileTemplateIdCollection { get; set; }

        [Column(TypeName = "ntext")]
        public string Settings { get; set; }
    }
}
