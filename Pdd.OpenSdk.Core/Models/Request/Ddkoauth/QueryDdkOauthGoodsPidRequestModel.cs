using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Ddkoauth
{
    public partial class QueryDdkOauthGoodsPidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.ddk.oauth.goods.pid.query
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 返回的页数
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 返回的每页推广位数量
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

    }

}
