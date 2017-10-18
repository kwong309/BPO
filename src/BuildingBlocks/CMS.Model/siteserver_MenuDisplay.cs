namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_MenuDisplay
    {
        [Key]
        public int MenuDisplayId { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string MenuDisplayName { get; set; }

        [StringLength(50)]
        public string Vertical { get; set; }

        [StringLength(200)]
        public string FontFamily { get; set; }

        public int? FontSize { get; set; }

        [StringLength(50)]
        public string FontWeight { get; set; }

        [StringLength(50)]
        public string FontStyle { get; set; }

        [StringLength(50)]
        public string MenuItemHAlign { get; set; }

        [StringLength(50)]
        public string MenuItemVAlign { get; set; }

        [StringLength(50)]
        public string FontColor { get; set; }

        [StringLength(50)]
        public string MenuItemBgColor { get; set; }

        [StringLength(50)]
        public string FontColorHilite { get; set; }

        [StringLength(50)]
        public string MenuHiliteBgColor { get; set; }

        [StringLength(50)]
        public string XPosition { get; set; }

        [StringLength(50)]
        public string YPosition { get; set; }

        [StringLength(50)]
        public string HideOnMouseOut { get; set; }

        public int? MenuWidth { get; set; }

        public int? MenuItemHeight { get; set; }

        public int? MenuItemPadding { get; set; }

        public int? MenuItemSpacing { get; set; }

        public int? MenuItemIndent { get; set; }

        public int? HideTimeout { get; set; }

        [StringLength(50)]
        public string MenuBgOpaque { get; set; }

        public int? MenuBorder { get; set; }

        [StringLength(50)]
        public string BgColor { get; set; }

        [StringLength(50)]
        public string MenuBorderBgColor { get; set; }

        [StringLength(50)]
        public string MenuLiteBgColor { get; set; }

        [StringLength(200)]
        public string ChildMenuIcon { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(18)]
        public string IsDefault { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }
    }
}
