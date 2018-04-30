using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApplication3
{
    class Program
    {
        static int k = 1;
        static BigInteger p1;
        static BigInteger p2;
        //static BigInteger p3;
        static BigInteger ell;

        static BigInteger szumP = 0;
        static int digits = 10;


        static void Main(string[] args)
        {
            while (true)
            {
                szum();
                Console.WriteLine(divide(1, divide(BigInteger.Multiply(2, gyok(2)), 9801)));
                digits++;
                Console.ReadKey();
            }
        }

        static void szum()
        {
            do
            {
                ell = szumP;
                p1 = (fakt(4 * k)) * (1103 + (26390 * k));
                p2 = BigInteger.Multiply(BigInteger.Pow(fakt(k), 4), BigInteger.Pow(396, 4 * k));
                szumP += divide(p1, p2);
                k++;
            } while (ell != szumP);
            
            
        }

        static BigInteger fakt(int faktszam)
        {
            BigInteger _tag = 1;

            for (int i = 1; i <= faktszam; i++)
            {
                _tag = BigInteger.Multiply(_tag, i);
            }
            return _tag;
        }

        static BigInteger divide(BigInteger szamlalo, BigInteger nevezo)
        {
            string eredmeny = "";
            BigInteger maradek;
            string nulla = string.Empty;
            bool vesszo = true;

            for (int i = 0; i < digits; i++)
            {
                eredmeny += Convert.ToString(BigInteger.DivRem(szamlalo, nevezo, out maradek));
                /*Console.WriteLine(eredmeny);
                Console.WriteLine(maradek);*/
                //alma = maradek;
                if (vesszo == true)
                {
                    eredmeny += ",";
                    vesszo = false;
                }
                nulla = Convert.ToString(maradek);
                nulla = nulla + "0";
                szamlalo = BigInteger.Parse(nulla);
            }
            return szamlalo = BigInteger.Parse(eredmeny);
            /*Console.WriteLine(eredmeny);
            Console.ReadKey();*/
        }

        static BigInteger gyok(BigInteger gyok)
        {
            BigInteger _p2;
            BigInteger _temp;
                do
                {
                    _temp = gyok;
                    gyok = BigInteger.Subtract(BigInteger.Multiply(gyok, gyok), gyok);
                    _p2 = BigInteger.Multiply(2, gyok);
                    gyok = BigInteger.Subtract(gyok, divide(gyok, _p2));
                    /*gyok = gyok - ((gyok * gyok - gyok) / (2 * gyok));
                   Console.WriteLine(gyok);
                   Console.ReadKey();*/
                } while (_temp != gyok);
            return gyok;
        }
    }
}
