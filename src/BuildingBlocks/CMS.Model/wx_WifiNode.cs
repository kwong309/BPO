namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class wx_WifiNode
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(100)]
        public string BusinessId { get; set; }

        [StringLength(100)]
        public string NodeId { get; set; }

        [Column(TypeName = "ntext")]
        public string CallBackString { get; set; }
    }
}
