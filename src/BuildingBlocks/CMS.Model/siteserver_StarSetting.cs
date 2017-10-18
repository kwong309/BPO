namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_StarSetting
    {
        [Key]
        public int StarSettingId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? ChannelId { get; set; }

        public int? ContentId { get; set; }

        public int? TotalCount { get; set; }

        public decimal? PointAverage { get; set; }
    }
}
