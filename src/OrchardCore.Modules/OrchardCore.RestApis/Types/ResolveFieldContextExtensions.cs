﻿using GraphQL.Types;

namespace OrchardCore.RestApis.Queries
{
    public static class ResolveFieldContextExtensions
    {
        public static bool HasPopulatedArgument<TSource>(this ResolveFieldContext<TSource> source, string argumentName)
        {
            if (source.Arguments?.ContainsKey(argumentName) ?? false)
            {
                return !string.IsNullOrEmpty(source.Arguments[argumentName]?.ToString());
            };

            return false;
        }
    }
}
