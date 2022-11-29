using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllTask
{
    class Bullet : IMovable
    {
        public Position position { get; set; } = new Position { x = 0, y = 0 };
        public float speed { get; set; } = 3f;
        public void Move(int x, int y)
        {

        }

        public void Move()
        {
            
        }
    }
}
