using Ardalis.GuardClauses;
using RealEstateApp.Core.Entities.UserAggregate;
using RealEstateApp.Core.Exceptions;

namespace RealEstateApp.Core.Extensions;

public static class EntityGuards
{
    public static void NullEntity<T>(this IGuardClause guardClause, int entityId, T entity)
    {
        if (entity == null)
            throw new EntityNotFoundException(entity.GetType().Name, entityId);
    }


}
