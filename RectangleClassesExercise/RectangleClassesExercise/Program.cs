using System;

namespace RectangleClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle rechthoek = new rectangle(10, 12);
        }
        class rectangle
        {
            private float xWidth, yHeight;
            private float xSize, ySize;
            private string size;
            public rectangle(float x, float y)
            {
                this.yHeight = y;
                this.xWidth = x;
                xWidth = xSize;
                yHeight = ySize;
                size = "The X width and size = " + xWidth + ", the y height and size = " + yHeight + ".";
                Console.WriteLine(size);
            }
        }
    }
}
