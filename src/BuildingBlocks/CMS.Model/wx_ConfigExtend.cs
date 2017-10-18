namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_ConfigExtend
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string KeywordType { get; set; }

        public int? FunctionId { get; set; }

        [StringLength(50)]
        public string AttributeName { get; set; }

        [StringLength(18)]
        public string IsVisible { get; set; }
    }
}
