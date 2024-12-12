namespace pubssemana3.Formularios
{
    partial class FormuTitulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(95, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 34);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "TITULOS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(284, 456);
            button1.Name = "button1";
            button1.Size = new Size(108, 45);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(9, 456);
            button2.Name = "button2";
            button2.Size = new Size(108, 45);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 515);
            panel2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(155, 303);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(70, 348);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 18;
            label9.Text = "Publicador";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(155, 345);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(224, 23);
            textBox8.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 305);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 16;
            label8.Text = "Fecha de Publi.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 256);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 14;
            label7.Text = "Ventas Acu";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(155, 253);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(224, 23);
            textBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 210);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 12;
            label6.Text = "Regalías";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 207);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 23);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 162);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "Avance";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 23);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 116);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 73);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Tipo";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 70);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 31);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Titulo";
            // 
            // FormuTitulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 641);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormuTitulos";
            Text = "FormuTitulos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Label label2;
        private Label label9;
        private TextBox textBox8;
        private Label label8;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
    }
}