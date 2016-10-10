using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("张三");
            Console.WriteLine(stu.name);
            stu.Study();
            Console.ReadKey();
        }
    }
}
