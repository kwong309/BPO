namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_PermissionsInRoles
    {
        [Key]
        [StringLength(255)]
        public string RoleName { get; set; }

        [Column(TypeName = "text")]
        public string GeneralPermissions { get; set; }
    }
}
