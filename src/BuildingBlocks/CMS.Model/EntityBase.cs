using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Model
{
    public class EntityBase
    {
        [Key]
        [Required]
        [Display(Name = "本表数据编号")]
        [StringLength(50)]
        public string guid { get; set; }
        public DateTime CreatedTime { get; set; }
        [StringLength(50)]
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
        public string ParentId { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
