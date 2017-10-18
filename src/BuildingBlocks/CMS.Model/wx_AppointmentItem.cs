namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_AppointmentItem
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? AppointmentId { get; set; }

        public int? UserCount { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string TopImageUrl { get; set; }

        [StringLength(18)]
        public string IsDescription { get; set; }

        [StringLength(255)]
        public string DescriptionTitle { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(18)]
        public string IsImageUrl { get; set; }

        [StringLength(255)]
        public string ImageUrlTitle { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(18)]
        public string IsVideoUrl { get; set; }

        [StringLength(255)]
        public string VideoUrlTitle { get; set; }

        [StringLength(200)]
        public string VideoUrl { get; set; }

        [StringLength(18)]
        public string IsImageUrlCollection { get; set; }

        [StringLength(255)]
        public string ImageUrlCollectionTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string ImageUrlCollection { get; set; }

        [Column(TypeName = "ntext")]
        public string LargeImageUrlCollection { get; set; }

        [StringLength(18)]
        public string IsMap { get; set; }

        [StringLength(255)]
        public string MapTitle { get; set; }

        [StringLength(255)]
        public string MapAddress { get; set; }

        [StringLength(18)]
        public string IsTel { get; set; }

        [StringLength(255)]
        public string TelTitle { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }
    }
}
