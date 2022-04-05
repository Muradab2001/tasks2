using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran
            //metod -3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return edir
            //Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da yazin(method overloading)

            //tasks(5,7,8,14,18);
            #endregion
            #region task2
            //Gonderilmis ededin reqemlerinin cemini qaytaran metod -misalcun bu metodu 
            //call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
            //Console.WriteLine("1 ci ededi daxil edin");
            //string b = Console.ReadLine();
            //int sayi1 = int.Parse(b);
            //task(sayi1);
            #endregion
            #region task3
            //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir, 
            //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti verilmişdirsə 
            //ödəniləcək məbləği hesbalayan metod yazin -yəni metodunuz 
            //3 doubel parameter qebul edib en boyuk ikisinin cemini hesablayib qaytarmalidir
            try
            {
                Console.WriteLine("1 ci ededi daxil edin");
                string a = Console.ReadLine();
                double sayi1 = double.Parse(a);
                Console.WriteLine("2 ci ededi daxil edin");
                string b = Console.ReadLine();
                double sayi2 = double.Parse(b);
                Console.WriteLine("3 ci ededi daxil edin");
                string c = Console.ReadLine();
                double sayi3 = double.Parse(c);
                task(sayi1, sayi2, sayi3);
            }
            catch (Exception)
            {

                Console.WriteLine("ancaq reqem daxil edin");
            }
            
            #endregion
        }

        #region task1
        // static int tasks(int sayi1, int sayi2, int sayi3)
        //{
        //    int result = 0;

        //    if (sayi1 > sayi2 && sayi1 > sayi3)
        //    {

        //        Console.WriteLine(sayi1);
        //        result = sayi1;
        //    }
        //    else if (sayi2 > sayi1 && sayi2 > sayi3)
        //    {
        //        Console.WriteLine(sayi2);
        //        result = sayi2;
        //    }
        //    else if (sayi3 > sayi1 && sayi3 > sayi2)
        //    {
        //        Console.WriteLine(sayi3);
        //        result = sayi3;
        //    }
        //    return result;



        //}
        //static int tasks(int sayi1,int sayi2, int sayi3, int sayi4)
        //{

        //    int code = tasks(sayi1,sayi2,sayi3);
        //    int result = 0;
        //    if (code> sayi4)
        //    {
        //        Console.WriteLine(code);
        //        result = code;
        //    }
        //    else 
        //    {
        //        result = sayi4;
        //        Console.WriteLine(result);

        //    }
        //    return result;
        //}
        //static int tasks(int sayi1, int sayi2, int sayi3, int sayi4, int sayi5)
        //{
        //    int code1 = tasks(sayi1, sayi2, sayi3, sayi4);
        //    int result = 0;
        //    if (code1 > sayi5)
        //    {
        //        Console.WriteLine(code1);
        //        result = code1;
        //    }
        //    else
        //    {
        //        result = sayi5;
        //        Console.WriteLine(result);
        //    }
        //    return result;


        //}
        #endregion
        #region task2
        //static int task(int a)
        //{

        //    int sum = 0;
        //    int mod = 0;
        //    while (a>0)
        //    {
        //        mod = a % 10;
        //        sum = sum+mod;
        //        a = (a - mod) / 10;


        //    }
        //        Console.WriteLine(sum);
        //        return sum;
        //}
        #endregion
        #region task3
        static double task(double a,double b,double c)
        {
            double result = 0;
            if (a > b || a > c)
            {
                result +=a;
            }
            if (b > a || b > c)
            {
                result += b;
            }
            if (c > a || c > b)
            {
                result += c;
            }
            Console.WriteLine( result );
            return result;

        }
        #endregion


    }
}