using BootstrapBlazor.Components;
using FurSystemTest.Application.Utils;
using FurSystemTest.Core.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using static Dm.net.buffer.ByteArrayBuffer;

namespace FurSystemTest.Web.SSO.Pages.SSO;
public partial class Login
{
    [Inject] private IHttpContextAccessor HttpContextAccessor { get; set; } = null!;

    private LoginModel LoginModel { get; set; } = new LoginModel();

    [Inject] private IJSRuntime JSRuntime { get; set; } = null!;

    /// <summary>
    /// 初始化进行会话检查
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        //var uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        //var queryParams = UtilHelper.GetQueryParams(uri.Query);
        var queryParams = await JSRuntime.InvokeAsync<Dictionary<string, string>>("GetParam");
        queryParams.TryGetValue("clientId", out var clientId);
        queryParams.TryGetValue("redirectUrl", out var redirectUrl);
        var sessionCode = await JSRuntime.InvokeAsync<string>("getCookie", "SessionCode");
        if (string.IsNullOrEmpty(sessionCode)) return;
        var parms = new GetCodeBySessionCodeRequest
        {
            ClientId = clientId,
            SessionCode = sessionCode
        };
        var data = SsoService.GetCodeBySessionCode(parms);
        if (data?.Code != ResponseCode.Fail)
        {
            Navigation.NavigateTo($"{redirectUrl}?authCode={data.Data}&sessionCode={sessionCode}");
        }
    }

    /// <summary>
    /// </summary>
    /// 检查httpcontext是否已经开始（ssr模式下会出现）
    private void test()
    {
        var context = HttpContextAccessor.HttpContext;
        var conte = HttpContextAccessor.HttpContext!.Response.HasStarted;
    }

    private Task HandleValidSubmit(EditContext arg)
    {
        var uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        var queryParams = UtilHelper.GetQueryParams(uri.Query);

        queryParams.TryGetValue("clientId", out var clientId);
        queryParams.TryGetValue("redirectUrl", out var redirectUrl);
        //var userName = LoginModel.UserName;
        var password = LoginModel.Password;
        //var loginParams = new GetCoderRequest { ClientId = clientId, UserName = userName, PassWord = password };
        //var response = await SsoService.GetCodeAsync(loginParams);
        //if (response!.Code == ResponseCode.Fail) return;
        //var code = response.Data;
        var code = "123456";
        UtilHelper.SetCookie(HttpContextAccessor.HttpContext, "SessionCode", code, 24 * 60 * 60, "/");
        Navigation.NavigateTo($"{redirectUrl}?authCode={code}&sessionCode={code}");
        return Task.CompletedTask;
    }

    /// <summary>
    /// 提交
    /// </summary>
    /// <param name="arg"></param>
    /// <returns></returns>
    private async Task OnValidSubmit(EditContext arg)
    {
        var queryParams = await JSRuntime.InvokeAsync<Dictionary<string, string>>("GetParam");
        queryParams.TryGetValue("clientId", out var clientId);
        queryParams.TryGetValue("redirectUrl", out var redirectUrl);
        var loginParams = new GetCoderRequest { ClientId = clientId, UserName = LoginModel.Account, PassWord = LoginModel.Password };
        //var document = await AjaxService.InvokeAsync(new AjaxOption()
        //{
        //    Url = "/api/sso/code",
        //    Data = loginParams,
        //});

        //if (document?.RootElement.GetProperty("code").GetInt32() == 2000)
        //{
        //    await AjaxService.Goto($"{redirectUrl}?authCode={code}&sessionCode={code}");
        //}

        var response = await SsoService.GetCodeAsync(loginParams);
        if (response!.Code == ResponseCode.Success)
        {
            await JSRuntime.InvokeVoidAsync("setCookie", "SessionCode", response.Data, 24 * 60 * 60, "/");
            await AjaxService.Goto($"{redirectUrl}?authCode={response.Data}&sessionCode={response.Data}");
        }
        else
        {
            await SwalService.Show(new SwalOption()
            {
                Category = SwalCategory.Error,
                //Content = document?.RootElement.GetProperty("message").GetString() ?? "登录失败",
                Title = "登录失败"
            });
        }
    }

}

