namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_SigninSetting
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? NodeId { get; set; }

        public int? ContentId { get; set; }

        [StringLength(18)]
        public string IsGroup { get; set; }

        [StringLength(500)]
        public string UserGroupCollection { get; set; }

        [StringLength(500)]
        public string UserNameCollection { get; set; }

        public int? Priority { get; set; }

        [StringLength(50)]
        public string EndDate { get; set; }

        [StringLength(18)]
        public string IsSignin { get; set; }

        public DateTime? SigninDate { get; set; }
    }
}
