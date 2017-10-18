namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_TableStyleItem
    {
        [Key]
        public int TableStyleItemId { get; set; }

        public int TableStyleId { get; set; }

        [StringLength(255)]
        public string ItemTitle { get; set; }

        [StringLength(255)]
        public string ItemValue { get; set; }

        [StringLength(18)]
        public string IsSelected { get; set; }

        public virtual bairong_TableStyle bairong_TableStyle { get; set; }
    }
}
