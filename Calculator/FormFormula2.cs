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
    public partial class FormFormula2 : Form
    {
        public FormFormula2()
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
            double p = Convert.ToDouble(textBox_p_form2.Text);
            double g = Convert.ToDouble(textBox_g_form2.Text);
            double L = Convert.ToDouble(textBox_L_form2.Text);
            double Pu = Convert.ToDouble(textBox_Pu_form2.Text);
            double PP;
            PP = p * g * L + Pu;
            PP = Math.Round(PP, 8);

            textBox_PP_form2.Text = Convert.ToString(PP);
        }
    }
}
