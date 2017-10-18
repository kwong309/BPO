namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_SigninUserContentId
    {
        public int Id { get; set; }

        [StringLength(18)]
        public string IsGroup { get; set; }

        public int? GroupId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public int? PublishmentSystemId { get; set; }

        public int? NodeId { get; set; }

        [StringLength(500)]
        public string ContentIdCollection { get; set; }
    }
}
