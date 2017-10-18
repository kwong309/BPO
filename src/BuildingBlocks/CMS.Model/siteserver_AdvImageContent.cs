namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_AdvImageContent
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? Taxis { get; set; }

        [StringLength(18)]
        public string IsChecked { get; set; }

        [StringLength(50)]
        public string AddUser { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(50)]
        public string LaseEditUser { get; set; }

        public DateTime? LastEditDate { get; set; }

        [Column(TypeName = "ntext")]
        public string SettingsXml { get; set; }

        [StringLength(50)]
        public string AdvImageName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? ClassifyId { get; set; }

        [StringLength(500)]
        public string AdvImagePath { get; set; }
    }
}
