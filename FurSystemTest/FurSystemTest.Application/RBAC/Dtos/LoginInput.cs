﻿namespace FurSystemTest.Application;

/// <summary>
/// 登录输入参数
/// </summary>
public class LoginInput
{
    /// <summary>
    /// 用户名
    /// </summary>
    /// <example>admin</example>
    [Required, MinLength(1)]
    public string Account { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    /// <example>admin</example>
    [Required, MinLength(5)]
    public string Password { get; set; }
}