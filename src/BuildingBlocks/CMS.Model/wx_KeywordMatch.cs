namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_KeywordMatch
    {
        [Key]
        public int MatchId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string Keyword { get; set; }

        public int? KeywordId { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        [StringLength(50)]
        public string KeywordType { get; set; }

        [StringLength(50)]
        public string MatchType { get; set; }
    }
}
