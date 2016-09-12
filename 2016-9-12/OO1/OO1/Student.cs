using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1
{
    //实现了多个接口
    //类只能继承一个
    class Student:Person
    {
        public void Hello() 
        {
            Console.WriteLine("哈哈哈哈哈哈哈哈");
        }
        public void Study() 
        {
            base.Hello();
            Console.WriteLine("好好学习 天天向上");
        }
        public Student(string a):base(a)
        {
        }
    }
}
