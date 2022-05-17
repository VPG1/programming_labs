using System.Runtime.InteropServices;

namespace Task1
{
    public abstract class Shape
    {
        public int x { get; private set; }
        public int y { get; private set; }

        protected Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public virtual void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public abstract void Print();
    }
}