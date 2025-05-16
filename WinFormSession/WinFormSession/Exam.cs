using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSession
{
    public class Exam
    {
        string subject;
        string date;

        public Exam(string subject)
        {
            this.subject = subject;
        }

        public bool SetDate(string date)
        {
            string[] temp = date.Split('.');
            int day = Convert.ToInt32(temp[0]);
            int month = Convert.ToInt32(temp[1]);
            int year = Convert.ToInt32(temp[2]);
            if (9 < day && day <= 30)
                if (month == 6)
                    if (year == 25 || year == 2025)
                    {
                        this.date = date;
                        return true;
                    }
            return false;
        }

        public string GetSubject() 
        { 
            return this.subject;
        }

        public string GetDate() 
        {
            return date;
        }

        public override string ToString()
        {
            return this.subject + " " + this.date;
        }
    }
}
