using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static PropertyBuilder<TProperty> NewDateAutoInsertedOnCreate<TProperty>(this PropertyBuilder<TProperty> propertyBuilder, DateTimeKind dateTimeKind = DateTimeKind.Utc)
        {
            if (typeof(TProperty) == typeof(DateTime) || typeof(TProperty) == typeof(DateTime?))
            {
                propertyBuilder
                    .HasAnnotation("OnCreateGenerateValue", dateTimeKind == DateTimeKind.Utc ? DateTime.UtcNow : DateTime.Now);
            }

            return propertyBuilder;
        }

        public static PropertyBuilder<TProperty> NewDateAutoInsertedOnUpdate<TProperty>(this PropertyBuilder<TProperty> propertyBuilder, DateTimeKind dateTimeKind = DateTimeKind.Utc)
        {
            if (typeof(TProperty) == typeof(DateTime) || typeof(TProperty) == typeof(DateTime?))
            {
                propertyBuilder
                    .HasAnnotation("OnUpdateGenerateValue", dateTimeKind == DateTimeKind.Utc ? DateTime.UtcNow: DateTime.Now);
            }
            return propertyBuilder;
        }
    }
}
