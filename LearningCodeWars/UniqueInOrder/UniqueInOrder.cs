using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements
/// with the same value next to each other and preserving the original order of elements.
/// </summary>
namespace LearningCodeWars.UniqueInOrder
{
    public static class UniqueInOrder
    {
        public static IEnumerable<T> GetUniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> listOfObjects = new();
            listOfObjects.AddRange(from T item in iterable
                                   select item);

            for (int i = 0; i < listOfObjects.Count - 1;)
            {
                if (listOfObjects[i].Equals(listOfObjects[i + 1]))
                {
                    listOfObjects.RemoveAt(i + 1);
                }
                else
                {
                    i++; // increment only if elements are not the same
                }
            }

            return listOfObjects;
        }

        /// <summary>
        /// Another solution from Codewars
        /// </summary>
        public static IEnumerable<T> GetUniqueInOrderUsingLinq<T>(IEnumerable<T> iterable)
        {
            T previous = default;

            foreach (var current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }

        /// <summary>
        /// Another solution from Codewars
        /// </summary>
        public static IEnumerable<T> GetUniqueInOrderUsingForEach<T>(IEnumerable<T> iterable)
        {
            var retlist = new List<T>();
            foreach (var item in iterable)
            {
                if (!item.Equals(retlist.LastOrDefault()))
                {
                    retlist.Add(item);
                }
            }
            return retlist;
        }

        /// <summary>
        /// Another solution from Codewars
        /// </summary>
        public static IEnumerable<T> GetUniqueInOrderUsingGetEnumerator<T>(IEnumerable<T> iterable)
        {
            var e = iterable.GetEnumerator();
            if (e.MoveNext())
            {
                var current = e.Current;
                while (e.MoveNext())
                {
                    if (!e.Current.Equals(current))
                    {
                        yield return current;
                        current = e.Current;
                    }
                }
                yield return current;
            }
        }
    }
}