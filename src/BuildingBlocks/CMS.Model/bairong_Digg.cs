namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_Digg
    {
        [Key]
        public int DiggId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? RelatedIdentity { get; set; }

        public int? Good { get; set; }

        public int? Bad { get; set; }
    }
}
