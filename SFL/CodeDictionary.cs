using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineApp.SFL
{
    public static class CodeDictionary
    {
        public static Dictionary<string, string> DictionaryType = new Dictionary<string, string>
        {
            {"餐厅类别", "01"},//
            {"授权类型", "02"},//
            {"餐桌类别", "03"},//
            {"原料类别", "04"},//
            {"菜品类别", "05"},//
            {"辣度", "06"},//
            {"计量方式", "07"},//
            {"需求单状态", "08"},//
            {"购买记录状态", "09"},//
            {"消费时间段", "10"},//
            {"预定状态", "11"},//
            {"消费状态", "12"},//
            {"菜品预定状态", "13"},//
            {"借款类型", "14"},//
            {"借款原因", "15"},//
            {"借款状态", "16"},//
            {"原料归属", "17"},//
            {"制作时间", "18"},//
            {"业务表类型", "19"},
            {"退菜原因", "20"},
            {"特殊要求", "21"},
            {"菜品制作状态", "22"},
            {"菜品结账状态", "23"},
            {"优惠券类型", "24"},
            {"支付方式", "25"}
        };

        /// <summary>
        /// 平台用户角色编码
        /// </summary>
        public static Dictionary<string, int> UserRole = new Dictionary<string, int>
        {
            {"超级管理员", 1},
            {"业务管理员", 2}, 
            {"学生", 11},
            {"家长", 12},
            {"教师", 13}
        };

        /// <summary>
        /// 系统状态编码
        /// </summary>
        public static Dictionary<string, int> SystemState = new Dictionary<string, int>
        {
            {"已禁用", 0},
            {"已启用", 1}
        };


        /// <summary>
        /// 业务用户角色编码
        /// </summary>
        public static Dictionary<string, int> BusinessRole = new Dictionary<string, int>
        {
            {"餐厅管理员", 7},
            {"采购员", 8},
            {"销售经理", 9},
            {"仓库负责人", 10},
            {"切配员", 11},
            {"传菜员", 12}
        };


        /// <summary>
        /// 餐厅类别
        /// </summary>
        public static Dictionary<string, int> RestaurantType = new Dictionary<string, int>
        {
            {"中餐", 1},//中餐
            {"西餐", 2},//西餐
            {"火锅", 3},//火锅
            {"饮品", 4},//饮品
            {"烧烤", 5},//烧烤
            {"其他", 6}//其他
        };

        /// <summary>
        /// 授权类别
        /// </summary>
        public static Dictionary<string, int> AuthorizeType = new Dictionary<string, int>
        {
            {"免费", 7},//免费
            {"会员", 8},//会员
            {"VIP", 9}//VIP
        };

        /// <summary>
        /// 原料归属
        /// </summary>
        public static Dictionary<string, int> MaterialBelongType = new Dictionary<string, int>
        {
            {"厨房", 17},
            {"仓库", 18}

        };

        /// <summary>
        /// 计量方式
        /// </summary>
        public static Dictionary<string, int> EstimateMode = new Dictionary<string, int>
        {
            {"按重量", 30},//按重量
            {"按数量", 31}//按数量

        };

        /// <summary>
        /// 需求单状态
        /// </summary>
        public static Dictionary<string, int> RequirementState = new Dictionary<string, int>
        {
            {"草稿", 32},//草稿
            {"已下单", 33},//已下单
            {"处理中", 34},//处理中
            {"已购买", 35},//已购买
            {"已入库", 36}//已入库
        };

        /// <summary>
        /// 购买记录状态
        /// </summary>
        public static Dictionary<string, int> BuyingState = new Dictionary<string, int>
        {
            {"已购买", 37},//已购买
            {"已入库", 38},//已入库
            {"已结算", 39}//已结算
        };



        /// <summary>
        /// 预定状态
        /// </summary>
        public static Dictionary<string, int> BookState = new Dictionary<string, int>
        {
            {"已预订", 43},//已预订
            {"已到店", 44},//已到店
            {"已超时", 45},//已超时
            {"已开桌", 46}//已开桌
        };

        /// <summary>
        /// 消费状态
        /// </summary>
        public static Dictionary<string, int> ConsumeState = new Dictionary<string, int>
        {
            {"已开桌", 47},
            {"已点菜", 48},
            {"菜上齐", 49},
            {"待结账", 50},
            {"已结账", 51},
            {"已关桌", 122}
        };

        /// <summary>
        /// 菜品制作状态
        /// </summary>
        public static Dictionary<string, int> FoodMakeState = new Dictionary<string, int>
        {
            {"已下单", 52},
            {"切配中", 53},
            {"待制作", 54},
            {"制作中", 55},
            {"已出菜", 56},
            {"已上菜", 57},    
            {"已退菜", 113}
        };

        /// <summary>
        /// 借款状态
        /// </summary>
        public static Dictionary<string, int> LentState = new Dictionary<string, int>
        {
            {"申请中", 62},
            {"已借出", 63},
            {"部分归还", 64},
            {"还款完成", 65}
        };

        /// <summary>
        /// 业务表类型
        /// </summary>
        public static Dictionary<string, int> YWTableType = new Dictionary<string, int>
        {
            {"需求日志", 111}//需求日志
        };

        /// <summary>
        /// 菜品预定状态
        /// </summary>
        public static Dictionary<string, int> FoodOrderState = new Dictionary<string, int>
        {  
            {"起菜", 134},
            {"等叫", 135}
        };

        /// <summary>
        /// 菜品结账状态
        /// </summary>
        public static Dictionary<string, int> FoodCheckState = new Dictionary<string, int>
        {  
            {"未结账", 136},
            {"已结账", 137}
        };
    }
}
