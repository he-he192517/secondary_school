namespace FurSystemTest.Application;


/// <summary>
/// 登录输出参数
/// </summary>
public class LoginOutput
{
    /// <summary>
    /// 用户Id
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    [Required, MinLength(1)]
    public string Account { get; set; }

    /// <summary>
    /// Token
    /// </summary>
    public string AccessToken { get; set; }
}