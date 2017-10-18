namespace CMS.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_TableStyle
    {
        public bairong_TableStyle()
        {
            bairong_TableStyleItem = new HashSet<bairong_TableStyleItem>();
        }

        [Key]
        public int TableStyleId { get; set; }

        public int? RelatedIdentity { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string AttributeName { get; set; }

        public int? Taxis { get; set; }

        [StringLength(255)]
        public string DisplayName { get; set; }

        [StringLength(255)]
        public string HelpText { get; set; }

        [StringLength(18)]
        public string IsVisible { get; set; }

        [StringLength(18)]
        public string IsVisibleInList { get; set; }

        [StringLength(18)]
        public string IsSingleLine { get; set; }

        [StringLength(50)]
        public string InputType { get; set; }

        [StringLength(18)]
        public string IsRequired { get; set; }

        [StringLength(255)]
        public string DefaultValue { get; set; }

        [StringLength(18)]
        public string IsHorizontal { get; set; }

        [Column(TypeName = "ntext")]
        public string ExtendValues { get; set; }

        public virtual ICollection<bairong_TableStyleItem> bairong_TableStyleItem { get; set; }
    }
}
