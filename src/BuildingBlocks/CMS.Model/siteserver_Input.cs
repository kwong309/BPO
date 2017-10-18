namespace CMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_Input
    {

        public siteserver_Input()
        {
            siteserver_InputContent = new HashSet<siteserver_InputContent>();
        }

        [Key]
        public int InputId { get; set; }

        [StringLength(50)]
        public string InputName { get; set; }

        public int? PublishmentSystemId { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        [StringLength(18)]
        public string IsReply { get; set; }

        public int? Taxis { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siteserver_InputContent> siteserver_InputContent { get; set; }
    }
}
