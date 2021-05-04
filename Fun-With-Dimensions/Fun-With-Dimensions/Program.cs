﻿using System;

namespace FunWithDimensions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }


    }
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        //create a constructor
        public Cuboid(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        //complete this method
        public int Volume()
        {
            return length * width * height;
        }
        //complete this method
        public int Perimeter()
        {
            return 4 * (length + width + height);
        }
    }
}
