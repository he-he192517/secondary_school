﻿#region copyright
//------------------------------------------------------------------------------
//  此代码版权声明为全文件覆盖，如有原作者特别声明，会在下方手动补充
//  此代码版权（除特别声明外的代码）归作者本人Diego所有
//  源代码使用协议遵循本仓库的开源协议及附加协议
//  Gitee源代码仓库：https://gitee.com/diego2098/ThingsGateway
//  Github源代码仓库：https://github.com/kimdiego2098/ThingsGateway
//  使用文档：https://diego2098.gitee.io/thingsgateway-docs/
//  QQ群：605534569
//------------------------------------------------------------------------------
#endregion

using Furion;

namespace FurSystemTest.Core;

/// <summary>
/// 当前登录用户信息
/// </summary>
public class UserManager
{
    /// <summary>
    /// 当前用户账号
    /// </summary>
    public static string Account => App.User?.FindFirst(ClaimConst.Account)?.Value;

    /// <summary>
    /// 当前用户Id
    /// </summary>
    public static int UserId => int.Parse(App.User?.FindFirst(ClaimConst.UserId)?.Value!);

    public static string Name => App.User?.FindFirst(ClaimConst.Name)?.Value;


    public static string Role => App.User?.FindFirst(ClaimConst.Role)?.Value;
}