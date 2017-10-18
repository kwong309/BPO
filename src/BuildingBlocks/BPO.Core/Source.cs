using System;
using System.Collections.Generic;
using System.Text;

namespace BPO.Core
{
    public enum InfoSource
    {
        人工录入 = 1,
        事件上报 = 2,
        天网系统 = 3,
        数据挖掘 = 4,
        司机投诉 = 7,
        四维 = 8,
        快修打回 = 9,
        竞品抓取 = 2001,
        其他 = 99
    }
    public enum InfoType
    {
        施工 = 206,
        封路 = 208,
        其他事件 = 200,
        道路名称 = 1,
        通行方向 = 2,
        道路状态 = 3,
        禁止穿行 = 4,
        功能等级 = 5,
        道路等级 = 6,
        道路缺失 = 10,
        道路封闭 = 11,
        道路开通 = 12,
        增加交规 = 13,
        删除交规 = 14,
        单行限制 = 15,
        施工改道 = 16,
        道路废弃 = 17,
        道路形态变化 = 18,
        其他 = 99,
        非数据问题 = 100
    }
}
