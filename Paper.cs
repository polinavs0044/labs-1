using System;
using System.Collections.Generic;
using System.Text;

namespace laba1
{
    public enum TimeFrame { Year, TwoYears, Long }; //Определить тип TimeFrame перечисление(епит) со значениями Year, TwoYears, Long.

    class Paper
    {
        public string Title { get; set; } //•	свойство типа string, в котором хранится название публикации
        public Person Author { get; set; }//•	свойство типа Person для автора публикации
        public DateTime Date { get; set; }//•	свойство типа DateTime с датой публикации

        public Paper(string title, Person author, DateTime date) //•	конструктор с параметрами типа string, Person, DateTime для инициализации всех свойств класса
        {
            Title = title;
            Author = author;
            Date = date;
        }

        public Paper() //•	конструктор без параметров, инициализирующий все свойства класса некоторыми значениями по умолчанию
        {
            Title = "Title";
            Author = new Person();
            Date = new DateTime(1906, 7, 9);
        }

        public override string ToString() //перегруженную overrude версию виртуального метода string ToString() для формирования строки со значениями всех полей класса
        {
            string s = "Title: " + Title + "; author: " + Author.ToString() + "; date: " + Date.ToLongDateString();
            return s;
        }
    }
}
