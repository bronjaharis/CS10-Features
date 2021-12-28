﻿namespace CS10Features.StructImprovements
{
    public struct Rectangle
    {
        //isn't allowed in before C#10
        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; init; }
        public int Width { get; init; }
    }
}
