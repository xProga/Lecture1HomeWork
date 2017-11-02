using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1HomeWorkClasses
{
    class Task1
    {
        //1. Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
        public static List<string> Input()
        {
            List<string> answers = new List<string>();

            Console.WriteLine("Добрый день, пользователь. Пожалуйста, представьтесь системе и укажите ваши данные.");
            Console.Write("Фамилия: ");
            answers.Add(Console.ReadLine());
            Console.Write("Имя: ");
            answers.Add(Console.ReadLine());
            Console.Write("Возраст: ");
            answers.Add(Console.ReadLine());
            Console.Write("Рост: ");
            answers.Add(Console.ReadLine());
            Console.Write("Вес: ");
            answers.Add(Console.ReadLine());
            Console.WriteLine("Спасибо за информацию.");
            return answers;
        }

        public static void OutputByGluing(List<string> answers)
        {
            Console.WriteLine("Ваши данные склейкой: Имя - " + answers[0] + ", Фамилия - " + answers[1] + " Возраст - " + answers[2] + " Рост - " + answers[3] + " Вес - " + answers[4] + ".");
            Console.ReadKey();
        }

        public static void OutputByFormat(List<string> answers)
        {
            Console.WriteLine("Ваши данные методом форматирования: Имя - {0}, Фамилия - {1}, Возраст - {2}, Рост - {3}, Вес - {4}.", answers[0], answers[1], answers[2], answers[3], answers[4]);
            Console.ReadKey();
        }
        
    }
    
    class Task2
    {
        //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах
        public static List<double> Input()
        {
            List<double> answers = new List<double>();

            Console.WriteLine("Добрый день, пользователь. Данная программа рассчитывает ваш индекс массы тела на основе вашего роста и веса. Пожалуйста, введите исходные данные.");
            Console.Write("Рост, в метрах: ");
            answers.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Вес, кг: ");
            answers.Add(Convert.ToDouble(Console.ReadLine()));
            return answers;
        }

        public static void BMICalculation(List<double> answers)
        {
            double bmi = answers[1] / Math.Pow(answers[0], 2);
            string outputMessage = "Уважаемый пользователь, ваш ИМТ, на текущий момент, " + bmi.ToString("f2") + ". ";
            if (bmi < 18.5)
            {
                outputMessage += "В вашем теле наблюдается ДЕФИЦИТ массы. Рекомендуется набрать недостающий вес.";
            }
            else if (bmi > 30.0)
            {
                outputMessage += "В вашем теле наблюдается ИЗБЫТОК массы. Рекомендуется обратить внимание на рацион и работать над снижением веса.";
            }
            else 
            {
                outputMessage += "Ваше тело находится в нормальном состоянии. Продолжайте в том же духе :)";
            }

            Console.WriteLine(outputMessage);
            Console.ReadKey();
        }
    }

    class Task3
    {

        //3.
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат используя спецификатор формата .2f (с двумя знаками после запятой);
        //б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;

        private static void AddInputValuesToList(ref List<int> values)
        {
            string[] inputValues = Console.ReadLine().Split(',', ' ').ToArray();
            values.Add(int.Parse(inputValues[0]));
            values.Add(int.Parse(inputValues[1]));
        }

        public static List<int> InputFirstPoint()
        {
            List<int> values = new List<int>();

            Console.WriteLine("Добрый день, уважаемый пользователсь. Для расчета расстояния между точками необходимо ввести координаты точек ниже");
            Console.Write("Введите координаты первой точки (x1, y1), через запятую: ");
            Task3.AddInputValuesToList(ref values);
            return values;
        }

        public static List<int> InputSecondPoint()
        {
            List<int> values = new List<int>();
            Console.Write("Введите координаты второй точки (x2, y2), через запятую: ");
            Task3.AddInputValuesToList(ref values);
            return values;
        }

        public static void DistanceCalculation(List<int> firstPointValues, List<int> secondPointValues)
        {
            double distance = Math.Sqrt(Math.Pow(secondPointValues[0] - firstPointValues[0], 2) + Math.Pow(secondPointValues[1] - firstPointValues[1], 2));
            Console.WriteLine("Расстояние между точками r = {0:f2}", distance);
            Console.ReadKey();
        }

    }

    class Task4
    {
        //4. Написать программу обмена значениями двух переменных
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.

        public static List<int> Input()
        {
            List<int> values = new List<int>();

            Console.WriteLine("Добрый день, уважаемый пользователь. Программа для смены чисел местами требует ввода исходных данных.");
            Console.Write("Введите первое число: ");
            values.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите второе число: ");
            values.Add(Convert.ToInt32(Console.ReadLine()));

            return values;
        }

        public static void ChangeValuesWithThirdVar(List<int> values)
        {
            int c = values[0];
            values[0] = values[1];
            values[1] = c;

            Console.WriteLine("После изменения первое число: {0}, второе: {1}, с помощью вспомогательной переменной.", values[0], values[1]);
            Console.ReadKey();
        }

        public static void ChangeValuesWithoutThirdVar(List<int> values)
        {
            values[0] = values[0] + values[1];
            values[1] = values[0] - values[1];
            values[0] = values[0] - values[1];

            Console.WriteLine("После изменения первое число: {0}, второе: {1}, БЕЗ вспомогательной переменной.", values[0], values[1]);
            Console.ReadKey();
        }
    }
    
    class Task5
    {
        //5.
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организуйте в центре экрана
        //в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

        private static void CenterCursorInConsoleWindow()
        {
            int leftOffSet = (Console.WindowWidth / 2);
            int topOffSet = (Console.WindowHeight / 2);
            Console.SetCursorPosition(leftOffSet, topOffSet);
        }

        private static void CustomCursorPositionInConsoleWindow(List<int> offsets)
        {
            int leftOffSet = offsets[0];
            int topOffSet = offsets[1];
            Console.SetCursorPosition(leftOffSet, topOffSet);
        }

        public static List<string> Input()
        {
            List<string> infoAboutUser = new List<string>();

            Console.WriteLine("Добрый день, пользователь. Пожалуйста, представьтесь системе и укажите ваши данные.");
            Console.Write("Фамилия: ");
            infoAboutUser.Add(Console.ReadLine());
            Console.Write("Имя: ");
            infoAboutUser.Add(Console.ReadLine());
            Console.Write("Город: ");
            infoAboutUser.Add(Console.ReadLine());

            return infoAboutUser;
        }

        public static void OutputUserInfoSimple(List<string> infoAboutUser)
        {
            Console.WriteLine("Фамилия: {0}, Имя: {1}, Город: {2}", infoAboutUser[0], infoAboutUser[1], infoAboutUser[2]);
            Console.ReadKey();
        }

        public static void OutputUserInfoInCenter(List<string> infoAboutUser)
        {
            Task5.CenterCursorInConsoleWindow();
            Console.WriteLine("Фамилия: {0}, Имя: {1}, Город: {2}", infoAboutUser[0], infoAboutUser[1], infoAboutUser[2]);
            Console.ReadKey();

        }

        public static void OutputUserInfoInCustomPlace(List<string> infoAboutUser)
        {
            List<int> offsets = new List<int>();
            Console.Clear();
            Console.Write("Укажите, в каких координатах вам удобнее вывести информацию, через запятую (отступ слева, отступ сверху):");
            string[] inputValues = Console.ReadLine().Split(',', ' ').Where(x => x != "").ToArray();
            offsets.Add(int.Parse(inputValues[0]));
            offsets.Add(int.Parse(inputValues[1]));

            CustomCursorPositionInConsoleWindow(offsets);
            Console.WriteLine("Фамилия: {0}, Имя: {1}, Город: {2}", infoAboutUser[0], infoAboutUser[1], infoAboutUser[2]);
            Console.ReadKey();
        }
    }
} 