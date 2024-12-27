namespace FurSystemTest.Core.Dtos
{
    public class GetAccessCodeRequest
    {
        /// <summary>
        /// 授权码
        /// </summary>
        public string AuthCode { get; set; }
        /// <summary>
        /// 会话Code
        /// </summary>
        public string SessionCode { get; set; }
    }
}
