using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllTask
{
    interface IMovable
    {
        Position position { get; set; }
        float speed { get; set; }
        void Move(int x,int y);
        void Move();
    }
}
