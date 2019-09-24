using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigement1
{
    public class RectangleClass
    {
        private int length1;
        private int width1;

        public RectangleClass()
        {
            length1 = 2;
            width1 = 2;

        }
        public RectangleClass(int length1, int width1)
        {
            this.length1 = length1;
            this.width1 = width1;

        }
        public int GetLength()
        {
            return length1;
        }
        public int SetLength(int length1)
        {
            this.length1 = length1;
            return this.length1;
        }
        public int GetWidth()
        {
            return width1;
        }
        public int Setwidth(int width1)
        {
            this.width1 = width1;
            return this.width1;
        }
        public int Getarea()
        {
            return (length1 * width1);
        }
        public int Getperimeter()
        {
            return 2 * (length1 + width1);
        }
    }
}
