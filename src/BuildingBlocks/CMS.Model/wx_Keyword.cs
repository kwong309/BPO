namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_Keyword
    {
        [Key]
        public int KeywordId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string Keywords { get; set; }

        [StringLength(18)]
        public string IsDisabled { get; set; }

        [StringLength(50)]
        public string KeywordType { get; set; }

        [StringLength(50)]
        public string MatchType { get; set; }

        [Column(TypeName = "ntext")]
        public string Reply { get; set; }

        public DateTime? AddDate { get; set; }

        public int? Taxis { get; set; }
    }
}
