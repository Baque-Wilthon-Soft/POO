namespace pubssemana3.Formularios
{
    partial class FormuVentas
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
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 34);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "VENTAS";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(-1, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 515);
            panel2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(284, 28);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(95, 23);
            comboBox3.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(155, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 23);
            comboBox2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(155, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 198);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 14;
            label6.Text = "Pago";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 23);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 159);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 10;
            label5.Text = "Titulo Asociado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 116);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Orden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 73);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "# de Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 31);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "ID de Tienda";
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
            // FormuVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 641);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormuVentas";
            Text = "FormuVentas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}