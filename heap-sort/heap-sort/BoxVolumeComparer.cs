using System.Collections.Generic;

namespace heap_sort
{
    public class BoxVolumeComparer : Comparer<Box>
    {
        public override int Compare(Box x, Box y)
        {
            if (x.Height * x.Length * x.Width < y.Height * y.Length * y.Width)
            {
                return 1;
            }

            return 0;
        }
    }
}
