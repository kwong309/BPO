namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_StoreItem
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? StoreId { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(255)]
        public string StoreName { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(11)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Longitude { get; set; }

        [StringLength(100)]
        public string Latitude { get; set; }

        [Column(TypeName = "ntext")]
        public string Summary { get; set; }
    }
}
