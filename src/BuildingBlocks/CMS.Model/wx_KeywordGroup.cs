namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_KeywordGroup
    {
        [Key]
        public int GroupId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string GroupName { get; set; }

        public int? Taxis { get; set; }
    }
}
