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
    public partial class FormFormula1 : Form
    {
        public FormFormula1()
        {
            InitializeComponent();
        }

        private void ExitButton_formformula_1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        

        private void ExitButton_formformula_1_MouseEnter(object sender, EventArgs e)
        {
            ExitButton_formformula_1.BackColor = Color.FromArgb(227, 0, 0);
        }

        private void ExitButton_formformula_1_MouseLeave(object sender, EventArgs e)
        {
            ExitButton_formformula_1.BackColor = Color.FromArgb(29, 29, 31);
        }

        private void SvorotButton_formformula_1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void SvorotButton_formformula_1_MouseEnter(object sender, EventArgs e)
        {
            SvorotButton_formformula_1.BackColor = Color.FromArgb(82, 82, 82);
        }

        private void SvorotButton_formformula_1_MouseLeave(object sender, EventArgs e)
        {
            SvorotButton_formformula_1.BackColor = Color.FromArgb(29, 29, 31);
        }

        Point lastPoint;

        private void FormFormula1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FormFormula1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTopPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTopPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonFormula4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Formula1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void ResultFormula1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double ro = Convert.ToDouble(textBox_ro_form1.Text);
                double g = Convert.ToDouble(textBox_g_form1.Text);
                double H = Convert.ToDouble(textBox_H_form1.Text);
                double P;
                P = ro * g * H;
                P = Math.Round(P, 8);
                P = P / 1000000;

                textBox_P_form1.Text = Convert.ToString(P);
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
