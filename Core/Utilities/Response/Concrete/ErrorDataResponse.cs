using Core.Utilities.Response.Abstract;

namespace Core.Utilities.Response.Concrete
{
    public class ErrorDataResponse<T> : BaseDataResponse<T>
    {
        public ErrorDataResponse() : base(false, default!) { }
        public ErrorDataResponse(string message) : base(false, default!, message) { }
    }
}
