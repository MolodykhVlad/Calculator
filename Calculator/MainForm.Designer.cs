
namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SvorotButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.labelTopPanel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFormula1 = new System.Windows.Forms.Button();
            this.labelFormula1 = new System.Windows.Forms.Label();
            this.labelFormulaAnatasion1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonFormula3 = new System.Windows.Forms.Button();
            this.labelFormula3 = new System.Windows.Forms.Label();
            this.labelFormulaAnatasion3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonFormula4 = new System.Windows.Forms.Button();
            this.labelFormula4 = new System.Windows.Forms.Label();
            this.labelFormulaAnatasion4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFormula2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.TopPanel.Controls.Add(this.SvorotButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.labelTopPanel);
            this.TopPanel.Location = new System.Drawing.Point(-3, -1);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(741, 80);
            this.TopPanel.TabIndex = 0;
            // 
            // SvorotButton
            // 
            this.SvorotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SvorotButton.ForeColor = System.Drawing.Color.White;
            this.SvorotButton.Location = new System.Drawing.Point(573, 0);
            this.SvorotButton.Name = "SvorotButton";
            this.SvorotButton.Size = new System.Drawing.Size(24, 26);
            this.SvorotButton.TabIndex = 3;
            this.SvorotButton.Text = "—";
            this.SvorotButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SvorotButton.Click += new System.EventHandler(this.SvorotButton_Click);
            this.SvorotButton.MouseEnter += new System.EventHandler(this.SvorotButton_MouseEnter);
            this.SvorotButton.MouseLeave += new System.EventHandler(this.SvorotButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(601, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 26);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // labelTopPanel
            // 
            this.labelTopPanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopPanel.ForeColor = System.Drawing.Color.White;
            this.labelTopPanel.Location = new System.Drawing.Point(2, 0);
            this.labelTopPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTopPanel.Name = "labelTopPanel";
            this.labelTopPanel.Size = new System.Drawing.Size(623, 80);
            this.labelTopPanel.TabIndex = 1;
            this.labelTopPanel.Text = "Рассчет давления в скважине";
            this.labelTopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTopPanel_MouseDown);
            this.labelTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTopPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonFormula1);
            this.panel3.Controls.Add(this.labelFormula1);
            this.panel3.Controls.Add(this.labelFormulaAnatasion1);
            this.panel3.Location = new System.Drawing.Point(18, 95);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 180);
            this.panel3.TabIndex = 8;
            // 
            // buttonFormula1
            // 
            this.buttonFormula1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonFormula1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.buttonFormula1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFormula1.FlatAppearance.BorderSize = 0;
            this.buttonFormula1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormula1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormula1.ForeColor = System.Drawing.Color.White;
            this.buttonFormula1.Location = new System.Drawing.Point(160, 133);
            this.buttonFormula1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFormula1.Name = "buttonFormula1";
            this.buttonFormula1.Size = new System.Drawing.Size(113, 30);
            this.buttonFormula1.TabIndex = 2;
            this.buttonFormula1.Text = "Рассчитать";
            this.buttonFormula1.UseVisualStyleBackColor = false;
            this.buttonFormula1.Click += new System.EventHandler(this.buttonFormula1_Click);
            this.buttonFormula1.MouseEnter += new System.EventHandler(this.buttonFormula1_MouseEnter);
            this.buttonFormula1.MouseLeave += new System.EventHandler(this.buttonFormula1_MouseLeave);
            // 
            // labelFormula1
            // 
            this.labelFormula1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.labelFormula1.Location = new System.Drawing.Point(20, 101);
            this.labelFormula1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormula1.Name = "labelFormula1";
            this.labelFormula1.Size = new System.Drawing.Size(136, 23);
            this.labelFormula1.TabIndex = 1;
            this.labelFormula1.Text = "Рпл. = ρ*g*H";
            this.labelFormula1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFormulaAnatasion1
            // 
            this.labelFormulaAnatasion1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormulaAnatasion1.Location = new System.Drawing.Point(19, 28);
            this.labelFormulaAnatasion1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormulaAnatasion1.Name = "labelFormulaAnatasion1";
            this.labelFormulaAnatasion1.Size = new System.Drawing.Size(254, 77);
            this.labelFormulaAnatasion1.TabIndex = 0;
            this.labelFormulaAnatasion1.Text = "Уровень жидкости в скважине расположен ниже ее устья";
            this.labelFormulaAnatasion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.buttonFormula3);
            this.panel4.Controls.Add(this.labelFormula3);
            this.panel4.Controls.Add(this.labelFormulaAnatasion3);
            this.panel4.Location = new System.Drawing.Point(18, 292);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 180);
            this.panel4.TabIndex = 10;
            // 
            // buttonFormula3
            // 
            this.buttonFormula3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonFormula3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFormula3.FlatAppearance.BorderSize = 0;
            this.buttonFormula3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormula3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormula3.ForeColor = System.Drawing.Color.White;
            this.buttonFormula3.Location = new System.Drawing.Point(160, 134);
            this.buttonFormula3.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFormula3.Name = "buttonFormula3";
            this.buttonFormula3.Size = new System.Drawing.Size(113, 30);
            this.buttonFormula3.TabIndex = 3;
            this.buttonFormula3.Text = "Рассчитать";
            this.buttonFormula3.UseVisualStyleBackColor = false;
            // 
            // labelFormula3
            // 
            this.labelFormula3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.labelFormula3.Location = new System.Drawing.Point(29, 47);
            this.labelFormula3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormula3.Name = "labelFormula3";
            this.labelFormula3.Size = new System.Drawing.Size(122, 23);
            this.labelFormula3.TabIndex = 2;
            this.labelFormula3.Text = "Pпл. = (H*ρ)/C";
            this.labelFormula3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFormula3.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelFormulaAnatasion3
            // 
            this.labelFormulaAnatasion3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormulaAnatasion3.Location = new System.Drawing.Point(27, 23);
            this.labelFormulaAnatasion3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormulaAnatasion3.Name = "labelFormulaAnatasion3";
            this.labelFormulaAnatasion3.Size = new System.Drawing.Size(246, 32);
            this.labelFormulaAnatasion3.TabIndex = 1;
            this.labelFormulaAnatasion3.Text = "Практические расчеты ";
            this.labelFormulaAnatasion3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.buttonFormula4);
            this.panel5.Controls.Add(this.labelFormula4);
            this.panel5.Controls.Add(this.labelFormulaAnatasion4);
            this.panel5.Location = new System.Drawing.Point(319, 292);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 180);
            this.panel5.TabIndex = 11;
            // 
            // buttonFormula4
            // 
            this.buttonFormula4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.buttonFormula4.FlatAppearance.BorderSize = 0;
            this.buttonFormula4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormula4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormula4.ForeColor = System.Drawing.Color.White;
            this.buttonFormula4.Location = new System.Drawing.Point(155, 134);
            this.buttonFormula4.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFormula4.Name = "buttonFormula4";
            this.buttonFormula4.Size = new System.Drawing.Size(113, 30);
            this.buttonFormula4.TabIndex = 3;
            this.buttonFormula4.Text = "Рассчитать";
            this.buttonFormula4.UseVisualStyleBackColor = false;
            this.buttonFormula4.Click += new System.EventHandler(this.buttonFormula4_Click);
            this.buttonFormula4.MouseEnter += new System.EventHandler(this.buttonFormula4_MouseEnter);
            this.buttonFormula4.MouseLeave += new System.EventHandler(this.buttonFormula4_MouseLeave);
            // 
            // labelFormula4
            // 
            this.labelFormula4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.labelFormula4.Location = new System.Drawing.Point(15, 91);
            this.labelFormula4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormula4.Name = "labelFormula4";
            this.labelFormula4.Size = new System.Drawing.Size(141, 23);
            this.labelFormula4.TabIndex = 2;
            this.labelFormula4.Text = "Рпл. = Рст. * e^s";
            this.labelFormula4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFormula4.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelFormulaAnatasion4
            // 
            this.labelFormulaAnatasion4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormulaAnatasion4.Location = new System.Drawing.Point(14, 14);
            this.labelFormulaAnatasion4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormulaAnatasion4.Name = "labelFormulaAnatasion4";
            this.labelFormulaAnatasion4.Size = new System.Drawing.Size(262, 82);
            this.labelFormulaAnatasion4.TabIndex = 1;
            this.labelFormulaAnatasion4.Text = "Рассчет по барометрическая формуле ";
            this.labelFormulaAnatasion4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonFormula2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(319, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 180);
            this.panel1.TabIndex = 12;
            // 
            // buttonFormula2
            // 
            this.buttonFormula2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonFormula2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFormula2.FlatAppearance.BorderSize = 0;
            this.buttonFormula2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormula2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormula2.ForeColor = System.Drawing.Color.White;
            this.buttonFormula2.Location = new System.Drawing.Point(155, 133);
            this.buttonFormula2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFormula2.Name = "buttonFormula2";
            this.buttonFormula2.Size = new System.Drawing.Size(113, 30);
            this.buttonFormula2.TabIndex = 4;
            this.buttonFormula2.Text = "Рассчитать";
            this.buttonFormula2.UseVisualStyleBackColor = false;
            this.buttonFormula2.Click += new System.EventHandler(this.buttonFormula2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Рпл. = ρ*g*L + Ру";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 71);
            this.label2.TabIndex = 1;
            this.label2.Text = "В неработающей скважине имеется избыточное давление ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(622, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.TopPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label labelTopPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelFormula1;
        private System.Windows.Forms.Label labelFormulaAnatasion1;
        private System.Windows.Forms.Label labelFormula3;
        private System.Windows.Forms.Label labelFormulaAnatasion3;
        private System.Windows.Forms.Label labelFormula4;
        private System.Windows.Forms.Label labelFormulaAnatasion4;
        private System.Windows.Forms.Button buttonFormula1;
        private System.Windows.Forms.Button buttonFormula3;
        private System.Windows.Forms.Button buttonFormula4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFormula2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label SvorotButton;
    }
}

