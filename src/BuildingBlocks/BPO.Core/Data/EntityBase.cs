using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPO.Model
{
    public class EntityBase
    {
        [Key]
        [Required]
        [Display(Name = "本表数据编号")]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [DataType(DataType.Text)]
        public string guid { get; set; }
        public DateTime CreatedTime { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string CreatedUser { get; set; }
        public EntityBase()
        {
            if (this.CreatedTime == DateTime.MinValue)
            {
                this.CreatedTime = DateTime.Now;
            }
        }
        public void NewId()
        {
            this.guid = Guid.NewGuid().ToString();
            this.CreatedTime = DateTime.Now;
        }
 
    }
    public class TreeEntity : EntityBase
    {
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string ParentId { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Required]
        [Keyword]
        public string Name { get; set; }
    }
}
