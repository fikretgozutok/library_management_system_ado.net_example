using Core.Utilities.Response.Abstract;

namespace Core.Utilities.Response.Concrete
{
    public class SuccessDataResponse<T> : BaseDataResponse<T>
    {
        public SuccessDataResponse(T data) : base(true, data) { }
        public SuccessDataResponse(T data, string message) : base(true, data, message) { }
    }
}
