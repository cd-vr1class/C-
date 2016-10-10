using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //一个宽高2 4 矩形
            //一个宽高 3 3 矩形
            Rectangle t = new Rectangle(3,3);
            Console.WriteLine("t宽：{0} t高： {1}", t.width, t.height);
            Console.WriteLine("t面积： {0}", t.Area());
            Console.WriteLine("t宽：{0} t高： {1}", t["w"], t["h"]);

            Rectangle t1 = new Rectangle(2, 4);
            t1.height = -3;
            t1.swap();
            Console.WriteLine("t1宽：{0} t1高： {1}", t1.width, t1.height);
            Console.ReadKey();
        }
    }
}
