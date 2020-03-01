namespace heap_sort
{
    public class Box
    {
        public int Height { get; }

        public int Length { get; }

        public int Width { get; }

        public Box(int height, int length, int width) =>
        (Height, Length, Width) = (height, length, width);


        public override string ToString() =>
            $"Height: {Height} Length: {Length} Width: {Width}";
    }
}
