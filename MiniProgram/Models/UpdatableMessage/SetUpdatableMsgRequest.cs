using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeChat.MiniProgram.Models.UpdatableMessage
{
    public class SetUpdatableMsgRequest : CommonRequest
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="activityId">动态消息的 ID</param>
        /// <param name="targetState">动态消息修改后的状态。0 未开始，1 已开始。</param>
        /// <param name="templateInfo">动态消息对应的模板信息</param>
        public SetUpdatableMsgRequest(string activityId, int targetState, TemplateInfo templateInfo)
        {
            httpMethod = System.Net.Http.HttpMethod.Post;
            requestUri = "cgi-bin/message/wxopen/updatablemsg/send";

            ActivityId = activityId;
            TargetState = targetState;
            TemplateInfo = templateInfo;
        }
        /// <summary>
        /// 动态消息的 ID
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; }

        /// <summary>
        /// 动态消息修改后的状态。0 未开始，1 已开始。
        /// </summary>
        /// <value></value>
        [JsonProperty("target_state")]
        public int TargetState { get; }
        /// <summary>
        /// 动态消息对应的模板信息
        /// </summary>
        [JsonProperty("template_info")]
        public TemplateInfo TemplateInfo { get; }
    }

    public class TemplateInfo
    {
        /// <summary>
        /// 模板中需要修改的参数
        /// </summary>
        [JsonProperty("parameter_list")]
        public IEnumerable<Parameter> ParameterList { get; set; }
    }

    public class Parameter
    {
        /// <summary>
        /// 要修改的参数名
        /// <para>
        /// name 的合法值:
        /// member_count，target_state = 0 时必填，文字内容模板中 member_count 的值;
        /// room_limit，target_state = 0 时必填，文字内容模板中 room_limit 的值;
        /// path，target_state = 1 时必填，点击「进入」启动小程序时使用的路径。对于小游戏，没有页面的概念，可以用于传递查询字符串（query），如 "?foo=bar";
        /// version_type，target_state = 1 时必填，点击「进入」启动小程序时使用的版本。有效参数值为：develop（开发版），trial（体验版），release（正式版）
        /// </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 修改后的参数值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}