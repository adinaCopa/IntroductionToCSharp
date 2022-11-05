namespace Polymorphism_OperatorOverloading
{
    internal class Box
    {
        private int height;
        private int width;

        public Box(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public static Box operator + (Box box1, Box box2)
        {
            var newHeight = box1.height + box2.height;
            var newWidth = box1.width + box2.width;

            return new Box(newHeight, newWidth);
        }

        public string DisplayInfo()
        {
            return $"Box with h = {this.height}, w = {this.width}";
        }
    }
}
