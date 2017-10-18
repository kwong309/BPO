using CMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.MVC.Data
{
 
    public class CMSDB: DbContext
    {
        public CMSDB(DbContextOptions<CMSDB> options)
            : base(options)
        {
            this.Database.Migrate();
        }
        public virtual DbSet<Administrator> bairong_Administrator { get; set; }
        //public virtual DbSet<bairong_Area> bairong_Area { get; set; }
        //public virtual DbSet<bairong_ContentCheck> bairong_ContentCheck { get; set; }
        public virtual DbSet<bairong_ContentModel> bairong_ContentModel { get; set; }
        public virtual DbSet<bairong_Count> bairong_Count { get; set; }
        public virtual DbSet<bairong_DbCache> bairong_DbCache { get; set; }
        public virtual DbSet<bairong_Department> bairong_Department { get; set; }
        public virtual DbSet<bairong_Digg> bairong_Digg { get; set; }
        public virtual DbSet<bairong_ErrorLog> bairong_ErrorLog { get; set; }
        public virtual DbSet<bairong_Log> bairong_Log { get; set; }
        public virtual DbSet<bairong_PermissionsInRoles> bairong_PermissionsInRoles { get; set; }
        public virtual DbSet<bairong_Roles> bairong_Roles { get; set; }
        public virtual DbSet<bairong_TableCollection> bairong_TableCollection { get; set; }
        public virtual DbSet<bairong_TableMatch> bairong_TableMatch { get; set; }
        public virtual DbSet<bairong_TableMetadata> bairong_TableMetadata { get; set; }
        public virtual DbSet<bairong_TableStyle> bairong_TableStyle { get; set; }
        public virtual DbSet<bairong_TableStyleItem> bairong_TableStyleItem { get; set; }
        public virtual DbSet<bairong_Tags> bairong_Tags { get; set; }
        public virtual DbSet<bairong_ThirdLogin> bairong_ThirdLogin { get; set; }
        public virtual DbSet<bairong_UserBinding> bairong_UserBinding { get; set; }
        public virtual DbSet<bairong_UserGroup> bairong_UserGroup { get; set; }
        public virtual DbSet<bairong_UserLog> bairong_UserLog { get; set; }
        public virtual DbSet<bairong_Users> bairong_Users { get; set; }
        public virtual DbSet<model_Content> model_Content { get; set; }
        public virtual DbSet<model_Job> model_Job { get; set; }
        public virtual DbSet<model_Vote> model_Vote { get; set; }
        public virtual DbSet<model_WCM_GovInteract> model_WCM_GovInteract { get; set; }
        public virtual DbSet<model_WCM_GovPublic> model_WCM_GovPublic { get; set; }
        public virtual DbSet<siteserver_AdArea> siteserver_AdArea { get; set; }
        public virtual DbSet<siteserver_AdMaterial> siteserver_AdMaterial { get; set; }
        public virtual DbSet<siteserver_Adv> siteserver_Adv { get; set; }
        public virtual DbSet<siteserver_Advertisement> siteserver_Advertisement { get; set; }
        public virtual DbSet<siteserver_AdvImageClassify> siteserver_AdvImageClassify { get; set; }
        public virtual DbSet<siteserver_AdvImageContent> siteserver_AdvImageContent { get; set; }
        public virtual DbSet<siteserver_Comment> siteserver_Comment { get; set; }
        public virtual DbSet<siteserver_ContentGroup> siteserver_ContentGroup { get; set; }
        public virtual DbSet<siteserver_CreateTask> siteserver_CreateTask { get; set; }
        public virtual DbSet<siteserver_CreateTaskLog> siteserver_CreateTaskLog { get; set; }
        public virtual DbSet<siteserver_GatherDatabaseRule> siteserver_GatherDatabaseRule { get; set; }
        public virtual DbSet<siteserver_GatherFileRule> siteserver_GatherFileRule { get; set; }
        public virtual DbSet<siteserver_GatherRule> siteserver_GatherRule { get; set; }
        public virtual DbSet<siteserver_InnerLink> siteserver_InnerLink { get; set; }
        public virtual DbSet<siteserver_Input> siteserver_Input { get; set; }
        public virtual DbSet<siteserver_InputContent> siteserver_InputContent { get; set; }
        public virtual DbSet<siteserver_Keyword> siteserver_Keyword { get; set; }
        public virtual DbSet<siteserver_Log> siteserver_Log { get; set; }
        public virtual DbSet<siteserver_MenuDisplay> siteserver_MenuDisplay { get; set; }
        public virtual DbSet<siteserver_Node> siteserver_Node { get; set; }
        public virtual DbSet<siteserver_NodeGroup> siteserver_NodeGroup { get; set; }
        public virtual DbSet<siteserver_Photo> siteserver_Photo { get; set; }
        public virtual DbSet<siteserver_PluginConfig> siteserver_PluginConfig { get; set; }
        public virtual DbSet<siteserver_PublishmentSystem> siteserver_PublishmentSystem { get; set; }
        public virtual DbSet<siteserver_RelatedField> siteserver_RelatedField { get; set; }
        public virtual DbSet<siteserver_RelatedFieldItem> siteserver_RelatedFieldItem { get; set; }
        public virtual DbSet<siteserver_ResumeContent> siteserver_ResumeContent { get; set; }
        public virtual DbSet<siteserver_SeoMeta> siteserver_SeoMeta { get; set; }
        public virtual DbSet<siteserver_SeoMetasInNodes> siteserver_SeoMetasInNodes { get; set; }
        public virtual DbSet<siteserver_SigninLog> siteserver_SigninLog { get; set; }
        public virtual DbSet<siteserver_SigninSetting> siteserver_SigninSetting { get; set; }
        public virtual DbSet<siteserver_SigninUserContentId> siteserver_SigninUserContentId { get; set; }
        public virtual DbSet<siteserver_Star> siteserver_Star { get; set; }
        public virtual DbSet<siteserver_StarSetting> siteserver_StarSetting { get; set; }
        public virtual DbSet<siteserver_StlTag> siteserver_StlTag { get; set; }
        public virtual DbSet<siteserver_SystemPermissions> siteserver_SystemPermissions { get; set; }
        public virtual DbSet<siteserver_TagStyle> siteserver_TagStyle { get; set; }
        public virtual DbSet<siteserver_Task> siteserver_Task { get; set; }
        public virtual DbSet<siteserver_TaskLog> siteserver_TaskLog { get; set; }
        public virtual DbSet<siteserver_Template> siteserver_Template { get; set; }
        public virtual DbSet<siteserver_TemplateLog> siteserver_TemplateLog { get; set; }
        public virtual DbSet<siteserver_TemplateMatch> siteserver_TemplateMatch { get; set; }
        public virtual DbSet<siteserver_Tracking> siteserver_Tracking { get; set; }
        public virtual DbSet<siteserver_VoteOperation> siteserver_VoteOperation { get; set; }
        public virtual DbSet<siteserver_VoteOption> siteserver_VoteOption { get; set; }
        public virtual DbSet<wcm_GovInteractChannel> wcm_GovInteractChannel { get; set; }
        public virtual DbSet<wcm_GovInteractLog> wcm_GovInteractLog { get; set; }
        public virtual DbSet<wcm_GovInteractPermissions> wcm_GovInteractPermissions { get; set; }
        public virtual DbSet<wcm_GovInteractRemark> wcm_GovInteractRemark { get; set; }
        public virtual DbSet<wcm_GovInteractReply> wcm_GovInteractReply { get; set; }
        public virtual DbSet<wcm_GovInteractType> wcm_GovInteractType { get; set; }
        public virtual DbSet<wcm_GovPublicApply> wcm_GovPublicApply { get; set; }
        public virtual DbSet<wcm_GovPublicApplyLog> wcm_GovPublicApplyLog { get; set; }
        public virtual DbSet<wcm_GovPublicApplyRemark> wcm_GovPublicApplyRemark { get; set; }
        public virtual DbSet<wcm_GovPublicApplyReply> wcm_GovPublicApplyReply { get; set; }
        public virtual DbSet<wcm_GovPublicCategory> wcm_GovPublicCategory { get; set; }
        public virtual DbSet<wcm_GovPublicCategoryClass> wcm_GovPublicCategoryClass { get; set; }
        public virtual DbSet<wcm_GovPublicChannel> wcm_GovPublicChannel { get; set; }
        public virtual DbSet<wcm_GovPublicIdentifierRule> wcm_GovPublicIdentifierRule { get; set; }
        public virtual DbSet<wcm_GovPublicIdentifierSeq> wcm_GovPublicIdentifierSeq { get; set; }
        public virtual DbSet<wx_Account> wx_Account { get; set; }
        public virtual DbSet<wx_Album> wx_Album { get; set; }
        public virtual DbSet<wx_AlbumContent> wx_AlbumContent { get; set; }
        public virtual DbSet<wx_Appointment> wx_Appointment { get; set; }
        public virtual DbSet<wx_AppointmentContent> wx_AppointmentContent { get; set; }
        public virtual DbSet<wx_AppointmentItem> wx_AppointmentItem { get; set; }
        public virtual DbSet<wx_Card> wx_Card { get; set; }
        public virtual DbSet<wx_CardCashLog> wx_CardCashLog { get; set; }
        public virtual DbSet<wx_CardEntitySn> wx_CardEntitySn { get; set; }
        public virtual DbSet<wx_CardSignLog> wx_CardSignLog { get; set; }
        public virtual DbSet<wx_CardSn> wx_CardSn { get; set; }
        public virtual DbSet<wx_Collect> wx_Collect { get; set; }
        public virtual DbSet<wx_CollectItem> wx_CollectItem { get; set; }
        public virtual DbSet<wx_CollectLog> wx_CollectLog { get; set; }
        public virtual DbSet<wx_Conference> wx_Conference { get; set; }
        public virtual DbSet<wx_ConferenceContent> wx_ConferenceContent { get; set; }
        public virtual DbSet<wx_ConfigExtend> wx_ConfigExtend { get; set; }
        public virtual DbSet<wx_Count> wx_Count { get; set; }
        public virtual DbSet<wx_Coupon> wx_Coupon { get; set; }
        public virtual DbSet<wx_CouponAct> wx_CouponAct { get; set; }
        public virtual DbSet<wx_CouponSn> wx_CouponSn { get; set; }
        public virtual DbSet<wx_Keyword> wx_Keyword { get; set; }
        public virtual DbSet<wx_KeywordGroup> wx_KeywordGroup { get; set; }
        public virtual DbSet<wx_KeywordMatch> wx_KeywordMatch { get; set; }
        public virtual DbSet<wx_KeywordResource> wx_KeywordResource { get; set; }
        public virtual DbSet<wx_Lottery> wx_Lottery { get; set; }
        public virtual DbSet<wx_LotteryAward> wx_LotteryAward { get; set; }
        public virtual DbSet<wx_LotteryLog> wx_LotteryLog { get; set; }
        public virtual DbSet<wx_LotteryWinner> wx_LotteryWinner { get; set; }
        public virtual DbSet<wx_Map> wx_Map { get; set; }
        public virtual DbSet<wx_Menu> wx_Menu { get; set; }
        public virtual DbSet<wx_Message> wx_Message { get; set; }
        public virtual DbSet<wx_MessageContent> wx_MessageContent { get; set; }
        public virtual DbSet<wx_Search> wx_Search { get; set; }
        public virtual DbSet<wx_SearchNavigation> wx_SearchNavigation { get; set; }
        public virtual DbSet<wx_Store> wx_Store { get; set; }
        public virtual DbSet<wx_StoreCategory> wx_StoreCategory { get; set; }
        public virtual DbSet<wx_StoreItem> wx_StoreItem { get; set; }
        public virtual DbSet<wx_View360> wx_View360 { get; set; }
        public virtual DbSet<wx_Vote> wx_Vote { get; set; }
        public virtual DbSet<wx_VoteItem> wx_VoteItem { get; set; }
        public virtual DbSet<wx_VoteLog> wx_VoteLog { get; set; }
        public virtual DbSet<wx_WebMenu> wx_WebMenu { get; set; }
        public virtual DbSet<wx_Wifi> wx_Wifi { get; set; }
        public virtual DbSet<wx_WifiNode> wx_WifiNode { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<siteserver_ContentGroup>().HasKey(e => new { e.ContentGroupName, e.PublishmentSystemId });
            modelBuilder.Entity<siteserver_GatherDatabaseRule>().HasKey(e => new { e.GatherRuleName, e.PublishmentSystemId });
            modelBuilder.Entity<siteserver_GatherFileRule>().HasKey(e => new { e.GatherRuleName, e.PublishmentSystemId });
            modelBuilder.Entity<siteserver_GatherRule>().HasKey(e => new { e.GatherRuleName, e.PublishmentSystemId });

            modelBuilder.Entity<siteserver_NodeGroup>().HasKey(e => new { e.NodeGroupName, e.PublishmentSystemId });

            modelBuilder.Entity<siteserver_InnerLink>().HasKey(e => new { e.InnerLinkName, e.PublishmentSystemId });

            modelBuilder.Entity<siteserver_SeoMetasInNodes>().HasKey(e => new { e.NodeId, e.IsChannel });
            modelBuilder.Entity<siteserver_StlTag>().HasKey(e => new { e.TagName, e.PublishmentSystemId });


            modelBuilder.Entity<siteserver_SystemPermissions>().HasKey(e => new { e.RoleName, e.PublishmentSystemId });

            modelBuilder.Entity<wcm_GovInteractPermissions>().HasKey(e => new { e.NodeId, e.UserName });
            modelBuilder.Entity<wcm_GovPublicCategoryClass>().HasKey(e => new { e.ClassCode, e.PublishmentSystemId });
            //modelBuilder.Entity<Administrator>()
            //    .Property(e => e.PasswordFormat)
            //    .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.IsLockedOut)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.PublishmentSystemIdCollection)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            //modelBuilder.Entity<Administrator>()
            //    .HasMany(e => e.bairong_Roles)
            //    .WithOne()
            //    .HasForeignKey(m => m.RoleName);

            //modelBuilder.Entity<bairong_Area>()
            //    .Property(e => e.IsLastNode)
            //    .IsUnicode(false);

            //modelBuilder.Entity<bairong_ContentCheck>()
            //    .Property(e => e.TableName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<bairong_ContentCheck>()
            //    .Property(e => e.IsAdmin)
            //    .IsUnicode(false);

            //modelBuilder.Entity<bairong_ContentCheck>()
            //    .Property(e => e.IsChecked)
            //    .IsUnicode(false);
            modelBuilder.Entity<bairong_ContentModel>().HasKey(e => new { e.ModelId, e.SiteId });
        
            modelBuilder.Entity<bairong_ContentModel>()
                .Property(e => e.ModelId)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_ContentModel>()
                .Property(e => e.IsSystem)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_ContentModel>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_ContentModel>()
                .Property(e => e.TableType)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_ContentModel>()
                .Property(e => e.IconUrl)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Count>()
                .Property(e => e.CountType)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_DbCache>()
                .Property(e => e.CacheKey)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Department>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Department>()
                .Property(e => e.IsLastNode)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Log>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Log>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_PermissionsInRoles>()
                .Property(e => e.GeneralPermissions)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableCollection>()
                .Property(e => e.TableEnName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableCollection>()
                .Property(e => e.AuxiliaryTableType)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableCollection>()
                .Property(e => e.IsCreatedInDb)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableCollection>()
                .Property(e => e.IsChangedAfterCreatedInDb)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableCollection>()
                .Property(e => e.IsDefault)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableCollection>()
                .HasMany(e => e.bairong_TableMetadata)
                .WithOne()
                .HasForeignKey(e => e.AuxiliaryTableEnName).IsRequired();

            modelBuilder.Entity<bairong_TableMatch>()
                .Property(e => e.ConnectionString)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableMatch>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableMatch>()
                .Property(e => e.ConnectionStringToMatch)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableMatch>()
                .Property(e => e.TableNameToMatch)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableMetadata>()
                .Property(e => e.AuxiliaryTableEnName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableMetadata>()
                .Property(e => e.AttributeName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableMetadata>()
                .Property(e => e.DataType)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableMetadata>()
                .Property(e => e.IsSystem)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.AttributeName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.HelpText)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.IsVisible)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.IsVisibleInList)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.IsSingleLine)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.InputType)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.IsRequired)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.DefaultValue)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyle>()
                .Property(e => e.IsHorizontal)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyleItem>()
                .Property(e => e.ItemTitle)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyleItem>()
                .Property(e => e.ItemValue)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_TableStyleItem>()
                .Property(e => e.IsSelected)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_ThirdLogin>()
                .Property(e => e.ThirdLoginType)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_ThirdLogin>()
                .Property(e => e.IsEnabled)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_UserBinding>()
                .Property(e => e.ThirdLoginType)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_UserGroup>()
                .Property(e => e.IsDefault)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_UserLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_UserLog>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Users>()
                .Property(e => e.PasswordFormat)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Users>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Users>()
                .Property(e => e.IsLockedOut)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Users>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Users>()
                .Property(e => e.AvatarUrl)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Users>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<bairong_Users>()
                .Property(e => e.Qq)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.VideoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.FileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.IsRecommend)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.IsHot)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.IsColor)
                .IsUnicode(false);

            modelBuilder.Entity<model_Content>()
                .Property(e => e.IsTop)
                .IsUnicode(false);

            modelBuilder.Entity<model_Job>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<model_Job>()
                .Property(e => e.IsUrgent)
                .IsUnicode(false);

            modelBuilder.Entity<model_Job>()
                .Property(e => e.IsTop)
                .IsUnicode(false);

            modelBuilder.Entity<model_Vote>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<model_Vote>()
                .Property(e => e.IsImageVote)
                .IsUnicode(false);

            modelBuilder.Entity<model_Vote>()
                .Property(e => e.IsSummary)
                .IsUnicode(false);

            modelBuilder.Entity<model_Vote>()
                .Property(e => e.IsClosed)
                .IsUnicode(false);

            modelBuilder.Entity<model_Vote>()
                .Property(e => e.IsTop)
                .IsUnicode(false);

            modelBuilder.Entity<model_Vote>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<model_Vote>()
                .Property(e => e.IsVotedView)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.IsRecommend)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.IsTop)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovInteract>()
                .Property(e => e.IsPublic)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovPublic>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovPublic>()
                .Property(e => e.IsAbolition)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovPublic>()
                .Property(e => e.IsRecommend)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovPublic>()
                .Property(e => e.IsHot)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovPublic>()
                .Property(e => e.IsColor)
                .IsUnicode(false);

            modelBuilder.Entity<model_WCM_GovPublic>()
                .Property(e => e.IsTop)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdArea>()
                .Property(e => e.IsEnabled)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdMaterial>()
                .Property(e => e.AdMaterialType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdMaterial>()
                .Property(e => e.TextLink)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdMaterial>()
                .Property(e => e.TextColor)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdMaterial>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdMaterial>()
                .Property(e => e.ImageLink)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdMaterial>()
                .Property(e => e.IsEnabled)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Adv>()
                .Property(e => e.IsEnabled)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Adv>()
                .Property(e => e.IsDateLimited)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Adv>()
                .Property(e => e.IsWeight)
                .IsUnicode(false);
            modelBuilder.Entity<siteserver_Advertisement>().HasKey(e => new {e.AdvertisementName,e.PublishmentSystemId });
            modelBuilder.Entity<siteserver_Advertisement>()
                .Property(e => e.AdvertisementName)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Advertisement>()
                .Property(e => e.AdvertisementType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Advertisement>()
                .Property(e => e.NavigationUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Advertisement>()
                .Property(e => e.IsDateLimited)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdvImageClassify>()
                .Property(e => e.ParentsPath)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdvImageClassify>()
                .Property(e => e.Enabled)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdvImageClassify>()
                .Property(e => e.IsLastItem)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdvImageContent>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_AdvImageContent>()
                .Property(e => e.LaseEditUser)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Comment>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_CreateTask>()
                .Property(e => e.CreateType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_CreateTaskLog>()
                .Property(e => e.CreateType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_CreateTaskLog>()
                .Property(e => e.IsSuccess)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherDatabaseRule>()
                .Property(e => e.ConnectionString)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherDatabaseRule>()
                .Property(e => e.RelatedTableName)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherDatabaseRule>()
                .Property(e => e.RelatedIdentity)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherDatabaseRule>()
                .Property(e => e.RelatedOrderBy)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherDatabaseRule>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherDatabaseRule>()
                .Property(e => e.IsAutoCreate)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherDatabaseRule>()
                .Property(e => e.IsOrderByDesc)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherFileRule>()
                .Property(e => e.Charset)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherFileRule>()
                .Property(e => e.IsToFile)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherFileRule>()
                .Property(e => e.IsSaveRelatedFiles)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherFileRule>()
                .Property(e => e.IsRemoveScripts)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherFileRule>()
                .Property(e => e.IsSaveImage)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherFileRule>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherFileRule>()
                .Property(e => e.IsAutoCreate)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.CookieString)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.GatherUrlIsCollection)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.GatherUrlCollection)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.GatherUrlIsSerialize)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.GatherUrlSerialize)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.SerializeIsOrderByDesc)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.SerializeIsAddZero)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.Charset)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_GatherRule>()
                .Property(e => e.UrlInclude)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_InnerLink>()
                .Property(e => e.LinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Input>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Input>()
                .Property(e => e.IsReply)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_InputContent>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_InputContent>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Log>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Log>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuDisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.Vertical)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.FontFamily)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.FontWeight)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.FontStyle)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuItemHAlign)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuItemVAlign)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.FontColor)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuItemBgColor)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.FontColorHilite)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuHiliteBgColor)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.XPosition)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.YPosition)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.HideOnMouseOut)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuBgOpaque)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.BgColor)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuBorderBgColor)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.MenuLiteBgColor)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.ChildMenuIcon)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_MenuDisplay>()
                .Property(e => e.IsDefault)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.NodeType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.ContentModelId)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.IsLastNode)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.ChannelFilePathRule)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.ContentFilePathRule)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.LinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Node>()
                .Property(e => e.LinkType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Photo>()
                .Property(e => e.SmallUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Photo>()
                .Property(e => e.MiddleUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Photo>()
                .Property(e => e.LargeUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Photo>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.PublishmentSystemType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.AuxiliaryTableForContent)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.AuxiliaryTableForGovPublic)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.AuxiliaryTableForGovInteract)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.AuxiliaryTableForVote)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.AuxiliaryTableForJob)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.IsCheckContentUseLevel)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.PublishmentSystemDir)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.PublishmentSystemUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_PublishmentSystem>()
                .Property(e => e.IsHeadquarters)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_ResumeContent>()
                .Property(e => e.IsView)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_ResumeContent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_ResumeContent>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_ResumeContent>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_ResumeContent>()
                .Property(e => e.IdCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_ResumeContent>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_ResumeContent>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.SeoMetaName)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.IsDefault)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.Charset)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.Distribution)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.Rating)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.Robots)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.RevisitAfter)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMeta>()
                .Property(e => e.Expires)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SeoMetasInNodes>()
                .Property(e => e.IsChannel)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninLog>()
                .Property(e => e.IsSignin)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninLog>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninSetting>()
                .Property(e => e.IsGroup)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninSetting>()
                .Property(e => e.UserGroupCollection)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninSetting>()
                .Property(e => e.EndDate)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninSetting>()
                .Property(e => e.IsSignin)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninUserContentId>()
                .Property(e => e.IsGroup)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SigninUserContentId>()
                .Property(e => e.ContentIdCollection)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_StarSetting>()
                .Property(e => e.PointAverage);

            modelBuilder.Entity<siteserver_SystemPermissions>()
                .Property(e => e.NodeIdCollection)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SystemPermissions>()
                .Property(e => e.ChannelPermissions)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_SystemPermissions>()
                .Property(e => e.WebsitePermissions)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_TagStyle>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_TagStyle>()
                .Property(e => e.IsTemplate)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Task>()
                .Property(e => e.IsSystemTask)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Task>()
                .Property(e => e.ServiceType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Task>()
                .Property(e => e.FrequencyType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Task>()
                .Property(e => e.IsEnabled)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_TaskLog>()
                .Property(e => e.IsSuccess)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Template>()
                .Property(e => e.TemplateType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Template>()
                .Property(e => e.CreatedFileExtName)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Template>()
                .Property(e => e.Charset)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Template>()
                .Property(e => e.IsDefault)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_TemplateMatch>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_TemplateMatch>()
                .Property(e => e.ChannelFilePathRule)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_TemplateMatch>()
                .Property(e => e.ContentFilePathRule)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Tracking>()
                .Property(e => e.TrackerType)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Tracking>()
                .Property(e => e.PageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Tracking>()
                .Property(e => e.Referrer)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Tracking>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Tracking>()
                .Property(e => e.OperatingSystem)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_Tracking>()
                .Property(e => e.Browser)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_VoteOperation>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_VoteOption>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<siteserver_VoteOption>()
                .Property(e => e.NavigationUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovInteractLog>()
                .Property(e => e.LogType)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovInteractLog>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovInteractRemark>()
                .Property(e => e.RemarkType)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.IsOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.CivicPhone)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.CivicPostCode)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.CivicFax)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.OrgPhone)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.OrgPostCode)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.OrgFax)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.IsApplyFree)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.ProvideType)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.ObtainType)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .HasMany(e => e.wcm_GovPublicApplyLog)
                .WithOne()
                .HasForeignKey(e => e.ApplyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .HasMany(e => e.wcm_GovPublicApplyRemark)
                .WithOne()
                .HasForeignKey(e => e.ApplyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<wcm_GovPublicApply>()
                .HasMany(e => e.wcm_GovPublicApplyReply)
                .WithOne()
                .HasForeignKey(e => e.ApplyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<wcm_GovPublicApplyLog>()
                .Property(e => e.LogType)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApplyLog>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicApplyRemark>()
                .Property(e => e.RemarkType)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicCategory>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicCategory>()
                .Property(e => e.IsLastNode)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicCategoryClass>()
                .Property(e => e.IsSystem)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicCategoryClass>()
                .Property(e => e.IsEnabled)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicCategoryClass>()
                .Property(e => e.ContentAttributeName)
                .IsUnicode(false);

            //modelBuilder.Entity<wcm_GovPublicCategoryClass>()
            //    .HasMany(e => e.wcm_GovPublicCategory)
            //    .WithOne()
            //    .HasForeignKey(e =>  e.ClassCode)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<wcm_GovPublicIdentifierRule>()
                .Property(e => e.IdentifierType)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicIdentifierRule>()
                .Property(e => e.Suffix)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicIdentifierRule>()
                .Property(e => e.FormatString)
                .IsUnicode(false);

            modelBuilder.Entity<wcm_GovPublicIdentifierRule>()
                .Property(e => e.AttributeName)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.IsBinding)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.SourceId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.ThumbUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.AppId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.AppSecret)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.IsWelcome)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Account>()
                .Property(e => e.IsDefaultReply)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Album>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Album>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AlbumContent>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AlbumContent>()
                .Property(e => e.LargeImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.ContentIsSingle)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.ContentImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.ContentResultTopImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.EndImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.IsFormRealName)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.IsFormMobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Appointment>()
                .Property(e => e.IsFormEmail)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentContent>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentContent>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentContent>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentContent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentContent>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.TopImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.IsDescription)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.IsImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.IsVideoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.VideoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.IsImageUrlCollection)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.IsMap)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.IsTel)
                .IsUnicode(false);

            modelBuilder.Entity<wx_AppointmentItem>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Card>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Card>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Card>()
                .Property(e => e.CardNoColor)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Card>()
                .Property(e => e.ContentFrontImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Card>()
                .Property(e => e.ContentBackImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Card>()
                .Property(e => e.ShopPosition)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CardCashLog>()
                .Property(e => e.Amount);

            modelBuilder.Entity<wx_CardCashLog>()
                .Property(e => e.CurAmount);

            modelBuilder.Entity<wx_CardEntitySn>()
                .Property(e => e.Sn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CardEntitySn>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CardEntitySn>()
                .Property(e => e.Amount);

            modelBuilder.Entity<wx_CardEntitySn>()
                .Property(e => e.IsBinding)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CardSn>()
                .Property(e => e.Sn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CardSn>()
                .Property(e => e.Amount);

            modelBuilder.Entity<wx_CardSn>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Collect>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Collect>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Collect>()
                .Property(e => e.ContentImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Collect>()
                .Property(e => e.ContentIsCheck)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Collect>()
                .Property(e => e.EndImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CollectItem>()
                .Property(e => e.SmallUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CollectItem>()
                .Property(e => e.LargeUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CollectItem>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CollectItem>()
                .Property(e => e.IsChecked)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CollectLog>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CollectLog>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CollectLog>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Conference>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Conference>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Conference>()
                .Property(e => e.BackgroundImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Conference>()
                .Property(e => e.IsAgenda)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Conference>()
                .Property(e => e.IsGuest)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Conference>()
                .Property(e => e.EndImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConferenceContent>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConferenceContent>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConferenceContent>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConferenceContent>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConferenceContent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConfigExtend>()
                .Property(e => e.KeywordType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConfigExtend>()
                .Property(e => e.AttributeName)
                .IsUnicode(false);

            modelBuilder.Entity<wx_ConfigExtend>()
                .Property(e => e.IsVisible)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Count>()
                .Property(e => e.CountType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.ContentImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.IsFormRealName)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.IsFormMobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.IsFormEmail)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.IsFormAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponAct>()
                .Property(e => e.EndImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponSn>()
                .Property(e => e.Sn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponSn>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponSn>()
                .Property(e => e.HoldMobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponSn>()
                .Property(e => e.HoldEmail)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponSn>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_CouponSn>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Keyword>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Keyword>()
                .Property(e => e.KeywordType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Keyword>()
                .Property(e => e.MatchType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_KeywordMatch>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_KeywordMatch>()
                .Property(e => e.KeywordType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_KeywordMatch>()
                .Property(e => e.MatchType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_KeywordResource>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_KeywordResource>()
                .Property(e => e.ResourceType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_KeywordResource>()
                .Property(e => e.IsShowCoverPic)
                .IsUnicode(false);

            modelBuilder.Entity<wx_KeywordResource>()
                .Property(e => e.NavigationUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.LotteryType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.ContentImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.ContentAwardImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.AwardImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.IsAwardTotalNum)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.IsFormRealName)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.IsFormMobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.IsFormEmail)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.IsFormAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Lottery>()
                .Property(e => e.EndImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryLog>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryLog>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryWinner>()
                .Property(e => e.LotteryType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryWinner>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryWinner>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryWinner>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryWinner>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryWinner>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<wx_LotteryWinner>()
                .Property(e => e.CashSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Map>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Map>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Menu>()
                .Property(e => e.MenuType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Menu>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Message>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Message>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Message>()
                .Property(e => e.ContentImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_MessageContent>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wx_MessageContent>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_MessageContent>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_MessageContent>()
                .Property(e => e.IsReply)
                .IsUnicode(false);

            modelBuilder.Entity<wx_MessageContent>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Search>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Search>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Search>()
                .Property(e => e.ContentImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Search>()
                .Property(e => e.IsOutsiteSearch)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Search>()
                .Property(e => e.IsNavigation)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Search>()
                .Property(e => e.NavTitleColor)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Search>()
                .Property(e => e.NavImageColor)
                .IsUnicode(false);

            modelBuilder.Entity<wx_SearchNavigation>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<wx_SearchNavigation>()
                .Property(e => e.ImageCssClass)
                .IsUnicode(false);

            modelBuilder.Entity<wx_SearchNavigation>()
                .Property(e => e.NavigationType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_SearchNavigation>()
                .Property(e => e.KeywordType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Store>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Store>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_StoreCategory>()
                .Property(e => e.ParentsPath)
                .IsUnicode(false);

            modelBuilder.Entity<wx_StoreCategory>()
                .Property(e => e.IsLastNode)
                .IsUnicode(false);

            modelBuilder.Entity<wx_StoreItem>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<wx_StoreItem>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_StoreItem>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<wx_StoreItem>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.ContentImageUrl1)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.ContentImageUrl2)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.ContentImageUrl3)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.ContentImageUrl4)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.ContentImageUrl5)
                .IsUnicode(false);

            modelBuilder.Entity<wx_View360>()
                .Property(e => e.ContentImageUrl6)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Vote>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Vote>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Vote>()
                .Property(e => e.ContentImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Vote>()
                .Property(e => e.ContentIsImageOption)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Vote>()
                .Property(e => e.ContentIsCheckBox)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Vote>()
                .Property(e => e.ContentResultVisible)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Vote>()
                .Property(e => e.EndImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_VoteItem>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_VoteItem>()
                .Property(e => e.NavigationUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_VoteLog>()
                .Property(e => e.ItemIdCollection)
                .IsUnicode(false);

            modelBuilder.Entity<wx_VoteLog>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<wx_VoteLog>()
                .Property(e => e.CookieSn)
                .IsUnicode(false);

            modelBuilder.Entity<wx_VoteLog>()
                .Property(e => e.WxOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_WebMenu>()
                .Property(e => e.IconUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_WebMenu>()
                .Property(e => e.IconCssClass)
                .IsUnicode(false);

            modelBuilder.Entity<wx_WebMenu>()
                .Property(e => e.NavigationType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_WebMenu>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<wx_WebMenu>()
                .Property(e => e.KeywordType)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Wifi>()
                .Property(e => e.IsDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Wifi>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_Wifi>()
                .Property(e => e.BusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_WifiNode>()
                .Property(e => e.BusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<wx_WifiNode>()
                .Property(e => e.NodeId)
                .IsUnicode(false);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
