using System;
using System.Collections.Generic;

namespace heap_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 67, 12, 45, 67, 23, 7, 2, 1 };
            list.HeapSort();
            list.ForEach(element => Console.WriteLine(element));

            var boxes = new List<Box> {
            new Box(4, 20, 14),
            new Box(12, 12, 12),
            new Box(8, 20, 10),
            new Box(6, 10, 2),
            new Box(2, 8, 4),
            new Box(2, 6, 8),
            new Box(4, 12, 20),
            new Box(18, 10, 4),
            new Box(24, 4, 18),
            new Box(10, 4, 16),
            new Box(10, 2, 10)};

            boxes.HeapSort(new BoxVolumeComparer());
            boxes.ForEach(element => Console.WriteLine($"{element} with volume: {element.Height * element.Width * element.Length}"));
        }
    }
}
