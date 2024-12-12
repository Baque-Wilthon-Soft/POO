namespace pubssemana3.Formularios
{
    partial class FormuAutorTitulo
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
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(-1, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 515);
            panel2.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(155, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 23);
            comboBox2.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(329, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 23);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 116);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 8;
            label4.Text = "% de Regalía";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 73);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 31);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Autor";
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "AUTOR Y TÍTULO";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 11;
            // 
            // FormuAutorTitulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 641);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormuAutorTitulo";
            Text = "FormuAutorTitulo";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Panel panel1;
    }
}