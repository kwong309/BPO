namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_CollectItem
    {
        public int Id { get; set; }

        public int? CollectId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(200)]
        public string SmallUrl { get; set; }

        [StringLength(200)]
        public string LargeUrl { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(200)]
        public string Mobile { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        public int? VoteNum { get; set; }
    }
}
