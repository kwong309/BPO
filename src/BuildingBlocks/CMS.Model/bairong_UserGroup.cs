namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_UserGroup
    {
        [Key]
        public int GroupId { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        [StringLength(18)]
        public string IsDefault { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string ExtendValues { get; set; }
    }
}
