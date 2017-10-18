﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BPO.Core
{
    public enum ESmsProviderType
    {
        Aliyun,
        Yunpian,
        None
    }

    public class ESmsProviderTypeUtils
    {
        public static string GetValue(ESmsProviderType type)
        {
            if (type == ESmsProviderType.Aliyun)
            {
                return "Aliyun";
            }
            if (type == ESmsProviderType.Yunpian)
            {
                return "Yunpian";
            }
            return "None";
        }

        public static string GetText(ESmsProviderType type)
        {
            if (type == ESmsProviderType.Aliyun)
            {
                return "阿里大于";
            }
            if (type == ESmsProviderType.Yunpian)
            {
                return "云片";
            }
            return "无";
        }

        public static string GetUrl(ESmsProviderType type)
        {
            if (type == ESmsProviderType.Aliyun)
            {
                return "http://www.alidayu.com/";
            }
            if (type == ESmsProviderType.Yunpian)
            {
                return "http://www.yunpian.com/";
            }
            return string.Empty;
        }

        public static ESmsProviderType GetEnumType(string typeStr)
        {
            var retval = ESmsProviderType.None;
            if (Equals(typeStr, ESmsProviderType.Aliyun))
            {
                retval = ESmsProviderType.Aliyun;
            }
            else if (Equals(typeStr, ESmsProviderType.Yunpian))
            {
                retval = ESmsProviderType.Yunpian;
            }
            return retval;
        }

        public static bool Equals(ESmsProviderType type, string typeStr)
        {
            return !string.IsNullOrEmpty(typeStr) && string.Equals(GetValue(type).ToLower(), typeStr.ToLower());
        }

        public static bool Equals(string typeStr, ESmsProviderType type)
        {
            return Equals(type, typeStr);
        }

        public static List<ESmsProviderType> GetList()
        {
            return new List<ESmsProviderType>
            {
                //ESmsProviderType.AliDaYu,
                ESmsProviderType.Yunpian
            };
        }

        //public static ListItem GetListItem(ESmsProviderType type, bool selected)
        //{
        //    var item = new ListItem(GetText(type), GetValue(type));
        //    if (selected)
        //    {
        //        item.Selected = true;
        //    }
        //    return item;
        //}

        //public static void AddListItems(ListControl listControl)
        //{
        //    if (listControl != null)
        //    {
        //        listControl.Items.Add(GetListItem(ESmsProviderType.None, false));
        //        listControl.Items.Add(GetListItem(ESmsProviderType.Yunpian, false));
        //    }
        //}
    }
}
