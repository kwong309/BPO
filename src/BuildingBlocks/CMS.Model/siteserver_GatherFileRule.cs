namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_GatherFileRule
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string GatherRuleName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string GatherUrl { get; set; }

        [StringLength(50)]
        public string Charset { get; set; }

        public DateTime? LastGatherDate { get; set; }

        [StringLength(18)]
        public string IsToFile { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; }

        [StringLength(18)]
        public string IsSaveRelatedFiles { get; set; }

        [StringLength(18)]
        public string IsRemoveScripts { get; set; }

        [StringLength(255)]
        public string StyleDirectoryPath { get; set; }

        [StringLength(255)]
        public string ScriptDirectoryPath { get; set; }

        [StringLength(255)]
        public string ImageDirectoryPath { get; set; }

        public int? NodeId { get; set; }

        [StringLength(18)]
        public string IsSaveImage { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        [StringLength(18)]
        public string IsAutoCreate { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentExclude { get; set; }

        [StringLength(255)]
        public string ContentHtmlClearCollection { get; set; }

        [StringLength(255)]
        public string ContentHtmlClearTagCollection { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentTitleStart { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentTitleEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentContentStart { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentContentEnd { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentAttributes { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentAttributesXml { get; set; }
    }
}
