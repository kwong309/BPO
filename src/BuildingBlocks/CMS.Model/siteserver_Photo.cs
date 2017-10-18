namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Photo
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(200)]
        public string SmallUrl { get; set; }

        [StringLength(200)]
        public string MiddleUrl { get; set; }

        [StringLength(200)]
        public string LargeUrl { get; set; }

        public int? Taxis { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
