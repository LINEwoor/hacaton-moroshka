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
    

    public partial class Form2 : Form
    {
        public Form2()
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
            Form1 frmGen = new Form1();

            //this.Close();
            OpenChildForm(new Form1(), sender);
            //frmGen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new korzina(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new korzina(), sender);
        }
    }
}
