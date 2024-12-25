using Core.DataAccess;
using Core.Entities;
using Core.Utilities.Response.Abstract;
using Core.Utilities.Response.Concrete;

namespace Core.Business
{
    public abstract class BaseEntityService<Tent, Trepo> 
        where Tent: BaseEntity, new()
        where Trepo : class, IRepository<Tent>, new()
    {
        Trepo _repository;
        public BaseEntityService(Trepo repository) => _repository = repository;
        public BaseDataResponse<IEnumerable<Tent>> GetAll()
        {
            try
            {
                var response = _repository.GetAll();

                return new SuccessDataResponse<IEnumerable<Tent>>(data: response);
            }catch (Exception ex)
            {
                return new ErrorDataResponse<IEnumerable<Tent>>(message: ex.Message);
            }
        }

        public BaseDataResponse<Tent> GetById(int id)
        {
            try
            {
                var response = _repository.Get(id);

                return new SuccessDataResponse<Tent>(data: response);
            }
            catch (Exception ex)
            {
                return new ErrorDataResponse<Tent>(message: ex.Message);
            }
        }

        public BaseResponse Add(Tent entity)
        {
            try
            {
                _repository.Add(entity);

                return new SuccessResponse();
            }
            catch (Exception ex)
            {
                return new ErrorResponse(message: ex.Message);
            }
        }

        public BaseResponse Update(Tent entity)
        {
            try
            {
                _repository.Update(entity);

                return new SuccessResponse();
            }
            catch (Exception ex)
            {
                return new ErrorResponse(message: ex.Message);
            }
        }

        public BaseResponse Delete(int id)
        {
            try
            {
                _repository.Delete(id);

                return new SuccessResponse();
            }
            catch (Exception ex)
            {
                return new ErrorResponse(message: ex.Message);
            }
        }
    }
}
