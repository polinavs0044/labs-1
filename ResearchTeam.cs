using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace laba1
{
    class ResearchTeam
    {
        string topic; 
        string organization;
        int regNum;
        TimeFrame info;
        Paper[] papersList;

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        public int RegNum
        {
            get { return regNum; }
            set { regNum = value; }
        }

        public TimeFrame Info
        {
            get { return info; }
            set { info = value; }
        }

        public Paper[] PapersList
        {
            get { return papersList; }
            set { papersList = value; }
        }

        public ResearchTeam(string topic, string org, int regNum, TimeFrame info)
        {
            Topic = topic;
            Organization = org;
            RegNum = regNum;
            Info = info;
            papersList = new Paper[] { new Paper() };
        }

        public ResearchTeam()
        {
            Topic = "Topic";
            Organization = "Name of Organization";
            RegNum = 0;
            Info = 0;
            papersList = new Paper[] { new Paper() };
        }

        public Paper LastPaper //•	свойство типа Paper ( только с методом get), которое возвращает ссылку на публикацию с самой поздней датой выхода
        {
            get { return papersList[papersList.Length - 1]; }
        }

        public bool this[TimeFrame timeFr] //•	индексатор булевского типа (только с методом get) с одним параметром типа TimeFrame; значение индексатора равно true, если значение поля с  информацией о продолжительности исследований совпадает со значением индекса, и false в противном случае
        {
            get
            {
                if (timeFr == info) return true;
                else return false;
            }
        }

        public void AddPapers(params Paper[] p) //•	метод void AddPapers ( params Paper[] ) для добавления элементов в список публикаций
        {
            Paper[] temp = new Paper[papersList.Length + p.Length];
            temp = papersList.Concat(p).ToArray();
            papersList = temp;
        }

        public override string ToString()//•	перегруженную версию виртуального метода string ToString() для формирования строки со значениями всех полей класса, включая список публикаций
        {
            string s = "Topic: " +  topic + "; Organization: " + organization + "; Registration Number: " + regNum + "; Information: " + info + "\n" + "Papers\n";
            for (int i = 0; i < papersList.Length; i++)
            {
                s += papersList[i].ToString();
                s += "\n";
            }
            return s;
        }

        public virtual string ToShortString()//•	виртуальный метод string ToShortString(), который формирует строку со значениями всех полей класса без списка публикаций
        {
            string s = topic + " " + organization + " " + regNum + " " + info;
            return s;
        }
    }
}
