namespace CMS.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class wx_Account
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(200)]
        public string Token { get; set; }

        [StringLength(18)]
        public string IsBinding { get; set; }

        [StringLength(50)]
        public string AccountType { get; set; }

        [StringLength(255)]
        public string WeChatId { get; set; }

        [StringLength(200)]
        public string SourceId { get; set; }

        [StringLength(200)]
        public string ThumbUrl { get; set; }

        [StringLength(200)]
        public string AppId { get; set; }

        [StringLength(200)]
        public string AppSecret { get; set; }

        [StringLength(18)]
        public string IsWelcome { get; set; }

        [StringLength(50)]
        public string WelcomeKeyword { get; set; }

        [StringLength(18)]
        public string IsDefaultReply { get; set; }

        [StringLength(50)]
        public string DefaultReplyKeyword { get; set; }
    }
}
