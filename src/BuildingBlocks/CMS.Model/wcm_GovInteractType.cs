namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wcm_GovInteractType
    {
        [Key]
        public int TypeId { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        public int NodeId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? Taxis { get; set; }

        public virtual wcm_GovInteractChannel wcm_GovInteractChannel { get; set; }
    }
}
