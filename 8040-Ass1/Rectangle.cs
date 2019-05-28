﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8040_Ass1
{
    public class Rectangle
    {
        private int length;
        private int width;
        Rectangle()
        {
            length = 1;
            width = 1;
        }
        Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
