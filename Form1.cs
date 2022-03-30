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
    public partial class Form1 : Form
    {
        


        public Form1()
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


            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Form2(), sender);
            // this.Hide();
            //Form2 frmProf = new Form2();
            //frmProf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new korzina(), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            panel1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            pictureBox1.Visible = true;
            button11.Visible = true;
            textBox2.Text = "описание 1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            panel1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            pictureBox1.Visible = true;
            button11.Visible = true;
            textBox2.Text = "описание 2";
            //tovar1 frmt1 = new tovar1();
            //frmt1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            panel1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            pictureBox1.Visible = true;
            button11.Visible = true;
            textBox2.Text = "описание 2";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button10.Visible = false;
            panel1.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            pictureBox1.Visible = false;
            button11.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            panel1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            pictureBox1.Visible = true;
            button11.Visible = true;
            textBox2.Text = "описание 3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            panel1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            pictureBox1.Visible = true;
            button11.Visible = true;
            textBox2.Text = "описание 4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            panel1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            pictureBox1.Visible = true;
            button11.Visible = true;
            textBox2.Text = "описание 5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            panel1.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            pictureBox1.Visible = true;
            button11.Visible = true;
            textBox2.Text = "описание 6";
        }
    }
}
