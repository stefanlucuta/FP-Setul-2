using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_FP_Setul2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Alege o problema : ");
            Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n.");
            Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.");
            Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.");
            Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine("8. Determinati al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
            Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");
            Console.WriteLine("13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("16. ");
            Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ");
            switch (Console.ReadLine())
            {

                case "1":
                    {
                        Console.WriteLine("Dati un numar n de numere : ");
                        int n = int.Parse(Console.ReadLine());
                        int contor = 0;
                        Random rnd = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            int x = rnd.Next();
                            if (x % 2 == 0)
                                contor++;
                        }
                        Console.WriteLine($"In secventa data sunt {contor} numere pare ");
                        return false;
                    }
                case "2":
                    {
                        Console.WriteLine("Dati un numar n de numere : ");
                        int n = int.Parse(Console.ReadLine());
                        int nrneg, nrpoz, zero;
                        nrneg = 0;
                        nrpoz = 0;
                        zero = 0;
                        Random rnd = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            int x = rnd.Next();
                            if (x == 0)
                                zero++;
                            else
                                if (x > 0)
                                nrpoz++;
                            else
                                nrneg++;
                        }
                        Console.WriteLine($"In secventa data sunt {nrneg} numere negative , {nrpoz} numere pozitive si {zero} zerouri ");
                        return false;
                    }
                case "3":
                    {
                        Console.WriteLine("Alegeti un numar n : ");
                        int n = int.Parse(Console.ReadLine());
                        int produs = 1;
                        int suma = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            produs *= i;
                            suma += i;
                        }
                        Console.WriteLine($"Produsul numerelor de la 1 la {n} este {produs} ,iar suma acestora este {suma}");

                        return false;
                    }
                case "4":
                    {
                        Console.WriteLine("Alegeti lungimea secventei : ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Alegeti numarul pe care doriti sa il cautati : ");
                        int a = int.Parse(Console.ReadLine());
                        Random rnd = new Random();
                        int pozitie = -1;
                        for (int i = 0; i < n; i++)
                        {
                            int x = rnd.Next();
                            if (x == a)
                            {
                                pozitie = i;
                                break;
                            }
                        }
                        if (pozitie == -1)
                            Console.WriteLine($"Numarul {a} nu se afla in secventa ");
                        else
                            Console.WriteLine($"Numarul {a} se afla pe pozitia {pozitie} ");
                        return false;
                    }
                case "5":
                    {
                        Console.WriteLine("Alegeti lungimea secventei : ");
                        int n = int.Parse(Console.ReadLine());
                        Random rnd = new Random();
                        int contor = 0;
                        for (int i = 0; i < n; i++)
                        {
                            int x = rnd.Next();
                            if (x == i)
                                contor++;
                        }
                        Console.WriteLine($"In secventa sunt {contor} numere egale cu pozitia in care se afla ");
                        return false;
                    }
                case "6":
                    {
                        Console.WriteLine("Alegeti lungimea secventei : ");
                        int n = int.Parse(Console.ReadLine());
                        Random rnd = new Random();
                        bool ok = true;
                        int x = rnd.Next();
                        int y;
                        for (int i = 0; i < n; i++)
                        {
                            y = rnd.Next();
                            if (y < x)
                            {
                                ok = false;
                                break;
                            }
                            else
                                x = y;
                        }
                        if (ok)
                            Console.WriteLine("Numerele sunt in ordine crescatoare ");
                        else
                            Console.WriteLine("Numerele NU sunt in ordine crescatoare");
                        return false;
                    }
                case "7":
                    {
                        Console.WriteLine("Alegeti lungimea secventei : ");
                        int n = int.Parse(Console.ReadLine());
                        Random rnd = new Random();
                        int min, max;
                        int x = rnd.Next(10);
                        min = x;
                        max = x;
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(x + " ");
                            x = rnd.Next(10);
                            if (min > x)
                                min = x;
                            if (max < x)
                                max = x;
                        }
                        Console.WriteLine($"Minimul din secventa este {min} , iar maximul este {max} ");
                        return false;
                    }
                case "8":
                    {
                        Console.Write("n = ");
                        int b, a, nr_0;
                        int n = int.Parse(Console.ReadLine());
                        nr_0 = 1;
                        a = 1;
                        b = 0;
                        for (int i = 3; i < n; i++)
                        {
                            b = a + nr_0;
                            nr_0 = a;
                            a = b;
                        }
                        Console.WriteLine($"Al {n}-lea termen este {b}");
                        return false;
                    }
                case "9":
                    {
                        int n = int.Parse(Console.ReadLine());
                        int a = int.Parse(Console.ReadLine());
                        int dir = 0;
                        int i = 1;
                        while (i < n && dir < 2)
                        {
                            int b = int.Parse(Console.ReadLine());
                            if (b > a)
                                if (dir < 0)
                                    dir = 2;
                                else
                                    dir = 1;
                            else if (b < a)
                                if (dir > 0)
                                    dir = 2;
                                else
                                    dir = -1;
                            a = b;
                            i++;
                        }
                        if (dir < 2)
                            Console.WriteLine("Da");
                        else
                            Console.WriteLine("Nu");
                        return false;

                    }
                case "10":
                    {
                        Console.Write("n= ");
                        int n = int.Parse(Console.ReadLine());
                        int contor1 = 1;
                        int contor_max = 1;
                        int x = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n - 1; i++)
                        {
                            int y = int.Parse(Console.ReadLine());
                            if (y == x)
                            {
                                contor1++;
                                if (contor1 > contor_max)
                                    contor_max = contor1;
                            }
                            else
                            {
                                x = y;
                                contor1 = 1;
                            }

                        }
                        Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {contor_max}");
                        return false;
                    }
                case "11":
                    {
                        Console.Write("n= ");
                        int n = int.Parse(Console.ReadLine());
                        int suma = 0;
                        for (int i = 0; i < n; i++)
                        {
                            int ogl = 0;
                            int uc = 0;
                            int x = int.Parse(Console.ReadLine());
                            while (x != 0)
                            {
                                uc = x % 10;
                                ogl = ogl * 10 + uc;
                                x /= 10;
                            }
                            suma = suma + ogl;
                        }
                        Console.WriteLine($"Suma inverselor numerelor este {suma}");
                        return false;
                    }
                case "12":
                    {
                        Console.Write("n= ");
                        int n = int.Parse(Console.ReadLine());
                        int contor = 0;
                        int x = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n - 1; i++)
                        {
                            int y = int.Parse(Console.ReadLine());
                            if (x != 0 && y == 0)
                                contor++;
                            x = y;

                        }
                        Console.WriteLine($"In secventa data sunt {contor} grupuri de numere");
                        return false;
                    }
                case "13":
                    {
                        Console.Write("n= ");
                        int n = int.Parse(Console.ReadLine());
                        int primul = int.Parse(Console.ReadLine());
                        int ultimul = primul;
                        int descrescator = 0;
                        for (int i = 0; i < n - 1; i++)
                        {
                            int curent = int.Parse(Console.ReadLine());
                            if (curent < ultimul || curent == ultimul)
                            {
                                descrescator++;
                            }
                            ultimul = curent;
                        }
                        if (ultimul > primul)
                            descrescator++;
                        if (descrescator == 1 || descrescator == 0)
                            Console.WriteLine("Secventa poate fi o secventa crescatoare rotita");
                        else
                            Console.WriteLine("Secventa nu poate fi o secventa crescatoare rotita");

                        return false;
                    }
                case "14":
                    {

                        return false;
                    }
                case "15":
                    {
                        Console.WriteLine("Introduceti n : ");
                        int n = int.Parse(Console.ReadLine());
                        int directie = 0;
                        int directie_noua = 0;
                        int x = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n - 1; i++)
                        {
                            int y = int.Parse(Console.ReadLine());
                            if (y >= x)
                            {
                                if (directie_noua != -1 || y == x)
                                    directie = 1;
                                else
                                {
                                    directie = 0;
                                    break;
                                }
                            }
                            else
                                if (y <= x)
                            {
                                directie_noua = -1;
                            }
                            x = y;
                        }
                        if (directie != 0)
                            Console.WriteLine("Secventa este bitonica ");
                        else
                            Console.WriteLine("Secventa nu este bitonica ");
                        return false;
                    }
                case "17":
                    {
                        //0-paranteza deschisa
                        //1-paranteza inchisa
                        Console.Write("n= ");
                        int n = int.Parse(Console.ReadLine());
                        int ok = 0;
                        int incuibare = 0;
                        int incuibare_max = 0;
                        while (n != 0)
                        {
                            int x = int.Parse(Console.ReadLine());
                            if (x == 0)
                            {
                                ok++;
                                incuibare++;
                            }
                            else
                                if (x == 1)
                            {
                                ok--;
                                incuibare--;
                            }
                            if (incuibare > incuibare_max)
                                incuibare_max = incuibare;
                            n--;
                            if (ok == -1)
                                break;
                        }
                        if (ok == 0)
                            Console.WriteLine($"Este reprezentata o secventa de paranteze corecte si are nivelul maxim de incuibare {incuibare_max}");
                        else
                            Console.WriteLine("Nu este reprezentata o secventa de paranteze corecte ");

                        return false;
                    }


                default:
                    {
                        Console.WriteLine("Nu ati ales nicio problema din cele enumerate mai sus ");
                        return false;
                    }
                    Console.ReadKey();
            }
        }
    }
}
