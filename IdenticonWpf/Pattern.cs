using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdenticonWpf
{
    class Pattern
    {
        //1 d0,0,0 d1,0,0 d2,0,1 d2,1,1 d2,2,2 d1,2,2 d0,2,3 d0,1,3
        //2 d0,0,0 d1,0,0 p2,0,0,2 d0,2,3 d0,1,3
        //3 p0,2,1,0 p1,0,2,2 d2,2,2 d1,2,2
        //4 d0,0,0 p1,0,1,2 d1,2,2 d0,2,3 d0,1,3
        //5 p1,0,2,1 p2,1,1,2 p1,2,0,1 p0,1,1,0
        //6 p0,0,2,1 d2,1,1 d2,2,2 p1,2,0,0
        //7 p1,0,2,2 d2,2,2 p1,2,0.5,1 p0.5,1,1.5,1 p1.5,1,1,2 d1,2,2
        //8 p0,0,2,1 p2,1,1,2 p1,2,0,0
        //9 p0.5,0.5,1.5,0.5 p1.5,0.5,1.5,1.5 p1.5,1.5,0.5,1.5 p
        public Pattern(float x, float y)
        {

        }

        public string GenPoint(int x, int y)
        {
            return $"M{x} {y} h1 v1 h-1 v-1";
        }
    }
}
