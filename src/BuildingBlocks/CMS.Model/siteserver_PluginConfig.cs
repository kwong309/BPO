namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_PluginConfig
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string PluginId { get; set; }

        public int? SiteId { get; set; }

        [StringLength(200)]
        public string ConfigName { get; set; }

        [Column(TypeName = "ntext")]
        public string ConfigValue { get; set; }
    }
}
