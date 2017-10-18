namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Keyword
    {
        [Key]
        public int KeywordId { get; set; }

        [StringLength(50)]
        public string Keyword { get; set; }

        [StringLength(50)]
        public string Alternative { get; set; }

        [StringLength(50)]
        public string Grade { get; set; }
    }
}
