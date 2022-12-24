using System;
using System.Collections.Generic;
using System.Text;

namespace laba1
{
    class Person
    {
        private string name;//•	закрытое поле типа string, в котором хранится имя
        string lastName;//•	закрытое поле типа string, в котором хранится фамилия
        DateTime birth;//•	закрытое поле типа System.DateTime для даты рождения

        public Person(string name, string lastName, System.DateTime birth) //•	конструктор с тремя параметрами типа string, string, DateTime для инициализации всех полей класса
        {
            this.name = name;
            this.lastName = lastName;
            this.birth = birth;
        }

        public Person() //•	конструктор без параметров, инициализирующий все поля класса некоторыми значениями по умолчанию
        {
            name = "Name";
            lastName = "LastName";
            birth = new DateTime(1905, 3, 6);
        }

        public string Name //•	свойство типа string для доступа к полю с именем
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName //•	свойство типа string для доступа к полю с фамилией
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public System.DateTime Birth //•	свойство типа DateTime для доступа к полю с датой рождения;
        {
            get { return birth; }
            set { birth = value; }
        }

        public int Year //•	свойство типа int с методами get и set для получения   и изменения (set) года рождения в закрытом поле типа DateTime, в котором хранится дата рождения
        {
            get { return birth.Year; }
            set { birth = new DateTime(value, birth.Month, birth.Day); }
        }

        public override string ToString() // перегруженная override версию виртуального метода string ToString() для формирования строки со значениями всех полей класса
        {
            string s = name + " " + lastName + "; birth: " + birth.ToLongDateString();
            return s;
        }

        public virtual string ToShortString()//•	виртуальный метод string ToShortString(), который возвращает строку, содержащую только имя и фамили
        {
            string s = name + " " + lastName;
            return s;
        }
    }
}
