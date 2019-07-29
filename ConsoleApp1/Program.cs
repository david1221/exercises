using System;

namespace ConsoleApp1
{
    class Program
    {
        #region// 2) Amenamec yndhanur bajanarar
        static int LargestCD(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else return LargestCD(b, a % b);
        }
        #endregion
        #region // 3) tasakanic erkuakan

        static public void ConverterTwo(int n)
        {
            int temp = n % 2;
            Console.Write(temp);
            if (n > 1)
            {
                n /= 2;
                ConverterTwo(n);
            }
        }
        #endregion
        #region// 9) Gumari mutq u elq
        class Account
        {
            public delegate void Gumar(string a);

            public event Gumar GumarHanelis;
            public event Gumar GumarMutqAnelis;

            int gumarQanak;
            public Account(int sum)
            {
                this.gumarQanak = sum;
            }
            public int Nerka()
            {
                return gumarQanak;
            }
            public void MutqGumar(int mutqayin)
            {
                if (GumarMutqAnelis != null)
                {
                    gumarQanak += mutqayin;
                    GumarMutqAnelis.Invoke($" hashvin avelacav {mutqayin} ev nerka gumarn e {gumarQanak} dram");
                }
            }

            public void ElqHashvic(int elqayin)
            {
                if (elqayin >= -gumarQanak)
                {
                    gumarQanak += elqayin;
                    if
                        (GumarHanelis != null)
                    {
                        GumarHanelis.Invoke($" Dzerhashvic hanvec {elqayin} ev mnac {gumarQanak} dram");
                    }
                }
                else if (GumarHanelis != null)
                {
                    GumarHanelis($" Dzer hashvin chka { elqayin } drami chapov gumar ,ayl mnacel e {gumarQanak} chapov");
                }
            }
        }
        private static void MessegeInfo(string mess)
        {
            Console.WriteLine(mess);
        }
        #endregion
        #region   //10) Qarakusayin havasarum
        class Quadratic
        {
            public bool QuadraticEquation(int a, int b, int c, out double x1, out double x2)
            {
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    return true;
                }
                else
                {
                    x1 = 0; x2 = 0;
                    return false;
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region // 1) 10-i bazmapatik 
            while (true)
            {
                
                //meSpan
                // long a = ;
               

                Console.WriteLine("Write first number");
                int num1 = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine("Write second number");
                int num2 = int.Parse(Console.ReadLine()) + 1;

                int num3 = num1 * num2;
                int[] numArrayAll = new int[num3];
                int[] numArraySort = new int[num3];
                int[] numArrayFin10 = new int[num3];
                int[,] numArrayMulti = new int[num2, num1];
                //for TimeSpan
                DateTime dateTime1 = DateTime.Now;

                for (int i = 0; i < num2; i++)
                {
                    for (int m = 0; m < num1; m++)
                    {
                        numArrayMulti[i, m] = i * m;
                    }
                }
                int index = 0;
                for (int i = 0; i < num2; i++)
                {
                    for (int j = 0; j < num1; j++)      //multiplication table
                    {
                        numArrayAll[index] = numArrayMulti[i, j];
                        Console.WriteLine($"Tiv {i} * {j}  ardyunqum  {index} -erd andamy =  {numArrayMulti[i, j]}");
                        index++;
                    }
                }
                int num4 = 0;
                for (int k = 0; k < num3; k++)          //10-i bazmapatik tvery
                {
                    if ((((numArrayAll[k] % 10) == 0) && numArrayAll[k] != 0))
                    {
                        numArraySort[num4] = numArrayAll[k];
                        num4++;
                    }

                }
                int number1 = 0;
                for (int i = 0; i < num4; i++)  // veradasavorum
                {
                    for (int j = 0; j < num4; j++)
                    {
                        if (numArraySort[j] > numArraySort[j + 1])
                        {
                            number1 = numArraySort[j];
                            numArraySort[j] = numArraySort[j + 1];
                            numArraySort[j + 1] = number1;
                        }
                    }
                }
                // Array.Sort(numArraySort);    //veradsavorum
                int number2 = 0;
                for (int i = 1; i < num3-1; i++)      //chkrknvox bazmapatikner
                {
                    if (numArraySort[i + 1] != numArraySort[i] && numArraySort[i] != 0)
                    {
                        numArrayFin10[number2] = numArraySort[i];
                        number2++;
                    }
                }
                for (int i = 0; i < number2; i++)
                {
                    Console.WriteLine("Tivy {0}    {1}-rd andam 10i bazmapatik ", numArrayFin10[i], i + 1);
                }
                DateTime dateTime2 = DateTime.Now;
                
                //for TimeSpan
                TimeSpan dateTime = dateTime2 - dateTime1;
                long b = dateTime.Milliseconds;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThe process spends "+b+" milliseconds"); ;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }
            #endregion
            #region// 2) Amenamec yndhanur bajanarar
            //while (true)
            //{
            //    Console.WriteLine(" Write first number");
            //    int num1 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine(" Write second number");
            //    int num2 = Int32.Parse(Console.ReadLine());
            //    int num = LargestCD(num1, num2);
            //    Console.Write($" the largest common divisor {num1} and {num2} is ");
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write(num);
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    Console.WriteLine(); Console.WriteLine();
            //}
            #endregion
            #region     // 3) tasakanic ekuakan
            //while (true)
            //{
            //    int tasakan = Int32.Parse(Console.ReadLine());
            //    ConverterTwo(tasakan); Console.WriteLine();
            //}
            #endregion
            #region// 4) Tvanshanneri gumar
            //while (true)
            //{
            //    Console.WriteLine("Write Number");
            //    int num1 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("The number is {0}", num1);
            //    int a = num1, digit = 0, sum = 0;
            //    Console.Write("Digit : ");
            //    while (a > 0)
            //    {
            //        digit = a % 10;
            //        a /= 10;
            //        sum += digit;
            //        Console.Write(digit + ",");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine(sum);

            //}
            #endregion
            #region// 5) Maximumi pntrum
            //Random random = new Random();
            //int[] Arr = new int[50];
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Arr[i] =1000- random.Next()%2000;
            //    Console.Write(" " + Arr[i] + " ");
            //}
            //int max = 0;
            //for (int j = 0; j < Arr.Length; j++)
            //{
            //    if (max < Arr[j])
            //    {
            //        max = Arr[j];
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine(" Max number = "+max);
            //Console.ReadKey();
            #endregion
            #region            // 6) Tveri veradasavorum
            //int number = 50;
            //int[] numbers = new int[number];
            //Random random = new Random();
            //Console.WriteLine("Random numbers");
            //for (int i = 0; i < number; i++)
            //{
            //    numbers[i] = random.Next(-100, 100);
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();
            //int num1 = numbers[0];
            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number - 1; j++)
            //    {
            //        if (numbers[j] > numbers[j + 1])
            //        {
            //            num1 = numbers[j];
            //            numbers[j] = numbers[j + 1];
            //            numbers[j + 1] = num1;

            //        }
            //    }
            //}
            //Console.WriteLine("Sorted numbers");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(" " + numbers[i]);
            //}
            //Console.ReadKey();
            #endregion
            #region      // 7) Navaki harvacner
            //Console.WriteLine(new String('-', 20) + " Navaki harvacner " + new String('-', 20));
            //while (true)
            //{
            //    int[,] Field = new int[8, 8];
            //    Console.Write("Navi X = ");
            //    int y = Convert.ToInt32(Console.ReadLine()) - 1;
            //    Console.Write("Navi Y = ");
            //    int x = Convert.ToInt32(Console.ReadLine()) - 1;

            //    string a = "";
            //    if (x >= 0 && x < 8 && y >= 0 && y < 8)
            //    {
            //        for (int i = 0; i < 8; i++)
            //        {
            //            Field[x, i] = 1;
            //            Field[i, y] = 1;
            //        }
            //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        Console.WriteLine(" Y ");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        for (int i = 0; i < 8; i++)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Cyan;
            //            Console.Write(" " + (i + 1) + "   ");
            //            Console.ForegroundColor = ConsoleColor.Gray;
            //            for (int j = 0; j < 8; j++)

            //            {

            //                if (Field[i, j] == 1)
            //                {
            //                    if (i == x && j == y)
            //                    {
            //                        Console.ForegroundColor = ConsoleColor.Red;
            //                        a = Convert.ToString(Field[i, j]);
            //                        a = "R" + " ";
            //                        Console.Write(a);
            //                        Console.ForegroundColor = ConsoleColor.Gray;
            //                    }
            //                    else
            //                    {
            //                        Console.ForegroundColor = ConsoleColor.Cyan;
            //                        Console.Write(Field[i, j] + " ");
            //                        Console.ForegroundColor = ConsoleColor.Gray;
            //                    }
            //                }
            //                if (Field[i, j] != 1)
            //                {

            //                    {
            //                        Console.Write(Field[i, j] + " ");
            //                    }
            //                }
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        Console.WriteLine("  X  1 2 3 4 5 6 7 8");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        Console.WriteLine(new String('-', 50));
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("X and Y should be between 1-8"); Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //}

            #endregion
            #region // 8) Pxi harvacner
            //Console.WriteLine(new String('-', 20) + " Pxi harvacner " + new String('-', 20));
            //while (true)
            //{
            //    int[,] Filed = new int[8, 8];
            //    Console.Write("Navaki X = ");
            //    int y = Convert.ToInt32(Console.ReadLine()) - 1;
            //    Console.Write("Navaki Y = ");
            //    int x = Convert.ToInt32(Console.ReadLine()) - 1;
            //    string a = "";
            //    if (x >= 0 && x < 8 && y >= 0 && y < 8)
            //    {
            //        int xx = 0;
            //        int yy = 0;
            //        while (x + xx < 8 && y + yy < 8)//aj u nerqev
            //        {
            //            Filed[x + xx, y + yy] = 1;
            //            xx++; yy++;
            //        }

            //        xx = 0;
            //        yy = 0;
            //        while (x + xx < 8 && y - yy >= 0)//dzax u nerqev
            //        {
            //            Filed[x + xx, y - yy] = 1;
            //            xx++; yy++;
            //        }

            //        xx = 0;
            //        yy = 0;
            //        while (x - xx >= 0 && y - yy >= 0)//dzax u verev
            //        {
            //            Filed[x - xx, y - yy] = 1;
            //            xx++; yy++;
            //        }

            //        xx = 0;
            //        yy = 0;
            //        while (x - xx >= 0 && y + yy < 8)//aj u verev
            //        {
            //            Filed[x - xx, y + yy] = 1;
            //            xx++; yy++;
            //        }
            //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        Console.WriteLine(" Y ");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        for (int i = 0; i < 8; i++)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Cyan;
            //            Console.Write(" " +( i + 1) + "   ");
            //            Console.ForegroundColor = ConsoleColor.Gray;
            //            for (int j = 0; j < 8; j++)

            //            {

            //                if (Filed[i, j] == 1)
            //                {
            //                    if (i == x && j == y)
            //                    {
            //                        Console.ForegroundColor = ConsoleColor.Red;
            //                        a = Convert.ToString(Filed[i, j]);
            //                        a = "B" + " ";
            //                        Console.Write(a);
            //                        Console.ForegroundColor = ConsoleColor.Gray;
            //                    }
            //                    else
            //                    {
            //                        Console.ForegroundColor = ConsoleColor.Cyan;
            //                        Console.Write(Filed[i, j] + " ");
            //                        Console.ForegroundColor = ConsoleColor.Gray;
            //                    }
            //                }
            //                if (Filed[i, j] != 1)
            //                {

            //                    {
            //                        Console.Write(Filed[i, j] + " ");
            //                    }
            //                }
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        Console.WriteLine("  X  1 2 3 4 5 6 7 8");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        Console.WriteLine(new String('-', 50));
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("X and Y should be between 1-8"); Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //}
            #endregion
            #region   // 9) Gumari mutq u elq
            //Account account = new Account(10000);
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(" Hashvin arka gumari qanaky 10000 dram e");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //account.GumarMutqAnelis += MessegeInfo;
            //account.GumarHanelis += MessegeInfo;

            //Console.WriteLine(" Avelacnel gumar hasvin (Orinak +5000) kam hanel hashvic (Orinak -5000)");
            //while (true)
            //{
            //    int mutq = Convert.ToInt32(Console.ReadLine());
            //    //կանչում ենք մեթոդը որը պետք է ավելացնի գումարը և կանչի սաբիտիայի ինվոկը
            //    if (mutq > 0)
            //    {
            //        account.MutqGumar(mutq);
            //    }
            //    else if (mutq < 0)
            //    {
            //        account.ElqHashvic(mutq);
            //    }
            //    else if (mutq == 0)
            //    {
            //        Console.WriteLine(" Duq mutqagrel eq 0 ");
            //    }
            //}
            #endregion
            #region //10) Quadratic Equation (Qarakusayin havasarum)
            //while (true)
            //{
            //    int a, b, c; double x1; double x2;
            //    Console.WriteLine("a*x^2 + b*x+c=0");
            //    Console.WriteLine(" a= ");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" b= ");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" c= ");
            //    c = Convert.ToInt32(Console.ReadLine());
            //    Quadratic quadratic = new Quadratic();
            //    bool result = quadratic.QuadraticEquation(a, b, c, out x1, out x2);
            //    x1 = Math.Round(x1, 2); x2 = Math.Round(x2, 2);

            //    if (result == true)
            //    {

            //        if (x1 != x2)
            //        {
            //            Console.WriteLine($" x1 = {x1} , x2 = {x2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($" x = {x1} ");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("X = null");
            //    }

            //    Console.WriteLine($" {a}x^2+{b}x+{c}=0");
            //    Console.WriteLine(new string('-', 20));
            //}
            #endregion
            #region//11) n tvi tvanshanneri arandznacum
            //for (; ; )
            //{
            //    int n = 0;
            //    int number = Int32.Parse(Console.ReadLine());
            //    int numberN = number;
            //    //tvanshanneri qanak n
            //    while (numberN > 0)
            //    {
            //        n++;
            //        numberN /= 10;
            //    }
            //    int[] numbers = new int[n];
            //    int[] numbersN = new int[n];
            //    //tvanshanneri bajanum,hakarak hajordakanutyamb
            //    for (int i = 0; i < n; i++)
            //    {
            //        numbers[i] = number % 10;
            //        number /= 10;
            //    }
            //    //jisht hajordakanutyamb nerkayacum
            //    int m = 0;
            //    for (int i = n - 1; i > -1; i--)
            //    {
            //        numbersN[i] = numbers[m];
            //        m++;
            //    }
            //    // artatpum
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(" " + numbersN[i] + " ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine(new string('-', n * 3));
            //}
            #endregion





        }
    }
}