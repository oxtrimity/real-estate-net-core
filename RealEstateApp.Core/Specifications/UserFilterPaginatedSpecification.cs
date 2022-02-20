using Ardalis.Specification;
using RealEstateApp.Core.Entities.UserAggregate;

namespace RealEstateApp.Core.Specifications;

public class UserFilterPaginatedSpecification : Specification<User>
{
    public UserFilterPaginatedSpecification(int skip, int take, int? userId)
        : base()
    {
        if (take == 0)
        {
            take = int.MaxValue;
        }
        Query
            .Where(i => !userId.HasValue).Skip(skip).Take(take);
    }
}
