namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_TableMatch
    {
        [Key]
        public int TableMatchId { get; set; }

        [StringLength(200)]
        public string ConnectionString { get; set; }

        [StringLength(200)]
        public string TableName { get; set; }

        [StringLength(200)]
        public string ConnectionStringToMatch { get; set; }

        [StringLength(200)]
        public string TableNameToMatch { get; set; }

        [Column(TypeName = "ntext")]
        public string ColumnsMap { get; set; }
    }
}
