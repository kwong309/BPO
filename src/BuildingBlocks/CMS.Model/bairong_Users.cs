namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_Users
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(50)]
        public string PasswordFormat { get; set; }

        [StringLength(128)]
        public string PasswordSalt { get; set; }

        public int? GroupId { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastResetPasswordDate { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public int? CountOfLogin { get; set; }

        public int? CountOfFailedLogin { get; set; }

        public int? CountOfWriting { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        [StringLength(18)]
        public string IsLockedOut { get; set; }

        [StringLength(255)]
        public string DisplayName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string AvatarUrl { get; set; }

        [StringLength(255)]
        public string Organization { get; set; }

        [StringLength(255)]
        public string Department { get; set; }

        [StringLength(255)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(255)]
        public string Education { get; set; }

        [StringLength(255)]
        public string Graduation { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string WeiXin { get; set; }

        [StringLength(50)]
        public string Qq { get; set; }

        [StringLength(255)]
        public string WeiBo { get; set; }

        [StringLength(255)]
        public string Interests { get; set; }

        [StringLength(255)]
        public string Signature { get; set; }

        [Column(TypeName = "ntext")]
        public string ExtendValues { get; set; }
    }
}
