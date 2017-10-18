namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wcm_GovPublicIdentifierSeq
    {
        [Key]
        public int SeqId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? NodeId { get; set; }

        public int? DepartmentId { get; set; }

        public int? AddYear { get; set; }

        public int? Sequence { get; set; }
    }
}
