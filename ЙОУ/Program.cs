using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace FistApp1
{
    internal class FileName
    {
        static void Main(string[] args)


        {
            string hi = @"

@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@::::@@::::@@@::::::::+@@::::@@@@@@::::@@@@@@@:::::::@@@@
@@::::@@::::@@@::::::::+@@::::@@@@@@::::@@@@@@::::::::::@@
@@::::@@::::@@@::::@@@@@@@::::@@@@@@::::@@@@@::::-@@::::@@
@@::::::::::@@@::::::::@@@::::@@@@@@::::@@@@@::::@@@::::@@
@@::::::::::@@@::::::::@@@::::@@@@@@::::@@@@@::::@@@::::@@
@@::::@@::::@@@::::@@@@@@@::::@@@@@@::::@@@@@::::@@@::::@@
@@::::@@::::@@@::::@@@@@@@::::@@@@@@::::@@@@@::::@@@::::@@
@@::::@@::::@@@:::::::::@@::::::::@@::::::::@@::::::::::@@
@@::::@@::::@@@:::::::::@@::::::::@@::::::::@@@::::::::@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


";
            Console.WriteLine(hi);
            Console.WriteLine("Операции");
            Console.WriteLine("__________________________");
            Console.WriteLine("Другое:");
            Console.WriteLine("1=Проверка Четности | 2=Пасхалки | 3=цикл | 4=sum| ");
            Console.WriteLine("__________________________");
            Console.WriteLine("Практика 3 :");
            Console.WriteLine("| 5 = средний бал | 6 =  сумма с условием | 7 = колво чисел | 8 = нули |");
            Console.WriteLine("__________________________");
            Console.WriteLine("Практика 4 :");
            Console.WriteLine("9 = Задание 1.4  | 10 = Задание 2.4      | 11 = Задание 3.4 | 12 = Задание 4.4 | 13 =   Задание 5.4 | 14 = Задание 6.4 ");
            Console.WriteLine("__________________________");
            Console.WriteLine("Практика 5 :");
            Console.WriteLine(" | 15 = мопс | 16 =  КОЛИЧЕСТВО ЧЕТВЕРОК | 17 = артур и друзья 1  | 18 =  друзья и артур 2 | 19 = обратное число |  ");
            Console.WriteLine(" | 20 = четные и кратные трiм | 21 = РАЗНОСТЬ ПОЛОЖИТЕЛЬНЫХ И ОТРИЦАТЕЛЬНЫХ ЧИСЕЛ | 22 = среденне зн последовательности | ");
            Console.WriteLine(" | 23 = КОЛВО ЭЛЕМ, КОТОРЫЕ БОЛЬШЕ ПРЕД | 24 = Измена знака  | ");
            Console.WriteLine("__________________________");
            Console.WriteLine(" \\ 25 = Работа на паре 21.10 \\");
            Console.WriteLine("Практика 6:");
            Console.WriteLine(" | 26 -34 | 35  ");
            Console.WriteLine("__________________________");
            Console.WriteLine(" \\ 35 = Работа на паре 19.10 \\");
            Console.WriteLine("__________________________");
            Console.WriteLine("__________________________");
            Console.WriteLine("  2 семестр ");
            Console.WriteLine(" 1 практика : от 36 до  42   ");




            string error = @"
                                      
                 *###                 
              ##########              
           ################           
       +######################+       
     ############   .############     
     ###########      ###########     
     ##########   ##   ##########     
     #########    =#    #########     
     ########      #     ########     
     #######              #######     
     ######       ##       ######     
     ####+                  #####     
     #####%%%%%%%%%%%%%%%%#%#####     
     %%########################%%     
       *%%##################%%*       
           %%%##########%%%           
              %%%#####%%              
                 ####                 
                                      

            
                                                                
";

            Console.WriteLine("Выберите операцию из списка :");
            Console.WriteLine("   ");




            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1)
            {
                Console.WriteLine("Введите A");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Здравствуйте");

                var result = number1 % 2;




                if (result == 0)
                {
                    Console.WriteLine("Четко ");
                }
                else
                {
                    Console.WriteLine("Не четно");
                }
            }
            else if (operation == 2)
            {
                Console.WriteLine("──────▄▌▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀​▀▀▀▀▀▀▌");
                Console.WriteLine("───▄▄██▌█");
                Console.WriteLine("▄▄▄▌▐██▌█     Coca Cola");
                Console.WriteLine("███████▌█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄​▄▄▄▄▄▄▌");
                Console.WriteLine("▀(@)▀▀▀▀▀▀▀(@)(@)▀▀▀▀▀▀▀▀▀▀▀▀▀​▀▀▀▀(@)");
            }
            else if (operation == 3)
            {
                string word = "цикл";
                Console.WriteLine("Напиши число");
                int counter = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < counter; i++)
                {

                    Console.WriteLine(i + " " + word);
                }

            }
            else if (operation == 4)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    sum += num;

                }
                Console.WriteLine($"Сумма всех чисел равна {sum}");

            }



            else if (operation == 5)
            {
                Console.WriteLine("Сколько всего оценок?");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Пиши оценки в строку");
                    int num = Convert.ToInt32(Console.ReadLine());
                    sum += num;
                }
                double average = (double)sum / n;
                Console.WriteLine("──────▄▌▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀​▀▀▀▀▀▀▌");
                Console.WriteLine("───▄▄██▌█   Ответ: ");
                Console.WriteLine($"▄▄▄▌▐██▌█   {average}");
                Console.WriteLine("███████▌█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄​▄▄▄▄▄▄▌");
                Console.WriteLine("▀(@)▀▀▀▀▀▀▀(@)(@)▀▀▀▀▀▀▀▀▀▀▀▀▀​▀▀▀▀(@)");


                //Console.WriteLine($"ну короч средний балл {average}");
            }

            else if (operation == 6)
            {
                Console.WriteLine("Скока");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("ВВоди");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num % 2 == 0 && num % 3 != 0)
                    {
                        sum += num;
                    }
                    Console.WriteLine("Ща");
                    Console.WriteLine(sum);
                }
            }




            else if (operation == 7)
            {

                if (!int.TryParse(Console.ReadLine(), out int n))
                {

                    return;
                }

                int countEndsInZero = 0;

                for (int i = 0; i < n; i++)
                {

                    string numberString = Console.ReadLine();

                    if (numberString != null && numberString.Length > 0)
                    {

                        if (numberString[numberString.Length - 1] == '0')
                        {
                            countEndsInZero++;
                        }


                    }
                }


                Console.WriteLine(countEndsInZero);

            }



            else if (operation == 8)
            {

                //if (!int.TryParse(Console.ReadLine(), out int n))
                //{

                //    return;
                //}


                //bool zeroFound = false;


                //for (int i = 0; i < n; i++)
                //{

                //    if (int.TryParse(Console.ReadLine(), out int number))
                //    {

                //        if (number == 0)
                //        {
                //            zeroFound = true;

                //            break;
                //        }
                //    }

                //}


                //if (zeroFound)
                //{
                //    Console.WriteLine("YES ДА");


                //}



                //else
                //{
                //    Console.WriteLine("NO НЕТ ");
                //}



                //2 способ
                //if (!int.TryParse(Console.ReadLine(), out int n))
                //{

                //    return;
                //}

                //bool zeroFound = true;


                //for (int i = 0; i < n; i++)
                //{
                //    if (int.TryParse(Console.ReadLine(), out int currentNumber))
                //    {
                //        if (currentNumber != 0)
                //        {
                //            zeroFound = false;
                //            break;
                //        }
                //    }
                //}

                //if (zeroFound)
                //{
                //    Console.WriteLine("No");
                //}
                //else
                //{
                //    Console.WriteLine("Yes");
                //}

                //3 способ
                //int n = Convert.ToInt32(Console.ReadLine());

                //for (int i = 0; i < n; i++)
                //{
                //    int num = Convert.ToInt32(Console.ReadLine());
                //    if (num == 0)
                //    {

                //        Console.WriteLine("YES");
                //        return;
                //    }
                //}

                //Console.WriteLine("NO");

                //4 попвтка
                int n = Convert.ToInt32(Console.ReadLine());
                int scetchik = 0;

                for (int i = 0; i < n; i++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 0)
                    {
                        scetchik++;
                    }
                }

                if (scetchik > 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }




            }

            else if (operation == 9)
            {

                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int s = a;
                if (a % 2 != 0)
                {
                    s = a + 1;
                }
                for (int i = s; i <= b; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            else if (operation == 10)
            {

                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                for (int i = b; i >= a; i--)
                {
                    Console.WriteLine(i);
                }
            }


            else if (operation == 11)
            {

                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i * i);
                }
            }

            else if (operation == 12)
            {

                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n + " * " + i + " = " + (n * i));
                }
            }

            else if (operation == 13)
            {

                int x = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        count++;
                    }
                    Console.WriteLine(count);

                }
            }

            else if (operation == 14)
            {

                int n = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    if (i % c == 0 && i % d != 0)
                    {
                        Console.WriteLine(i);
                    }
                }


            }

            else if (operation == 15)
            {
                {
                    string asciiArt = @"
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@@@@@@
@@@@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%%%%%%###%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
@@@@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##%%@@@@@%%%%%%%%%%%%%%%%%%%%%%%%%%@@@@@@@@@@@@@
@@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###%%%%%%%%%#####*#*#%%@@@@@@@@@@@%%%%%%%%%%%%%@%%%%%%%%%%%%%%%%%%%@@
%%%%%%%%%%%%%%%%%%%%%%%%%%%%########%%%%%%#==+*#%@@@@@@@@@@@@@@@@@@%%%%@%%%@@@@@%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%##########%%%%#==%%%%@@@@@@@@@@@@@@@@@@@@%%%@@@@@@@@%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###%#####+=--+*##%%%%%@@@@@@@@@@@@@@@%@%%@@@@@@@@###%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%###%%#*+++*=--------=-==+=+*###%%%@@@@@@@%@%@@@@@@@#%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%##%#%%####++=-----=++======-----:--:--+*####%%@@%%%@@@@@@#####%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%###+++===+=++====+=========----------==*#%%%%@%%%@@@@####%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%##*+=++=+++++**++##****+++=====-----------==+#@%#%%@@@@@#############%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%#+=++=--+*=+=+++*#***#******+======-----------=+*%####@@@@%##########%%%%%%%%
%%%%%%%%%%%%%%#**+=-==+===+=--=++**+++++##**++++++=+=-===+==-=-=---====+*%#####%%#########%%%#%%%%%%
%%%%%%%%%%%%%%#*+=+***+=--=+-=**++#%*+**#%*++++++*+***+++**+======++++++*#%####################%%%%%
%%%%%%%%%%%%%#*+===#%%#=-=+==**++**#%##*#%#**+*++#*+==++=++*****###*##***#%%%##################%%%%%
%%%%%%%%%%@%%#*+=+*%%#*--=+=+*#*++*#@%%###@#****#+*#####***###**#%#%%%%%###%%%##############%%%%%%%%
%%%%%%%%%%%%%#*++#@%%%=-==+**#*++++*%%#%%%%@%##%*+**####*#*##%@@@@@@@@@@%###**#########%%##%%%%%%%%%
%%%%%%%@@@@%%#**#@#%@*====++***++****#%###*#****++*+*#%%@###@%##%@@@%#@@@%#*+++###########%%%%%%%%%%
%%%%%%%@@@%%###%%%@@*---===++*++********##*##*+*#++***%@%%##%++=%@@@%@%@%%#+==+*#########%%%%%%%%%%%
%%%%%%%@@@@%%%%@@@@*-----=+=++++*#####****%#**%@%****###%%%%%%@@@@@@%@@@%%%#==++*#######%%%%%%%%%%%%
%%%@%%%@@@%%%%@@@@#=----====+++==++++++*###@@#***#*##%%%%%@@%%%@@@@@@@@@%%%##*=+*#%##%#%%%%%%%%%%%%%
%%@@%%@@@%%%%@@@@%=---:--===++-=*%****++*@%*#%#*#%%%%%%%####*#%%#%%%@@@@%%%#*****#%%###%%%%%%%%%%%%%
%@@@%%@@@@%%%@@@@#--::::-==+*==##*#*****#@%#*#%%@#%%%#%%@@@%%##%%%%@@@@@@%%#*+***#%%%###%%%%%%%%%%%%
@@@@%%@@@@%%%@@@@+---::--=+=+*##*%%%####%%#%@@%%##*@@#%@@#*++**##%%%%@@@%%%#*++**%@@%##%%%%%%%%%%%%%
@@@@%%@@%%%%%@@@#----:-=+=+*#####%%%%%#%%#%%@#@%**#%@@@%%%##*+**+**#%@@@#*####**#%@@%%%%%%%%%%%%%%%%
@@@@%%%%%%%%%%@@+-------=++****#%%#%%%%%%%@@%*#@@#@%%%#%%####**++*##*##%%###%%##%@@@%%%%%%%%%%%%%%%%
%@@@@@%%%%%%%@@%=-----===*#%@@@%%%%%%%%%%@@@%@@@%%%@%#@%%#####*+*+****###%##%%%%%@@@@%%%%%%%%%%%%%%%
%%@@@@@@@@@%%%@#+==---==+##@@%@-=%%#%%%##%%##%%%%#%%%%##########+++==+*#%%%%%%#%%@@@@%%%#%%%%%%%%%%%
%%%@@@@@@@@%%%@@%*=-===**%@@%%%%%@@@%####@**####%%###%####*######*+=**##%%#*#%@@@@@@%%%##%%%%%%%%%%%
%%%%@@@@@@@%%%@@%#+=+++*%@@@%%%%@@@@%#%#@#***#########@%%%%%%%%%*++=++*#%%%%%%%@@@@%%%%%%%%%%%%%%%%%
%%%%%%@@@@@@%%@@%%#*++++%@@@%@%%%@@%%%%%%*+*+##*##*#%%@%##%%%%%%##*+*+*#%%@@@@%@@@%%%%%###%%%%%%%%%%
%%%%%%%%@@@@%%@%%%@#***+**#%%%%@%%@@@%%%#**=+**####%#%###%#%#%%###%###%%@@@@@%%@@%###%%#####%%%%%%%%
%%%%%%%%%@@@%%@#%%%%*=====++#%@@@@@@@%%%##*+++#####%%#%#%#%**++**##@@@@@@@@@%%%%%%############%%%%%%
%%%%%%%%%%%%%@%#%%%%#==--==--=*#%%%@%%%%*++*=+*####%%#%#*###**#####%%@@@%%%%#%@%%########****##%@@@@
@%%%%%%%%%%%%@%###%%#+==--+=-:-=**%%##%##++===*+**%%#++####**###*##%%%%%%%#%%@@@%%######******##%%%%
@@%%%%%%%%%@@%%######*==--==--:---+****#**+=++==*#%#+***#*#####%##%%%%%###%%%@@@%%##%##********##%%%
@@@%%%%%%%%%%%%%#**#**+=======--==+==+*#*#*#++=+*%%%%%######%%%%%%%%%%%%%%%%@@%%%%#####***++++**#%@@
@@@@%%%%%%%%%%%%%#*****++========++++++*+*##**+*##%%#*###%%%%%%%%%%%%%%%%%%%@@%%%%#%##***+++++**#%%@
@@@@@@@%%%%%%%%%#+++++=+*+++===+==+++*+*=+*##*##%@%%#######%%#%%%#%#%%%%%%%%%%%%%#%%##***++++++*#%@@
@@@@@@@@@%%%%%#*===++=--=+****+===--=++*+**###%%@@%%####%##########%%%#%%%%%%%###%%###**++++++*#%%%%
@@@@@@@@@@%%%#+---====----=++***+==++=-=*###%@%%%%%%*#############%%###%%%##########***+++++++*#%%%%
@@@@@@@@%%#**=----====-:::--===+**##***++**=#%***#*#######*##**#%%#################******++++*#%%%%%
@@%#++===-----------==-::::--------====++**++=+**#%%#######****##***######******##****+++==+++#%%%#%
#+=-----------::::-----:::.::---::-:::--==**#########%%#**++++***++*#%##****+++***+++++======+#%%###
+=------------::::::----:::.::::---=--=---=-=++**###***+++===+===+++###**++++=+++++========+++######
+=---------=--:::::::::--:::.:::::::::::::::--==+++++++==========++*###*++====++++==========+*#####%
+=------====-:::::::::::::::::::::::::::::::---==+**+++++=======+*##**+++===--===---------==+*#####%
+=--====-===--::::::::::::::::::::::::::::----==**+===========++*****+===----------------===*######%
==--========-::::::.::::::::::....::::::::---=====--===+++++++++++++==----------------======*#####%%
+=--========-::::::.....:::::::::::::::::::----------------==========-----::::::::---=-=--=+######%%
+==---=====--::::::::..:::::::::=-----:::-::::::::::::::------------::::::::::::::--------=*#####%@@
+==----=====--:::::::...:::::::---------:::::::::::::::::::--::::::::::::::::::::-:------=+##%#%%%@@
+==-----====--::::::::.....::::::::::-:::::::::::::-::::::::::::::::::::::::::::-:::--==+*#####%%%@@
+==------===-:::::::::::......::::...:::::::::::::::::::::::::::::::::::::::::::::--++******##%%%@@@
+==------===-:::::::::::................::::::.:::::::::::::::...::..:::::-----=+++****+***###%%%@@@";

                    Console.WriteLine(asciiArt);
                }
            }

            else if (operation == 16)
            {

                int n = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                while (n > 0)
                {
                    int digit = n % 10;
                    if (digit == 4)
                    {
                        count++;
                    }
                    n = n / 10;
                }

                Console.WriteLine(count);
            }

            else if (operation == 17)
            {
                //АРТУР И ДРУЗЬЯ           
                int a = Convert.ToInt32(Console.ReadLine());
                int b = 0;
                int c = 0;
                while (a > 0)
                {
                    if (a % 10 == 7)
                    {
                        b++;
                    }
                    else if (a % 10 == 0)
                    {
                        c++;

                    }
                    a = a / 10;
                }
                if (b >= 1 && c == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            else if (operation == 18)
            {
                //АРТУР И ДРУЗЬЯ 2           
                int a = Convert.ToInt32(Console.ReadLine());
                int b = 0;
                int c = 0;
                if (a < 100000)
                { Console.WriteLine("No"); }
                else
                {
                    while (a > 0)
                    {
                        if (a % 10 == 7)
                        {
                            b++;
                        }
                        else if (a % 10 == 0)
                        {
                            c++;
                        }
                        a = a / 10;
                    }
                    if (b >= 1 && c == 0)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }

                }
            }

            else if (operation == 19)
            {

                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) { Console.WriteLine("0"); }
                while (a > 0)
                {
                    int b = a % 10;
                    Console.Write(b);
                    a = a / 10;
                }
            }

            else if (operation == 20)
            {
                //ЧЁТНЫЕ И НЕ КРАТНЫЕ ТРЁМ           
                int sum = 0;
                while (true)
                {
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 0)
                        break;
                    if (num % 2 == 0 && num % 3 != 0)
                    {
                        sum = sum + num;
                    }
                }

                Console.WriteLine(sum);
            }

            else if (operation == 21)
            {
                int result = 0;
                int number;

                while ((number = Convert.ToInt32(Console.ReadLine())) != 0)
                {
                    if (number > 0) result++;
                    else if (number < 0) result--;
                }

                Console.WriteLine(result);
            }

            else if (operation == 22)
            {

                int sum = 0;
                int count = 0;
                int number;

                while ((number = Convert.ToInt32(Console.ReadLine())) != 0)
                {
                    sum += number;
                    count++;
                }
                Console.WriteLine(sum / count);
            }

            else if (operation == 23)
            {
                //кОЛИЧЕСТВО ЭЛЕМЕНТОВ, КОТОРЫЕ БОЛЬШЕ ПРЕДЫДУЩЕГО       
                int a = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                int b;

                while ((b = Convert.ToInt32(Console.ReadLine())) != 0)
                {
                    if (b > a) count++;
                    a = b;
                }

                Console.WriteLine(count);
            }

            else if (operation == 24)
            {

                int h = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                int k;

                while ((k = Convert.ToInt32(Console.ReadLine())) != 0)
                {
                    if (h * k < 0) count++;
                    h = k;
                }

                Console.WriteLine(count);
            }

            else if (operation == 25)
            {
                int numb;

                do
                {
                    Console.WriteLine("Введите положительное число");
                    numb = Convert.ToInt32(Console.ReadLine());
                }

                while (numb <= 0);
                Console.WriteLine($"Вы ввели корректное число {numb}");
            }
            //начало 6
            else if (operation == 26)
            {
                string answer;
                Console.WriteLine("Ввод: 1. Вывод: Понедельник");
                Console.WriteLine("Ввод: 2. Вывод: Вторник");
                Console.WriteLine("Ввод: 3. Вывод: Среда");
                Console.WriteLine("Ввод: 4. Вывод: Четверг");
                Console.WriteLine("Ввод: 5. Вывод: Пятница");
                Console.WriteLine("Ввод: 6. Вывод: Суббота");
                Console.WriteLine("Ввод: 7. Вывод: Воскресенье");
                Console.WriteLine("Введите число от 1 до 7");
                Console.WriteLine("Ваш выбор: ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Сегодня понедельник");
                        break;
                    case "2":
                        Console.WriteLine("Сегодня Вторник");
                        break;
                    case "3":
                        Console.WriteLine("Сегодня Среда");
                        break;
                    case "4":
                        Console.WriteLine("Сегодня Четверг");
                        break;
                    case "5":
                        Console.WriteLine("Сегодня Пятница");
                        break;
                    case "6":
                        Console.WriteLine("Сегодня Суббота");
                        break;
                    case "7":
                        Console.WriteLine("Сегодня Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Дни недели считаются от 1 до 7");
                        break;
                }
                Console.WriteLine();
            }

            else if (operation == 27)
            {
                string operacia;
                Console.WriteLine("Введите первое число");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Выберите знак операции +, -, *, /");
                Console.WriteLine("Ваш выбор: ");
                operacia = Console.ReadLine();

                Console.WriteLine("Введите второе число");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (operacia)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Делить на ноль нельзя");
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("Введите коректное действие");
                        break;
                }
                Console.WriteLine();
                if (num2 != 0)
                {
                    Console.WriteLine($"Ответ: {num1} {operacia} {num2} = {result}");
                }
            }

            else if (operation == 28)
            {
                string password;
                do
                {
                    Console.WriteLine("Введите пароль");
                    password = Convert.ToString(Console.ReadLine());
                    switch (password)
                    {
                        case "1234":
                            Console.WriteLine("Пароль подходит");
                            break;
                        default:
                            Console.WriteLine("Пароль не верный. Попробуйте снова");
                            break;
                    }
                    Console.WriteLine();
                }
                while (password != "1234");
            }

            else if (operation == 29)
            {
                Console.WriteLine("Введите число");
                int num;
                int result = 0;
                do
                {
                    Console.WriteLine("Введите число 0 для завершения программы");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num != 0)
                    {
                        result += num;
                    }
                }
                while (num != 0);
                Console.WriteLine($"Сумма чисел равна {result}");
                {
                    Console.WriteLine("Программа завершена");
                }
            }

            else if (operation == 30)
            {
                Console.WriteLine("Введите число");
                int num;
                int result = 0;
                do
                {
                    Console.WriteLine("Введите отрицательное число чтобы посчитать все введеные числа");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0)
                    {
                        result += num;
                    }
                }
                while (num > 0);
                Console.WriteLine($"Сумма всех положительных чисел равна {result}");
                {
                    Console.WriteLine("Программа завершена");
                }
            }

            else if (operation == 31)
            {
                int n;
                Console.WriteLine("Введите число");
                do
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 9)
                    {
                        Console.WriteLine("Введите число снова");
                    }
                    else
                    {
                        Console.WriteLine("Число не верное!");
                    }
                }
                while (n <= 9);
            }



            else if (operation == 32)
            {
                Console.WriteLine("Введите высоту вашего треугольника из звездочек");
                int hight = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= hight; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine();

                }
            }



            else if (operation == 33)
            {
                int hight = 5;
                int streit = 10;
                for (int i = 0; i < hight; i++)
                {
                    for (int j = 0; j < streit; j++)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine();
                }
            }



            else if (operation == 34)
            {
                int num1 = 1;
                int i = 0;
                while (i < num1)
                {
                    int j = 0;
                    while (j <= num1)
                    {
                        Console.WriteLine("*****");
                        j++;
                    }
                    Console.WriteLine();
                    i++;
                }
            }


            else if (operation == 35)
            {
                Console.WriteLine("Нет ?");
                Console.WriteLine("2 это нет ");
                Console.WriteLine("Прiв");


                int num;
                int result = 0;
                do
                {
                    Console.WriteLine("Прив снова ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num != 0)
                    {
                        result += num;
                    }
                }
                while (num != 0);
                Console.WriteLine($"Сумма чисел равна {result}");
                {
                    Console.WriteLine("Программа завершена");
                }
            }
            //2 семетр

            else if (operation == 36)
            {
                try {
                 Console.Write("Введите целое число: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Вы ввели число: {number}");
            } 
                   catch (FormatException) {
                Console.WriteLine("Ошибка: введено не целое число!");
            }
            
            }

            else if (operation == 37)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = int.Parse(Console.ReadLine());

                    int result = a / b;
                    Console.WriteLine($"Результат деления: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: вводите только целые числа!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно!");
                }
            }

            else if (operation == 38)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = int.Parse(Console.ReadLine());

                    int result = a / b;
                    Console.WriteLine($"Результат деления: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: вводите только целые числа!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно!");
                }
            }
            // 4 ЗАДАНИЕ
            else if (operation == 39)
            {
                int[] data = { 10, 20, 30, 40, 50 };
                try
                {
                    Console.Write("Введите индекс (0-4): ");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Элемент: {data[index]}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: индекс должен быть числом!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: индекс вне границ массива!");
                }
            }

            else if (operation == 40)
            {
                try
                {
                    Console.Write("Введите размер: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    int sum = 0;

                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                        sum += arr[i];
                    }
                    Console.WriteLine($"Сумма: {sum}");
                }
                catch (Exception)
                { // Общий перехват всех ошибок
                    Console.WriteLine("Произошла ошибка при вводе или расчете.");
                }
            }

            //6 
            else if (operation == 41)
            {
                int[] arr = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    bool success = false;
                    while (!success)
                    {
                        try
                        {
                            Console.Write($"Введите число {i + 1}: ");
                            arr[i] = int.Parse(Console.ReadLine());
                            success = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ошибка! Попробуйте снова.");
                        }
                    }
                }
            }

            else if (operation == 42)
            {
                try
                {
                    Console.Write("Размер массивов: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr1 = new int[size];
                    double[] results = new double[size];

                    Console.WriteLine("Первый массив:");
                    for (int i = 0; i < size; i++) arr1[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Второй массив:");
                    for (int i = 0; i < size; i++)
                    {
                        int val = int.Parse(Console.ReadLine());
                        if (val == 0) throw new DivideByZeroException(); // В C# деление на ноль целых чисел вызывает исключение
                        results[i] = (double)arr1[i] / val;
                    }

                    Console.WriteLine("Результаты: " + string.Join(", ", results));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            //END
            //▒▒▒▒▒▒▒▒▒▒▒▒
            //▒▒▒▒▓▒▒▓▒▒▒▒
            //▒▒▒▒▓▒▒▓▒▒▒▒
            //▒▒▒▒▒▒▒▒▒▒▒▒
            //▒▓▒▒▒▒▒▒▒▒▓▒
            //▒▒▓▓▓▓▓▓▓▓▒▒
            //▒▒▒▒▒▒▒▒▒▒▒▒


            else if (operation == 43)
            {

            }


















            else
            {
                Console.WriteLine("Не понял");
                Console.WriteLine(error);
                Console.WriteLine("Попробуйте еще раз ");



            }





        }
    }
}