namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_InputContent
    {
        public int Id { get; set; }

        public int InputId { get; set; }

        public int? Taxis { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        public DateTime? AddDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Reply { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }

        public virtual siteserver_Input siteserver_Input { get; set; }
    }
}
