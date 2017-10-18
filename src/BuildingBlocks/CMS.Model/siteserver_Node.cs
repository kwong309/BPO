namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_Node
    {
        [Key]
        public int NodeId { get; set; }

        [StringLength(255)]
        public string NodeName { get; set; }

        [StringLength(50)]
        public string NodeType { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string ContentModelId { get; set; }

        public int? ParentId { get; set; }

        [StringLength(255)]
        public string ParentsPath { get; set; }

        public int? ParentsCount { get; set; }

        public int? ChildrenCount { get; set; }

        [StringLength(18)]
        public string IsLastNode { get; set; }

        [StringLength(255)]
        public string NodeIndexName { get; set; }

        [StringLength(255)]
        public string NodeGroupNameCollection { get; set; }

        public int? Taxis { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public int? ContentNum { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(200)]
        public string ChannelFilePathRule { get; set; }

        [StringLength(200)]
        public string ContentFilePathRule { get; set; }

        [StringLength(200)]
        public string LinkUrl { get; set; }

        [StringLength(200)]
        public string LinkType { get; set; }

        public int? ChannelTemplateId { get; set; }

        public int? ContentTemplateId { get; set; }

        [StringLength(255)]
        public string Keywords { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string ExtendValues { get; set; }
    }
}
