namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_ThirdLogin
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ThirdLoginType { get; set; }

        [StringLength(50)]
        public string ThirdLoginName { get; set; }

        [StringLength(18)]
        public string IsEnabled { get; set; }

        public int? Taxis { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }
    }
}
