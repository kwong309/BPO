namespace CMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_AdArea
    {
        public siteserver_AdArea()
        {
            siteserver_Adv = new HashSet<siteserver_Adv>();
        }

        [Key]
        public int AdAreaId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string AdAreaName { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(18)]
        public string IsEnabled { get; set; }

        public DateTime? AddDate { get; set; }

        public virtual ICollection<siteserver_Adv> siteserver_Adv { get; set; }
    }
}
