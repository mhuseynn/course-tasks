using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tasks
{
    //Task1
    internal class Point
    {
        public int x { get; set; }
        public int y { get; set; }


        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void show_data()
        {
            Console.WriteLine($"x = {x} , y = {y}");
        }

        public override string ToString()
        {
            return $"x = {x} , y = {y}";
        }

    }


    //Task2
    public class Counter
    {
        public int min { get; set; }
        public int max { get; set; }
        private int current;



        public Counter()
        {
            min = 0;
            current = 0;
            max = 100;
        }

        public Counter(int min, int max)
        {
            this.min = min;
            current = 0;
            this.max = max;
        }


        public void increment()
        {
            if (current == max)
            {
                Console.WriteLine("it is max");
            }
            else
            {
                current++;
                Console.WriteLine("Increased");
            }
        }
        public void decrement()
        {
            if (current == min)
            {
                Console.WriteLine("it is min");
            }
            else
            {
                current--;
                Console.WriteLine("Decreased");
            }
        }

        public string get_current()
        {
            return $"Current = {current}";
        }
    }


    //Task3
    public class Fraction
    {

        private int _numerator;

        public int Numerator
        {
            get { return _numerator; }
            set
            {
                if (value >= 0)
                {
                    _numerator = value;
                }
            }
        }

        private int _denuminator;

        public int Denuminator
        {
            get { return _denuminator; }
            set
            {
                if (value > 0)
                {
                    _denuminator = value;
                }
                else
                    throw new Exception("0 is imposibble");
            }
        }

        public Fraction(int num, int den)
        {
            Numerator = num;
            Denuminator = den;
        }

        public Fraction multiply(Fraction fr)
        {

            int suret = _numerator * fr._numerator;
            int mexrec = _denuminator * fr._denuminator;
            Fraction newfr = new Fraction(suret, mexrec);
            newfr.simplify();
            return newfr;
        }
        public Fraction divide(Fraction fr)
        {

            int suret = _numerator * fr._denuminator;
            int mexrec = _denuminator * fr._numerator;
            Fraction newfr = new Fraction(suret, mexrec);
            newfr.simplify();
            return newfr;
        }
        public Fraction add(Fraction fr)
        {
            int suret = _numerator * fr._denuminator + fr._numerator * _denuminator;
            int mexrec = _denuminator * fr._denuminator;
            Fraction newfr = new Fraction(suret, mexrec);
            newfr.simplify();
            return newfr;
        }
        public Fraction minus(Fraction fr)
        {
            int suret = _numerator * fr._denuminator - fr._numerator * _denuminator;
            int mexrec = _denuminator * fr._denuminator;
            Fraction newfr = new Fraction(suret, mexrec);
            newfr.simplify();
            return newfr;
        }

        public void print()
        {
            Console.WriteLine(" " + _numerator);
            Console.WriteLine("----");
            Console.WriteLine(" " + _denuminator);
        }
        public void simplify()
        {
            int say;
            if (_numerator < _denuminator)
            {
                say = _numerator;
            }
            else
                say = _denuminator;

            for (int i = 2; i <= say; i++)
            {
                while (_numerator % i == 0 && _denuminator % i == 0)
                {
                    _numerator /= i;
                    _denuminator /= i;
                }
            }
        }

    };


    public class Program
    {
        static void Main()
        {
            //Counter c = new Counter(0, 100);
            //c.increment();
            //Console.WriteLine(c.get_current());
            //c.increment();
            //c.decrement();
            //Console.WriteLine(c.get_current());
            //c.decrement();
            //Console.WriteLine(c.get_current());

            Fraction fr = new Fraction(4, 1);
            Fraction fr2 = new Fraction(4, 1);
            fr.simplify();
            fr.print();

            Fraction fr3 = fr.add(fr2);
            Console.WriteLine();
            fr3.print();
        }

    }
}






