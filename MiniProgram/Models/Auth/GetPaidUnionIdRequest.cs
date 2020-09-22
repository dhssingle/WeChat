using System.Net.Http;
using Newtonsoft.Json;
using WeChat.MiniProgram.Models;

namespace WeChat.MiniProgram.Models.Auth
{
    public class GetPaidUnionIdRequest : CommonRequest
    {
        GetPaidUnionIdRequest()
        {
            httpMethod = HttpMethod.Get;
            requestUri = "wxa/getpaidunionid";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="openId">支付用户唯一标识</param>
        /// <param name="transactionId">微信支付分配的<see href="https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_7">商户号</see>，和商户订单号配合使用</param>
        /// <param name="mchId">微信支付分配的<see href="https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_7">商户号</see>，和商户订单号配合使用</param>
        /// <param name="outTradeNo">微信支付<see href="https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_7">商户订单号</see>，和商户号配合使用</param>
        /// <returns></returns>
        public GetPaidUnionIdRequest(string openId, string transactionId = null, string mchId = null, string outTradeNo = null) : this()
        {
            OpenId = openId;
            TransactionId = transactionId;
            MchId = mchId;
            OutTradeNo = outTradeNo;
        }
        /// <summary>
        /// 支付用户唯一标识
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }
        /// <summary>
        /// <see href="https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_7">微信支付订单号</see>
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
        /// <summary>
        /// 微信支付分配的<see href="https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_7">商户号</see>，和商户订单号配合使用
        /// </summary>
        [JsonProperty("mch_id")]
        public string MchId { get; set; }
        /// <summary>
        /// 微信支付<see href="https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_7">商户订单号</see>，和商户号配合使用
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

    }
}