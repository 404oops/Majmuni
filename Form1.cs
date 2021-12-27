using System;
using System.Windows.Forms;
namespace Majmuni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pitanje, poeni;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Sledece";
            button2.Text = "Proveri";
            label3.Text = null;
            PrikaziSve();
            pitanje += 1;
            radioButton1.Checked = false;
            switch (pitanje)
            {
                case 1:
                    label1.Text = "Majmuni vole cokoadne bananice"; // Pitanja je smisljao Ognjen
                    break;
                case 2:
                    label1.Text = "Majmuni najvise vole da se penju na drvo";
                    break;
                case 3:
                    label1.Text = "Na slici je Veliki Majmun";
                    break;
                case 4:
                    label1.Text = "Ova vrsta je izumrla";
                    break;
                case 5:
                    label1.Text = "Gotovi smo!";
                    label3.Text = "Ukupni Poeni: " + poeni;
                    SakrijSve();
                    break;
            }
        }

        private void PrikaziSve() // Ideju smisljao Nikola
        {
            label1.Visible = true;
            label2.Visible = true;
            radioButton1.Visible = true;
            button2.Visible = true;
            button1.Left = 12;
            button1.Top = 145;
        }
        private void SakrijSve()
        {
            label2.Visible = false;
            radioButton1.Visible = false;
            button2.Visible = false;
            button1.Visible = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (pitanje)
            {
                case 1:
                    if (radioButton1.Checked == false)
                    {
                        gotovZadatak();
                    }
                    break;
                case 2:
                    if (radioButton1.Checked)
                    {
                        gotovZadatak();
                    }
                    break;
                case 3:
                    if (radioButton1.Checked)
                    {
                        gotovZadatak(20);
                    }
                    break;
                case 4:
                    if (radioButton1.Checked)
                    {
                        gotovZadatak(40); // Poene i ovaj sistem je smisljao Marko
                    }
                    break;
            }
        }

        private void gotovZadatak(int n = 10) // Marko
        {
            poeni += n;
            label2.Text = "Poeni: " + poeni;
        }
    }
}
