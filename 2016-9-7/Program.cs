using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject   //包
{
    
    struct ppp { }  // 定义一个结构体
    enum qqq { }    // 定义一个枚举
    class ooo { }   // 定义一个类
    //数值 int float double long short byte char 都是结构体
    //长度  字节
    //结构体 枚举 是值类型    类是引用类型
    class Program
    {
        
        //静态的函数不能调用非静态的
        //非静态的可以调用静态的
        static int AddNum(int a, int b) 
        {
            return a + b;
        }
        static int Sum(int[] a)
        {
            int s = 0;
            foreach (int i in a)
            {
                s += i;
            }
            return s;
        }
        static int GetThree(int[] a)
        {
            int s = 0;
            foreach (int i in a)
            {
                if (i % 3 == 0)
                    s++;
            }
            return s;
        }
        static int GetEven(int[] arr) 
        {
            int s = 0;
            int i = 0;
            do
            {
                if (arr[i] % 2 == 1)
                    s++;    
                i++;
            } while (i < arr.Length);
            return s;
        }
        static void printsome(int n) 
        {
            switch (n) 
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("byebye");
                    break;
                default:
                    Console.WriteLine("unknow");
                    break;
            }
        }
        

        //void 代表不需要return 具体的值
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 2, 3, 5 };
            //数组中奇数的个数
            Console.WriteLine(GetEven(arr));
            //求数组元素的和
            Console.WriteLine(Sum(arr));
            //数组中三的倍数个数
            Console.WriteLine(GetThree(arr));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(byte));
            
            string c = Console.ReadLine();//读取一行控制台输入
            int n = Convert.ToInt32(c);//字符串转数字
            printsome(n);//函数调用
            //1  你好
            //2  byebye
            //其他的   不知道


            //没有返回值用void 
            //return;  也是void 做返回值类型
            Console.ReadKey();
            
        }
    }
}
