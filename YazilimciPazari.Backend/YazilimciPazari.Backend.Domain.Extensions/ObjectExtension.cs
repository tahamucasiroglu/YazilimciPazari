﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciPazari.Backend.Domain.Extensions
{
    static public class ObjectExtension
    {
        static public Dictionary<string, string> GetPropertyDict(this Type type)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (PropertyInfo item in type.GetProperties())
            {
                dict.Add(item.Name, item.PropertyType.ToString());
            }
            return dict;
        }

        static public bool IsNull(this object? obj)
        {
            return obj == null || obj == default;
        }
    }
}
