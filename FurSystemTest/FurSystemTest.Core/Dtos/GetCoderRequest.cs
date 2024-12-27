namespace FurSystemTest.Core.Dtos
{
    public class GetCoderRequest
    {
        /// <summary>
        /// 应用Id
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
    }
    public class GetCodeBySessionCodeRequest
    {
        /// <summary>
        /// 应用Id
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// 会话code
        /// </summary>
        public string SessionCode { get; set; }
    }
}
