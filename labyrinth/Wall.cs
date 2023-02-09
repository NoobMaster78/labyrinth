using System;
using System.Collections.Generic;
using System.Text;

namespace labyrinth
{
    class Wall : MapSite
    {
        public Wall()
        {
        }
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}
