namespace pubssemana3.Formularios
{
    partial class FormuTrabajos
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 34);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "TRABAJOS";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 31);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 66);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(-1, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 515);
            panel2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(284, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(95, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 158);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 10;
            label5.Text = "Salario Max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 116);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "Salario Min";
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
            // FormuTrabajos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 641);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormuTrabajos";
            Text = "FormuTrabajos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
    }
}