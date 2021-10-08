using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiForData.Models;

namespace WebApiForData.Controllers
{
    /// <summary>
    /// 刀具資料
    /// </summary>   
    public class KnifeController : ApiController
    {
        /// <summary>
        /// 取得刀具資料
        /// </summary>
        /// <returns></returns>
       [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<KnifeDatas> GetKnifeData()
        {
            List<KnifeDatas> _data = new List<KnifeDatas>();

            //新增第一筆資料
            _data.Add(new KnifeDatas
            {
                Name = "一體黑石洗實刀",
                ItemCode = "A001",
                Amount = 2200,
                Discount = 1760,
                IsDiscount = true,
                Memo = "砍起來很厲害",
                ImgURL = @"/img1.png"
            });

            //新增第二筆資料
            _data.Add(new KnifeDatas
            {
                Name = "一體灰石洗直刀",
                ItemCode = "A002",
                Amount = 2200,
                Discount = 1760,
                IsDiscount = true,
                Memo = "殺人刀不沾血",
                ImgURL = @"/img2.png"
            });

            return _data;
        }
    }
}
