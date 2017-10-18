namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_AlbumContent
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? AlbumId { get; set; }

        public int? ParentId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string LargeImageUrl { get; set; }
    }
}
