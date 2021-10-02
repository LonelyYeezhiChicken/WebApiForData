using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiForData.Models
{
    /// <summary>
    /// 刀具資料模型
    /// </summary>
    public class KnifeDatas
    {
        /// <summary>
        /// 商品名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品編號
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// 商品價錢
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// 折扣金額
        /// </summary>
        public int Discount { get; set; }
        /// <summary>
        /// 是否有折扣
        /// </summary>
        public bool IsDiscount { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 圖片路徑
        /// </summary>
        public string ImgURL { get; set; }
    }
}