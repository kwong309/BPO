namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_GatherRule
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string GatherRuleName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [Column(TypeName = "text")]
        public string CookieString { get; set; }

        [StringLength(18)]
        public string GatherUrlIsCollection { get; set; }

        [Column(TypeName = "text")]
        public string GatherUrlCollection { get; set; }

        [StringLength(18)]
        public string GatherUrlIsSerialize { get; set; }

        [StringLength(200)]
        public string GatherUrlSerialize { get; set; }

        public int? SerializeFrom { get; set; }

        public int? SerializeTo { get; set; }

        public int? SerializeInterval { get; set; }

        [StringLength(18)]
        public string SerializeIsOrderByDesc { get; set; }

        [StringLength(18)]
        public string SerializeIsAddZero { get; set; }

        public int? NodeId { get; set; }

        [StringLength(50)]
        public string Charset { get; set; }

        [StringLength(200)]
        public string UrlInclude { get; set; }

        [StringLength(255)]
        public string TitleInclude { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentExclude { get; set; }

        [StringLength(255)]
        public string ContentHtmlClearCollection { get; set; }

        [StringLength(255)]
        public string ContentHtmlClearTagCollection { get; set; }

        public DateTime? LastGatherDate { get; set; }

        [Column(TypeName = "ntext")]
        public string ListAreaStart { get; set; }

        [Column(TypeName = "ntext")]
        public string ListAreaEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentChannelStart { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentChannelEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentTitleStart { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentTitleEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentContentStart { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentContentEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentNextPageStart { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentNextPageEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentAttributes { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentAttributesXml { get; set; }

        [Column(TypeName = "ntext")]
        public string ExtendValues { get; set; }
    }
}
