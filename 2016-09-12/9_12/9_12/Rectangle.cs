using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_12
{
    class Rectangle
    {
        float w = 2;//对于数值 类型的数据 不赋值，有默认值 0
        float h = 4;
        //C#构造函数
        public Rectangle(float www,float hhh) 
        {
            this.width = www;
            this.height = hhh;
        } 


        public float height 
        {
            get
            {
                return this.h;
            }
            set
            {
                this.h = value < 0 ? 0 : value;
                //if (value < 0)
                //    this.h = 0;
                //else 
                //    this.h = value;
            }
        }
        public float width
        {
            get 
            {
                return this.w;
            }
            set 
            {
                this.w = value < 0 ? 0 : value;
            }
        }

        public float Area() 
        {
            return this.w * this.h;
        }
        public float this[string s]
        {
            get 
            {
                if (s == "w")
                    return this.width;
                if (s == "h")
                    return this.height;
                return -1;//隐式转换  int->float
            }
            set 
            {
                if (s == "w")
                    this.width = value;
                if (s == "h")
                    this.height = value;
            }
        }

        public static void Flip(ref float www, ref float hhh) 
        {
            float tmp = www;
            www = hhh;
            hhh = tmp;
        }

        public void swap() 
        {
            Flip(ref this.w,ref this.h);
        }

    }
}
