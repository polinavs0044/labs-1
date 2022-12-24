using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam a = new ResearchTeam();//1.	Создать один объект типа ResearchTeam, преобразовать данные в текстовый вид с помощью метода ToShortString() и вывести данные
            Console.WriteLine(a.ToString());

            Console.WriteLine();
            Console.WriteLine("Year: " + TimeFrame.Year);
            Console.WriteLine("TwoYears: " + TimeFrame.TwoYears);
            Console.WriteLine("Long: " + TimeFrame.Long);
            Console.WriteLine(); //2.	Вывести значения индексатора для значений индекса TimeFrame.Year, TimeFrame.TwoYears, TimeFrame.Long

            a.Info = TimeFrame.Long;
            a.Organization = "Organization";
            a.RegNum = 12345;
            a.Topic = "SomeTopic"; //Присвоить значения всем определенным в типе ResearchTeam свойствам, преобразовать данные в текстовый вид с помощью метода ToString() и вывести данные

            Console.WriteLine(a.ToString());
            Console.WriteLine();

            a.AddPapers(new Paper("FirstTitle", new Person("Jennie", "Park", new DateTime(1995, 11, 16)), new DateTime(2010, 6, 10)));
            Console.WriteLine(a.ToString());//4.	С помощью метода AddPapers (params Paper []) добавить элементы в список публикаций и вывести данные объекта ResearchTeam

            Console.WriteLine("the latest paper");//5.	Вывести значение свойства, которое возвращает ссылку на публикацию с самой поздней датой выхода
            Console.WriteLine(a.LastPaper.ToString());

            Console.WriteLine(); //6.	Сравнить время выполнения операций с элементами одномерного, двумерного прямоугольного и двумерного ступенчатого массивов с одинаковым числом элементов типа Paper
            Console.WriteLine();
            Console.WriteLine("Пожалуйста, выберите разделитель:");
            string c = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите размер массивов:");
            string[] mas = Console.ReadLine().Split(c);
            int n = int.Parse(mas[0]);
            int m = int.Parse(mas[1]);
            ResearchTeam[] mas1 = new ResearchTeam[n * m];
            for (int i = 0; i < n * m; i++)
                mas1[i] = new ResearchTeam();
            ResearchTeam[,] mas2 = new ResearchTeam[n, m];
            for (int i = 0; i < n; i++)
                for (int k = 0; k < m; k++)
                    mas2[i,k] = new ResearchTeam();
            ResearchTeam[][] mas3 = new ResearchTeam[n][];
            for (int i = 0; i < n; i++)
            {
                mas3[i] = new ResearchTeam[m];
                for (int k = 0; k < m; k++)
                    mas3[i][k] = new ResearchTeam();
            }

            int time1 = 0;
            int time2 = 0;
            int time3 = 0;

            int t1 = Environment.TickCount;
            for (int i = 0; i < n * m; i++)
                mas1[i].Topic = "ii";
            int t2 = Environment.TickCount;
            time1 = t2 - t1;

            t1 = Environment.TickCount;
            for (int i = 0; i < n; i++)
                for (int k = 0; k < m; k++)
                    mas2[i, k].Topic = "ii";

            t2 = Environment.TickCount;
            time2 = t2 - t1;

            t1 = Environment.TickCount;
            for (int i = 0; i < n; i++)
                for (int k = 0; k < m; k++)
                    mas3[i][k].Topic = "ii";                   
            t2 = Environment.TickCount;
            time3 = t2 - t1;

            Console.WriteLine("Одномерный " + time1 + " Двумерный " + time2 + " Ступенчатый " + time3);
        }
    }
}


//Статическое свойство TickCount класса Environment имеет тип int, использует информацию системного таймера и содержит время в миллисекундах, которое прошло с момента перезагрузки компьютера.
//Чтобы получить время выполнения некоторого блока кода, необходимо вызвать Environment.TickCount непосредственно перед блоком и сразу же после последнего оператора блока и взять разность значений.
//В блоке кода, для которого измеряется время, не должно быть операций распределения памяти для массивов, инициализации элементов массивов и операций вывода данных на консоль. Блоки кода должны содержать только операции с элементами массива.
//Вычисленные значения времени выполнения операций для трех типов массивов, а также число строк nrow и столбцов ncolumn выводятся на консоль. Вывод должен быть подписан, т.е. вывод должен содержать информацию о том, какому типу массива отвечает выведенное значение.
