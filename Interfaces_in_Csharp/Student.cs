using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_Csharp
{
    public class Student : IStudent, IAverage_Score, IScholarship
    {
        string f, i, o, gen, institute, direction, town, street;
        int day, month, year, year_of_study, house_number;
        long number;
        public double score;
        public bool found = false;
        public void FIO(string _f, string _i, string _o)
        {
            f = _f; i = _i; o = _o;
            Console.WriteLine($" ФИО: {f} {i} {o}");
        }
        public void Gender(string _gen)
        {
            gen = _gen;
            Console.WriteLine($" Пол: {gen}");
        }
        public void Birthday(int _day, int _month, int _year)
        {
            day = _day; month = _month; year = _year;
            Console.WriteLine($" Дата рождения: {day}.{month}.{year}");
        }
        public void Education(string _institute, int _year_of_study, string _direction)
        {
            institute = _institute; year_of_study = _year_of_study; direction = _direction;
            Console.WriteLine($" Институт {institute}, {year_of_study} курс направления {direction}");
        }
        public void Address(string _town, string _street, int _house_number)
        {
            town = _town; street = _street; house_number = _house_number;
            Console.WriteLine($" Живет по адресу: г.{town}, улица {street} {house_number}");
        }
        public void Phone_Number(long _number)
        {
            number = _number;
            Console.WriteLine($" Номер: {number}");
        }
        public void Average_Score()
        {
            Console.WriteLine(" Введите оценки студента за последнюю сессию (5): ");
            int[] marks = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++) { marks[i] = Convert.ToInt32(Console.ReadLine().ToString()); }
            for (int i = 0; i < 5; i++) { sum += marks[i]; }
            double a = Convert.ToInt32(sum);
            score = a / 5;
            Console.WriteLine($" Следовательно, средний балл студента составляет {score:F2}");
            for (int i = 0; i < 5; i++) if (marks[i] == 2 || marks[i] == 3) { found = true; }
        }
        public void Scholarship()
        {
            if (found == true) { Console.WriteLine(" Студент не будет получать стипендию, т.к. получил в семестре как минимум одну 2-ку или 3-ку."); }
            else { Console.WriteLine(" Студент будет получать стипендию, оценки удовлетворительны."); }
        }
    }
}