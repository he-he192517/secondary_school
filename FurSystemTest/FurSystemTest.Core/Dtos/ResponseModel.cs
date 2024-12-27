namespace FurSystemTest.Core.Dtos
{
    /// <summary>
    /// 响应结果
    /// </summary>
    public class ResponseModel
    {
        //响应状态码
        public ResponseCode Code { get; set; }
        /// <summary>
        /// 响应消息
        /// </summary>
        public string Message { get; set; }
    }
    /// <summary>
    /// 有对象的响应结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseModel<T>:ResponseModel
    {
        public T Data { get; set; }
    }

    public enum ResponseCode
    {
        Success=0,
        Fail=1
    }

    public static class ResponseExtend
    {
        public static ResponseModel SetSuccess(this ResponseModel response, string message = "")
        {
            var result = new ResponseModel
            {
                Code = ResponseCode.Success,
                Message = message == string.Empty ? "操作成功" : message
            };
            return result;
        }
        public static ResponseModel<T> SetSuccess<T>(this ResponseModel<T> response,T data=default(T), string message = "")
        {
            response.Code= ResponseCode.Success;
            response.Message = message == string.Empty ? "操作成功" : message;
            response.Data = data;
            return response;
        }
        public static ResponseModel SetFail(this ResponseModel response, string message = "")
        {
            response.Code = ResponseCode.Fail;
            response.Message = message == string.Empty ? "操作失败" : message;
            return response;
        }
        public static ResponseModel<T> SetFail<T>(this ResponseModel<T> response, string message = "", T data = default(T))
        {
            response.Code = ResponseCode.Fail;
            response.Message = message == string.Empty ? "操作成功" : message;
            response.Data = data;
            return response;
        }

    }
}
