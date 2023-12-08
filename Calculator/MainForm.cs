using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(227, 0, 0);
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(29, 29, 31);
        }

        Point lastPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SvorotButton_MouseEnter(object sender, EventArgs e)
        {
           SvorotButton.BackColor = Color.FromArgb(82, 82, 82);
        }

        private void SvorotButton_MouseLeave(object sender, EventArgs e)
        {
            SvorotButton.BackColor = Color.FromArgb(29, 29, 31);
        }

        private void buttonFormula4_MouseEnter(object sender, EventArgs e)
        {
            buttonFormula4.BackColor = Color.FromArgb(82, 82, 82);
        }

        private void buttonFormula4_MouseLeave(object sender, EventArgs e)
        {
            buttonFormula4.BackColor = Color.FromArgb(29, 29, 31);
        }

        private void buttonFormula1_MouseEnter(object sender, EventArgs e)
        {
            buttonFormula1.BackColor = Color.FromArgb(82, 82, 82);
        }

        private void buttonFormula1_MouseLeave(object sender, EventArgs e)
        {
            buttonFormula1.BackColor = Color.FromArgb(29, 29, 31);
        }

        private void buttonFormula1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula1 formformula_1 = new FormFormula1();
            formformula_1.Show();
        }

        private void SvorotButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonFormula2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFormula2 formformula_2 = new FormFormula2();
            formformula_2.Show();
        }

        

        private void buttonFormula4_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
