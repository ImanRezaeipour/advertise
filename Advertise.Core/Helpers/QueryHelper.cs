using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Advertise.Core.Helpers
{
    internal static class QueryHelper
    {
        #region Public Methods

        public static Expression<Func<T, string>> GetPropertyExpression<T>(string propertyName)
        {
            if (typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) == null)
            {
                return null;
            }

            var paramterExpression = Expression.Parameter(typeof(T));

            return (Expression<Func<T, string>>)Expression.Lambda(Expression.PropertyOrField(paramterExpression, propertyName), paramterExpression);
        }

        public static Expression<Func<T, int>> GetPropertyExpressionInt<T>(string propertyName)
        {
            if (typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) == null)
            {
                return null;
            }

            var paramterExpression = Expression.Parameter(typeof(T));

            return (Expression<Func<T, int>>)Expression.Lambda(Expression.PropertyOrField(paramterExpression, propertyName), paramterExpression);
        }

        public static bool PropertyExists<T>(string propertyName)
        {
            return typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) != null;
        }

        #endregion Public Methods
    }
}