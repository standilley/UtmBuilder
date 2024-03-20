using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public static class ListExtension
    {
        public static void AddIfNotNull(
            this List<string> list,
            string key,
            string? value
            )
        {
            if(!string.IsNullOrEmpty(value))
                list.Add($"{key}={value}");
        }
    }
}
