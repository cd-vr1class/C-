using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1
{
    class Person
    {
        public string name;
        //如果不写构造函数，会自动一个无参构造函数
        //如果写了构造函数，不会自动添加
        //要成为别人的父类，必须声明一个无参构造函数
        public Person(string nnn)
        {
            this.name = nnn;
        }
        public Person()
        {
        }
        public void Hello()
        {
            Console.WriteLine("hello ,My name is {0},How are you",this.name);
        }
    }
}
