using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Lecture1HomeWorkClasses;

namespace Lecture1HomeWork
{
    // Крылов Вадим

    class Program
    {
        public static void TaskN1()         //1. Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
        {
            List<string> inputInfo = Task1.Input();
            Task1.OutputByFormat(inputInfo);
            Task1.OutputByGluing(inputInfo);
        }

        public static void TaskN2()         //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах
        {
            Task2.BMICalculation(Task2.Input());
        }

        public static void TaskN3()
        {
                                            //3.
                                            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат используя спецификатор формата .2f (с двумя знаками после запятой);
                                            //б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
            
            List<int> firstPoint = Task3.InputFirstPoint();
            List<int> secondPoint = Task3.InputSecondPoint();
            Task3.DistanceCalculation(firstPoint, secondPoint);
        }

        public static void TaskN4()
        {
                                            //4. Написать программу обмена значениями двух переменных
                                            //а) с использованием третьей переменной;
                                            //б) *без использования третьей переменной.

            List<int> inputValues = Task4.Input();
            Task4.ChangeValuesWithThirdVar(inputValues);
            Task4.ChangeValuesWithoutThirdVar(inputValues);
        }

        public static void TaskN5()
        {
                                            //5.
                                            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
                                            //б) Сделать задание, только вывод организуйте в центре экрана
                                            //в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

            List<string> userInfo = Task5.Input();
            Task5.OutputUserInfoSimple(userInfo);
            Task5.OutputUserInfoInCenter(userInfo);
            Task5.OutputUserInfoInCustomPlace(userInfo);
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo selectedTask;
            var rule = @"[0-9]";

            Console.WriteLine("Добрый день, уважаемый пользователь. Демонстрацию работы какой программы вы бы хотели увидеть?");
            Console.WriteLine("\t1. Программа \"Анкета\" и вывод инфорации на экран.");
            Console.WriteLine("\t2. Расчет BMI на основе роста и веса.");
            Console.WriteLine("\t3. Вычисление расстояния между двумя точками на основе введенных данных.");
            Console.WriteLine("\t4. Смена значений переменных с использованием третьей переменной и без нее.");
            Console.WriteLine("\t5. Программа \"Информация о пользователе\" и вывод инфорации в разных частях экрана.");
            selectedTask = Console.ReadKey(true);
            if (Regex.IsMatch(selectedTask.KeyChar.ToString(), rule))
            {
                switch (selectedTask.KeyChar)
                {
                    case '1':
                        TaskN1();
                        break;
                    case '2':
                        TaskN2();
                        break;
                    case '3':
                        TaskN3();
                        break;
                    case '4':
                        TaskN4();
                        break;
                    case '5':
                        TaskN5();
                        break;
                }
            }
        }
    }
}
