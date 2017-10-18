namespace CMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_Adv
    {
        public siteserver_Adv()
        {
            siteserver_AdMaterial = new HashSet<siteserver_AdMaterial>();
        }

        [Key]
        public int AdvId { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int AdAreaId { get; set; }

        [StringLength(50)]
        public string AdvName { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [StringLength(18)]
        public string IsEnabled { get; set; }

        [StringLength(18)]
        public string IsDateLimited { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string LevelType { get; set; }

        public int? Level { get; set; }

        [StringLength(18)]
        public string IsWeight { get; set; }

        public int? Weight { get; set; }

        [StringLength(50)]
        public string RotateType { get; set; }

        public int? RotateInterval { get; set; }

        [StringLength(4000)]
        public string NodeIdCollectionToChannel { get; set; }

        [StringLength(4000)]
        public string NodeIdCollectionToContent { get; set; }

        [StringLength(4000)]
        public string FileTemplateIdCollection { get; set; }

        public virtual siteserver_AdArea siteserver_AdArea { get; set; }
        public virtual ICollection<siteserver_AdMaterial> siteserver_AdMaterial { get; set; }
    }
}
