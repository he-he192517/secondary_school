using System;
using FurSystemTest.Core.Dtos;

namespace FurSystemTest.Core.Dtos;

public class SessionCodeUser
{
    /// <summary>
    ///     过期时间
    /// </summary>
    public DateTime ExpiresTime { get; set; }

    /// <summary>
    ///     用户信息
    /// </summary>
    public CurrentUserModel CurrentUser { get; set; }
}