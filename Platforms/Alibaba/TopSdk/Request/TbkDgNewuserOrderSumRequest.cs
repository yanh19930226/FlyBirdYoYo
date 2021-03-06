using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tbk.dg.newuser.order.sum
    /// </summary>
    public class TbkDgNewuserOrderSumRequest : BaseTopRequest<Top.Api.Response.TbkDgNewuserOrderSumResponse>
    {
        /// <summary>
        /// 活动id， 活动名称与活动ID列表，请参见https://tbk.bbs.taobao.com/detail.html?appId=45301&postId=8599277
        /// </summary>
        public string ActivityId { get; set; }

        /// <summary>
        /// mm_xxx_xxx_xxx的第三位
        /// </summary>
        public Nullable<long> AdzoneId { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页大小，默认20，1~100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// mm_xxx_xxx_xxx的第二位
        /// </summary>
        public Nullable<long> SiteId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.tbk.dg.newuser.order.sum";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("activity_id", this.ActivityId);
            parameters.Add("adzone_id", this.AdzoneId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("site_id", this.SiteId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("activity_id", this.ActivityId);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
