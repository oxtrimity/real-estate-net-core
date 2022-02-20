using RealEstateApp.Core.Interfaces;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Services
{
    public interface IBaseService<T>
    {
        Task<int> Save(T model);
        Task<bool> Update(T model);
        Task<bool> Delete(int id);
    }
}