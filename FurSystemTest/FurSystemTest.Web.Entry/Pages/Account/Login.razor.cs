using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using BootstrapBlazor.Components;
using Furion.ClayObject;
using Furion.JsonSerialization;
using Furion.Logging;
using FurSystemTest.Application;
using Microsoft.AspNetCore.Components;

namespace FurSystemTest.Web.Entry.Pages.Account;

public partial class Login
{
    private string Title { get; set; } = "登录";

    [SupplyParameterFromQuery]
    [Parameter]
    public string ReturnUrl { get; set; }

    private LoginInput LoginVo { get; set; } = new LoginInput();

    [Inject]
    [NotNull]
    private AjaxService AjaxService { get; set; }

    [Inject]
    [NotNull]
    public MessageService MessageService { get; set; }

    private Task OnSignUp()
    {
        //注册用户
        throw new NotImplementedException();
    }

    private Task OnForgotPassword()
    {
        //忘记密码
        throw new NotImplementedException();
    }

    private async Task DoLogin()
    {
        if (string.IsNullOrEmpty(LoginVo.Account))
        {
            await MessageService.Show(new MessageOption()
            {
                Color = Color.Danger,
                Content = "用户名不能为空"
            });
            return;
        }

        if (string.IsNullOrEmpty(LoginVo.Password))
        {
            await MessageService.Show(new MessageOption()
            {
                Color = Color.Danger,
                Content = "密码不能为空"
            });
            return;
        }

        var ajaxOption = new AjaxOption
        {
            Url = "/api/rbac/login",
            Data = LoginVo
        };

        JsonDocument str = await AjaxService.InvokeAsync(ajaxOption);
        if (str == null)
        {
            await MessageService.Show(new MessageOption()
            {
                Color = Color.Danger,
                Content = "登录失败"
            });
        }
        else
        {

             var ret = JSON.Deserialize<AjaxResult>(str.RootElement.GetProperty("data").ToString());

            //JsonElement jsonEl = str.RootElement;
            //JsonElement jsonData = jsonEl.GetProperty("data");
            //var str1 = jsonData.ToString();
            //str1.Replace(@"\", "");
            //dynamic ret = Clay.Parse(ret1);

            if (ret.code != 20000)
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Danger,
                    Content = "登录失败"
                });
            }
            else
            {
                await MessageService.Show(new MessageOption()
                {
                    Color = Color.Success,
                    Content = "登录成功"
                });
                ReturnUrl ??= "/";
                Log.Error($"登录成功，跳转到：{ReturnUrl}");
                StateHasChanged();
                await AjaxService.Goto(ReturnUrl);

            }
        }
    }
}
public class AjaxResult
{
    public int code { get; set; }
    public string message { get; set; }
}

