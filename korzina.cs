using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacatonPril
{
    public partial class korzina : Form
    {
        public korzina()
        {
            InitializeComponent();
        }



        private Form ActiveForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(), sender);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
