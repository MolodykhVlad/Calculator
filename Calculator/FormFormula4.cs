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
    public partial class FormFormula4 : Form
    {
        public FormFormula4()
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
                double ro = Convert.ToDouble(textBox_ro_form4.Text);
                double Pst = Convert.ToDouble(textBox_Pst_form4.Text);
                double L = Convert.ToDouble(textBox_L_form4.Text);
                double Exp = Convert.ToDouble(textBox_Exp_form4.Text);
                double Tpkr = Convert.ToDouble(textBox_Tpkr_form4.Text);
                double Ppr = Convert.ToDouble(textBox_Ppr_form4.Text);
                double TL = Convert.ToDouble(textBox_TL_form4.Text);
                double Tns = Convert.ToDouble(textBox_Tns_form4.Text);
                double T = Convert.ToDouble(textBox_T_form4.Text);
                double P;
                double s;
                double z;
                double Tsr;
                double Tpr;
                Tsr = ((TL - Tns) / Math.Log(TL / Tns)) - 273;
                Tpr = T / Tpkr;
                z = Math.Pow((0.4 * Math.Log(Tpr) + 0.73), Ppr) + 0.1 * Ppr;
                s = (0.03415 * ro * L) / (z * Tsr)/ Math.Pow(10, 6);
                P = Math.Round(Pst * Math.Pow(Exp, s), 10);
                textBox_P_form4.Text = Convert.ToString(P);
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_P_form4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SvorotButton_formformula_1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
