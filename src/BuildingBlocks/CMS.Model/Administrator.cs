namespace CMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Administrator:EntityBase
    {
        public Administrator()
        {
        }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(128)]
        public string PasswordSalt { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public int? CountOfLogin { get; set; }

        public int? CountOfFailedLogin { get; set; }

        [StringLength(255)]
        public string CreatorUserName { get; set; }

        [StringLength(18)]
        public string IsLockedOut { get; set; }

        [StringLength(50)]
        public string PublishmentSystemIdCollection { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }
    }
}
