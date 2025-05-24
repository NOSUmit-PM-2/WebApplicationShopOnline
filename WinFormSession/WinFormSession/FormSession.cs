using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSession
{
    public partial class FormSession : Form
    {
        List<Exam> exams = new List<Exam>();
        void ShowListExams()
        { 
            listBoxExams.Items.Clear();
            foreach (var item in exams)
            {
                listBoxExams.Items.Add(item);
            }
        }
        public FormSession()
        {
            InitializeComponent();
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            FormAddSubject formAddSubject = new FormAddSubject();
            formAddSubject.ShowDialog();
            exams.Add(new Exam(formAddSubject.Subject));
            ShowListExams();    
        }

        private void buttonSetDate_Click(object sender, EventArgs e)
        {
            int currentIndex = listBoxExams.SelectedIndex;
            exams[currentIndex].Date = "33.06.25";
            ShowListExams();
        }
    }
}
