namespace CMS.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_Roles
    {
        public bairong_Roles()
        {
            bairong_Administrator = new HashSet<Administrator>();
        }

        [Key]
        [StringLength(255)]
        public string RoleName { get; set; }

        [StringLength(255)]
        public string CreatorUserName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public virtual ICollection<Administrator> bairong_Administrator { get; set; }
    }
}
