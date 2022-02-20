using Ardalis.Specification;
using RealEstateApp.Core.Services;

namespace RealEstateApp.Core.Interfaces;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
