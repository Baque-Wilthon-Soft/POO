namespace pubssemana3.Formularios
{
    partial class FormuPublicadorInfo
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
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 73);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 31);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Publicador";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "INFO PUBLICADOR";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(comboBox1);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(155, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 23);
            comboBox2.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 116);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 107);
            textBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 115);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 8;
            label4.Text = "Info Adicional";
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
            // FormuPublicadorInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 641);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormuPublicadorInfo";
            Text = "FormuPublicadorInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
    }
}