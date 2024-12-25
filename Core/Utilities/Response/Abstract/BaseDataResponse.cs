namespace Core.Utilities.Response.Abstract
{
    public abstract class BaseDataResponse<T> : BaseResponse
    {
        public T Data { get; set; }

        public BaseDataResponse(bool isSuccess, T data) : base (isSuccess) => Data = data;
        
        public BaseDataResponse(bool isSuccess, T data, string message) : base (isSuccess, message) => Data = data;
    }
}
