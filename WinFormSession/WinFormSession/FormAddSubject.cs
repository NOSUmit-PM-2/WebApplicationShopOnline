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
    public partial class FormAddSubject : Form
    {
        public string Subject { get; set; }

        public FormAddSubject()
        {
            InitializeComponent();
        }

        private void buttonSaveSubject_Click(object sender, EventArgs e)
        {
            Subject = textSubject.Text;
            this.Close();
        }
    }
}
