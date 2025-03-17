﻿using Microsoft.Extensions.Logging;
using System;

namespace PollinationSDK
{
    internal static class LogUtils
    {
        private static string _namespaceName = System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType?.Namespace ?? "Unknown Namespace";
        private static string _className = System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType?.Name ?? "Unknown Class";
        private static string _logCatagory = $"{_namespaceName}.{_className}";

        private static Pollination.LogHelper? _helper;
        internal static Pollination.LogHelper Helper => _helper ??= new Pollination.LogHelper(_logCatagory);

        internal static ILogger GetLogger<T>() => Helper.GetLogger<T>();
        internal static ILogger GetLogger(Type type) => Helper.GetLogger(type);
        internal static ILogger GetLogger(string catName) => Helper.GetLogger(catName);

        internal static ILogger Logger => GetLogger(_logCatagory);
    }

}
