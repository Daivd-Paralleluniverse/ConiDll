using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConiDll
{
    public class Judge//判断部分
    {
        public static double Camax(double a, double b, double c)//三个数中判断并取最大
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }
        public static double Camin(double a, double b, double c)//三个数中判断取最小
        {
            if (a < b && a < c)
                return a;
            else if (b < a && b < c)
                return b;
            else
                return c;
        }
    }
    public class Ext
    {
        public static Tuple<double,double> Sep()//分离小数部分和整数部分
        {
            //Console.WriteLine("请输入要转换的数字：");
            Console.Write("请输入待转换的数字：");
            string a = Console.ReadLine();
            int c = (int)Convert.ToDouble(a);
            double b = Convert.ToDouble(a) % 1;
            Tuple<double, double> tup = new Tuple<double, double>(c,b);
            return tup;
        }
        public static double For(int a1,int n)//定义两个整型变量
        {
            int sum = 0;
            for(int a=a1; a<=n; a++)//a<=n意味着在a1~n的范围内以1为中项连加
            {
                sum = sum + a;
            }
            return sum; 
        }
        public static double Rond(double a)//用来四舍五入
        {
            int a1=Convert.ToInt32(Math.Round(a, MidpointRounding.AwayFromZero));
            return a1;
        }
    }
}
