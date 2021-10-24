using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол с помощью целочисленных значений:\nВведите значение градусов:");
            int Gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение угловых минут:");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение угловых секунд:");
            int Sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели угол: {0} градусов, {1} минут, {2} секунд", Gradus, Min, Sec);
            //Console.ReadKey();
            Angle angle = new Angle();
            angle.Rad();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public Angle()
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Введите корректное значение градусов");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введите корректное значение минут");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Введите корректное значение секунд");
                }
            }
            get
            {
                return sec;
            }
        }
        public void Rad()
        {
            //«градусы + (минуты + секунды / 60) / 60
            double rad = (Gradus + (Min + Sec / 60) / 60) * Math.PI / 180;
            Console.WriteLine("Значение угла в радианах равно: {0}", rad);
            Console.ReadKey();
        }
    }
}
