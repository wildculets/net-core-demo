using System.Collections.Generic;

namespace heap_sort
{
    public static class ExtensionHeap
    {

        public static void HeapSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;

            collection.HeapBuild(collection.Count - 1, comparer);

            for (var index = collection.Count - 1; index >= 1; index--)
            {
                collection.Swap(0, index);
                collection.HeapSiftDown(0, index - 1, comparer);
            }

        }

        private static void HeapBuild<T>(this IList<T> collection, int lastIndex, Comparer<T> comparer)
        {
            var lastNodeWithChildren = lastIndex / 2;

            for (var node = lastNodeWithChildren; node >= 0; --node)
            {
                collection.HeapSiftDown(node, lastIndex, comparer);
            }
        }

        private static void HeapSiftDown<T>(this IList<T> collection, int nodeIndex, int lastIndex, Comparer<T> comparer)
        {
            var left = (nodeIndex * 2) + 1;
            var right = left + 1;
            var largest = nodeIndex;

            if (left <= lastIndex && comparer.Compare(collection[left], collection[largest]) > 0)
            {
                largest = left;
            }

            if (right <= lastIndex && comparer.Compare(collection[right], collection[largest]) > 0)
            {
                largest = right;
            }

            if (largest != nodeIndex)
            {
                collection.Swap(nodeIndex, largest);
                collection.HeapSiftDown(largest, lastIndex, comparer);
            }
        }
    }
}

