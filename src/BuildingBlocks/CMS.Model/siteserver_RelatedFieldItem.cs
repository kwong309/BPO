namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_RelatedFieldItem
    {
        public int Id { get; set; }

        public int RelatedFieldId { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        [StringLength(255)]
        public string ItemValue { get; set; }

        public int? ParentId { get; set; }

        public int? Taxis { get; set; }

        public virtual siteserver_RelatedField siteserver_RelatedField { get; set; }
    }
}
