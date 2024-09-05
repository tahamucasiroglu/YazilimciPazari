using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciPazari.Backend.Domain.Extensions
{
    static public class IEnumerableExtension
    {
        static public IEnumerable<T> ChangeAll<T>(this IEnumerable<T> values, Func<T, T> func)
        {
            foreach (T item in values)
            {
                yield return func(item);
            }
        }
        static public IEnumerable<T> ChangeAll<T>(this IEnumerable<T> values, Action<T> action)
        {
            foreach (var item in values)
            {
                action(item);
                yield return item;
            }
        }
    }
}
