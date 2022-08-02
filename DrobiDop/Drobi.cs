using System;
using System.Collections.Generic;
using System.Text;

namespace DrobiDop
{
    internal class Drobi
    {
        public int _N;
        public int _D;

        public Drobi(int numerator, int denominator)
        {
            _N = numerator;
            _D = denominator;
        }

        public Drobi(int num) : this(num, 1)
        {
        }

        public override string ToString()
        {
            return string.Format($"{_N}/{_D}");
        }

        public static Drobi operator +(Drobi f1, Drobi f2)
        {
            return new Drobi(f1._N * f2._D + f2._N * f1._D, f1._D * f2._D).Normalization();
        }

        public static Drobi operator *(Drobi f1, Drobi f2)
        {
            return new Drobi(f1._N * f2._N, f1._D * f2._D).Normalization();
        }

        public static Drobi operator -(Drobi f1, Drobi f2)
        {
            return new Drobi(f1._N * f2._D - f2._N * f1._D, f1._D * f2._D).Normalization();
        }

        public static Drobi operator -(Drobi f1)
        {
            return new Drobi(-f1._N, f1._D).Normalization();
        }

        public static Drobi operator /(Drobi f1, Drobi f2)
        {
            return new Drobi(f1._N * f2._D, f1._D * f2._N).Normalization();
        }

        public Drobi Normalization()
        {
            var n = Math.Abs(_N);
            var d = Math.Abs(_D);
            var nod = NOD(n, d);
            var sign = Math.Sign(_N * _D);
            return new Drobi(sign * n / nod, d / nod);
        }

        static int NOD(int a, int b)
        {
            while (a > 0 && b > 0)
                if (a > b)
                    a %= b;
                else
                    b %= a;

            return a + b;
        }
    }
}
