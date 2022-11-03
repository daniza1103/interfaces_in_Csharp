using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("                     Приложение «ЖУРНАЛ»");
            Console.WriteLine("           Выполнила студентка направления ИиВТ (ПОСВТиАС)");
            Console.WriteLine("                      Галачиева Д.В.");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            Console.Write(" Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("   Получим информацию о первом студенте...");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            Console.Write("   Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Student S1 = new Student();
            S1.FIO("Галачиева", "Даниза", "Витальевна");
            S1.Gender("Ж");
            S1.Birthday(11, 03, 2001);
            S1.Education("Искусственного интеллекта и цифровых технологий", 3, "ИиВТ (ПОСВТиАС)");
            S1.Address("Нальчик", "Ленина", 12);
            S1.Phone_Number(89094884331);
            Console.WriteLine();
            Console.WriteLine(" Вычислим средний балл студента...");
            S1.Average_Score();
            Console.WriteLine();
            Console.WriteLine(" Будет ли студент получать стипендию в следующем семестре?");
            S1.Scholarship();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.Write(" Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("   Получим информацию о втором студенте...");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            Console.Write("   Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Student S2 = new Student();
            S2.FIO("Иванов", "Иван", "Иванович");
            S2.Gender("М");
            S2.Birthday(23, 08, 2000);
            S2.Education("Искусственного интеллекта и цифровых технологий", 3, "ИиВТ (ПОСВТиАС)");
            S2.Address("Нальчик", "Тарчокова", 50);
            S2.Phone_Number(89284336756);
            Console.WriteLine();
            Console.WriteLine(" Вычислим средний балл студента...");
            S2.Average_Score();
            Console.WriteLine();
            Console.WriteLine(" Будет ли студент получать стипендию в следующем семестре?");
            S2.Scholarship();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.Write(" Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("   Получим информацию о третьем студенте...");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            Console.Write("   Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Student S3 = new Student();
            S3.FIO("Петров", "Петр", "Петрович");
            S3.Gender("М");
            S3.Birthday(06, 11, 2000);
            S3.Education("Искусственного интеллекта и цифровых технологий", 3, "ИиВТ (АСОиУ)");
            S3.Address("Нальчик", "Пушкина", 23);
            S3.Phone_Number(89605447888);
            Console.WriteLine();
            Console.WriteLine(" Вычислим средний балл студента...");
            S3.Average_Score();
            Console.WriteLine();
            Console.WriteLine(" Будет ли студент получать стипендию в следующем семестре?");
            S3.Scholarship();
        }
    }
}