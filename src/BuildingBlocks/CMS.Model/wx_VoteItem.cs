namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_VoteItem
    {
        public int Id { get; set; }

        public int? VoteId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string NavigationUrl { get; set; }

        public int? VoteNum { get; set; }
    }
}
