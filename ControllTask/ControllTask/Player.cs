using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllTask
{
    public class Player : IMovable
    {
        public Position position { get; set; } = new Position { x = 5, y = 1 };
        public float speed { get; set; } = 2f;

        public void Move(int x, int y)
        {
            position.x += x;
            position.y += y;

        }

        public void Move()
        {
            
        }
    }
}
