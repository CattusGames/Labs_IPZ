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
        private bool setPos = false;
        public void Move(int x, int y, bool right)
        {
            if (setPos)
            {
                if (right)
                {
                    position.y += 1;
                }
                else
                {
                    position.y -= 1;
                }
            }
            else
            {
                position.x = x;
                position.y = y;
                setPos = true;
            }
            


        }

        public void Move()
        {
            
        }

        public void Move(int x, int y)
        {
        }
    }
}
