using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_Csharp
{
    // Создадим интерфейс "Студент" с методами:
    public interface IStudent
    {
        // Фамилия, имя и отчество студента
        public void FIO(string _f, string _i, string _o);

        // Пол студента
        public void Gender(string _gen);

        // Дата рождения студента (в формате дд.мм.гг.)
        public void Birthday(int _day, int _month, int _year);

        // Название института, год обучения, направление 
        public void Education(string _institute, int _year_of_study, string _direction);

        // Адрес студента (город, улица, номер дома)
        public void Address(string _town, string _street, int _house_number);

        // Номер телефона студента
        public void Phone_Number(long _number);
    }

    // Создадим интерфейс "Средний балл" c методом:
    public interface IAverage_Score
    {
        /// <summary>
        ///  Высчитывает средний балл студента, 
        ///  исходя из его оценок, полученных во время последней сессии
        /// </summary>
        public void Average_Score();
    }

    // Создадим интерфейс "Отчисление" с методом:
    public interface IScholarship
    {
        /// <summary>
        ///  На основе введенных оценок делает вывод о том,
        ///  будет ли студент получать стипендию
        ///  в следующем месяце
        /// </summary>
        public void Scholarship();
    }
}