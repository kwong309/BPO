namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_VoteOption
    {
        [Key]
        public int OptionId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? NodeId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string NavigationUrl { get; set; }

        public int? VoteNum { get; set; }
    }
}
