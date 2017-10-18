using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace BPO.Core
{
    public class WebConfigUtils
    {
        /// <summary>
        /// 获取当前正在执行的服务器应用程序的根目录的物理文件系统路径。
        /// </summary>
        public static string ContentRootPath { get; set; }
        public static string WebRootPath { get; set; }
        public static bool IsProtectData { get; set; }
        public static EDatabaseType DatabaseType { get; set; }
        public static string ConnectionString { get; set; }

        public static string AdminDirectory { get; set; }
        public static string SecretKey { get; set; }
        public static bool IsNeedInstall { get; set; }
        public   string Test { get; set; }

        public static void Update()
        {
            var configFilePath = PathUtils.MapPath("~/appsettings.json");
            var obj= JObject.Parse(File.ReadAllText(configFilePath));
            obj["IsNeedInstall"] = false;
            obj["IsProtectData"] = IsProtectData;
            obj["DatabaseType"] = DatabaseType.ToString();
            obj["AdminDirectory"] = AdminDirectory;
            obj["ConnectionStrings"]["DefaultConnection"] = ConnectionString;
            File.WriteAllText(configFilePath, obj.ToString());
        }

        //public static void UpdateWebConfig(bool isProtectData, EDatabaseType databaseType, string connectionString, string adminDirectory, string secretKey)
        //{
        //    var configFilePath = PathUtils.MapPath("~/web.config");

        //    var doc = new XmlDocument();
        //    doc.Load(configFilePath);
        //    var dirty = false;
        //    var appSettings = doc.SelectSingleNode("configuration/appSettings");
        //    if (appSettings != null)
        //    {
        //        foreach (XmlNode setting in appSettings)
        //        {
        //            if (setting.Name == "add")
        //            {
        //                var attrKey = setting.Attributes?["key"];
        //                if (attrKey != null)
        //                {
        //                    if (StringUtils.EqualsIgnoreCase(attrKey.Value, NameIsProtectData))
        //                    {
        //                        var attrValue = setting.Attributes["value"];
        //                        if (attrValue != null)
        //                        {
        //                            attrValue.Value = isProtectData.ToString();
        //                            dirty = true;
        //                        }
        //                    }
        //                    else if (StringUtils.EqualsIgnoreCase(attrKey.Value, NameDatabaseType))
        //                    {
        //                        var attrValue = setting.Attributes["value"];
        //                        if (attrValue != null)
        //                        {
        //                            attrValue.Value = EDatabaseTypeUtils.GetValue(databaseType);
        //                            if (isProtectData)
        //                            {
        //                                attrValue.Value = TranslateUtils.EncryptStringBySecretKey(attrValue.Value);
        //                            }
        //                            dirty = true;
        //                        }
        //                    }
        //                    else if (StringUtils.EqualsIgnoreCase(attrKey.Value, NameConnectionString))
        //                    {
        //                        var attrValue = setting.Attributes["value"];
        //                        if (attrValue != null)
        //                        {
        //                            attrValue.Value = connectionString;
        //                            if (isProtectData)
        //                            {
        //                                attrValue.Value = TranslateUtils.EncryptStringBySecretKey(attrValue.Value);
        //                            }
        //                            dirty = true;
        //                        }
        //                    }
        //                    else if (StringUtils.EqualsIgnoreCase(attrKey.Value, NameAdminDirectory))
        //                    {
        //                        var attrValue = setting.Attributes["value"];
        //                        if (attrValue != null)
        //                        {
        //                            attrValue.Value = adminDirectory;
        //                            dirty = true;
        //                        }
        //                    }
        //                    else if (StringUtils.EqualsIgnoreCase(attrKey.Value, NameAdminDirectory))
        //                    {
        //                        var attrValue = setting.Attributes["value"];
        //                        if (attrValue != null)
        //                        {
        //                            attrValue.Value = adminDirectory;
        //                            dirty = true;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (dirty)
        //    {
        //        var writer = new XmlTextWriter(configFilePath, System.Text.Encoding.UTF8)
        //        {
        //            Formatting = Formatting.Indented
        //        };
        //        doc.Save(writer);
        //        writer.Flush();
        //        writer.Close();
        //    }

        //    IsProtectData = isProtectData;
        //    DatabaseType = databaseType;
        //    ConnectionString = connectionString;
        //}

        public static string GetConnectionStringByName(string name)
        {
            var connectionString = string.Empty;
            try
            {
                var doc = new XmlDocument();

                var configFile = PathUtils.Combine(ContentRootPath, "web.config");

                doc.Load(configFile);

                var appSettings = doc.SelectSingleNode("configuration/appSettings");
                if (appSettings != null)
                {
                    foreach (XmlNode setting in appSettings)
                    {
                        if (setting.Name != "add") continue;

                        var attrKey = setting.Attributes?["key"];
                        if (attrKey == null) continue;

                        if (!StringUtils.EqualsIgnoreCase(attrKey.Value, name)) continue;

                        var attrValue = setting.Attributes["value"];
                        if (attrValue != null)
                        {
                            connectionString = attrValue.Value;
                        }
                        break;
                    }
                }
            }
            catch
            {
                // ignored
            }

            return connectionString;
        }
    }
}
