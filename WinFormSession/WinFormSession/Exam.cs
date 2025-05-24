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

        public string Subject { get; }
        public string Date 
        {
            get
            {
                return date;
            }
            set 
            {
                string[] temp = value.Split('.');
                int day = Convert.ToInt32(temp[0]);
                int month = Convert.ToInt32(temp[1]);
                int year = Convert.ToInt32(temp[2]);
                if (9 < day && day <= 30)
                    if (month == 6)
                        if (year == 25 || year == 2025)
                        {
                            date = value;
                        }
            }
        }

        public Exam(string subject)
        {
            this.subject = subject;
        }
         
        public override string ToString()
        {
            return this.subject + " " + this.date;
        }
    }
}
