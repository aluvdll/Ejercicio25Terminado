namespace Ejercicio25
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PestañaCenas = new System.Windows.Forms.TabPage();
            this.checkBox2_Saludable = new System.Windows.Forms.CheckBox();
            this.checkBox1_Lujo = new System.Windows.Forms.CheckBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.lbl_Coste = new System.Windows.Forms.Label();
            this.lbl_opcion_saludable = new System.Windows.Forms.Label();
            this.lbl_Deco_Lujo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_num_personas = new System.Windows.Forms.Label();
            this.PestañaCumpleaños = new System.Windows.Forms.TabPage();
            this.textBox_Coste_Cumple = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Texto_Tarta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1_Cumple = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PestañaCenas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.PestañaCumpleaños.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PestañaCenas);
            this.tabControl1.Controls.Add(this.PestañaCumpleaños);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(278, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // PestañaCenas
            // 
            this.PestañaCenas.BackColor = System.Drawing.Color.Linen;
            this.PestañaCenas.Controls.Add(this.checkBox2_Saludable);
            this.PestañaCenas.Controls.Add(this.checkBox1_Lujo);
            this.PestañaCenas.Controls.Add(this.textBoxTotal);
            this.PestañaCenas.Controls.Add(this.lbl_Coste);
            this.PestañaCenas.Controls.Add(this.lbl_opcion_saludable);
            this.PestañaCenas.Controls.Add(this.lbl_Deco_Lujo);
            this.PestañaCenas.Controls.Add(this.numericUpDown1);
            this.PestañaCenas.Controls.Add(this.lbl_num_personas);
            this.PestañaCenas.Location = new System.Drawing.Point(4, 25);
            this.PestañaCenas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PestañaCenas.Name = "PestañaCenas";
            this.PestañaCenas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PestañaCenas.Size = new System.Drawing.Size(270, 251);
            this.PestañaCenas.TabIndex = 0;
            this.PestañaCenas.Text = "Cenas";
            this.PestañaCenas.Click += new System.EventHandler(this.PestañaCenas_Click);
            // 
            // checkBox2_Saludable
            // 
            this.checkBox2_Saludable.AutoSize = true;
            this.checkBox2_Saludable.Location = new System.Drawing.Point(194, 117);
            this.checkBox2_Saludable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2_Saludable.Name = "checkBox2_Saludable";
            this.checkBox2_Saludable.Size = new System.Drawing.Size(18, 17);
            this.checkBox2_Saludable.TabIndex = 5;
            this.checkBox2_Saludable.UseVisualStyleBackColor = true;
            this.checkBox2_Saludable.CheckedChanged += new System.EventHandler(this.checkBox2_Saludable_CheckedChanged);
            // 
            // checkBox1_Lujo
            // 
            this.checkBox1_Lujo.AutoSize = true;
            this.checkBox1_Lujo.Location = new System.Drawing.Point(194, 77);
            this.checkBox1_Lujo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1_Lujo.Name = "checkBox1_Lujo";
            this.checkBox1_Lujo.Size = new System.Drawing.Size(18, 17);
            this.checkBox1_Lujo.TabIndex = 1;
            this.checkBox1_Lujo.UseVisualStyleBackColor = true;
            this.checkBox1_Lujo.CheckedChanged += new System.EventHandler(this.checkBox1_Lujo_CheckedChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(132, 168);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(121, 22);
            this.textBoxTotal.TabIndex = 4;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Coste
            // 
            this.lbl_Coste.AutoSize = true;
            this.lbl_Coste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Coste.Location = new System.Drawing.Point(12, 173);
            this.lbl_Coste.Name = "lbl_Coste";
            this.lbl_Coste.Size = new System.Drawing.Size(54, 17);
            this.lbl_Coste.TabIndex = 3;
            this.lbl_Coste.Text = "Coste:";
            // 
            // lbl_opcion_saludable
            // 
            this.lbl_opcion_saludable.AutoSize = true;
            this.lbl_opcion_saludable.Location = new System.Drawing.Point(12, 118);
            this.lbl_opcion_saludable.Name = "lbl_opcion_saludable";
            this.lbl_opcion_saludable.Size = new System.Drawing.Size(113, 16);
            this.lbl_opcion_saludable.TabIndex = 2;
            this.lbl_opcion_saludable.Text = "Opción saludable";
            // 
            // lbl_Deco_Lujo
            // 
            this.lbl_Deco_Lujo.AutoSize = true;
            this.lbl_Deco_Lujo.Location = new System.Drawing.Point(12, 78);
            this.lbl_Deco_Lujo.Name = "lbl_Deco_Lujo";
            this.lbl_Deco_Lujo.Size = new System.Drawing.Size(124, 16);
            this.lbl_Deco_Lujo.TabIndex = 1;
            this.lbl_Deco_Lujo.Text = "Decoración de Lujo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(194, 30);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_num_personas
            // 
            this.lbl_num_personas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_num_personas.AutoSize = true;
            this.lbl_num_personas.Location = new System.Drawing.Point(12, 34);
            this.lbl_num_personas.Name = "lbl_num_personas";
            this.lbl_num_personas.Size = new System.Drawing.Size(134, 16);
            this.lbl_num_personas.TabIndex = 0;
            this.lbl_num_personas.Text = "Número de personas";
            // 
            // PestañaCumpleaños
            // 
            this.PestañaCumpleaños.BackColor = System.Drawing.Color.Gainsboro;
            this.PestañaCumpleaños.Controls.Add(this.textBox_Coste_Cumple);
            this.PestañaCumpleaños.Controls.Add(this.label4);
            this.PestañaCumpleaños.Controls.Add(this.textBox_Texto_Tarta);
            this.PestañaCumpleaños.Controls.Add(this.label3);
            this.PestañaCumpleaños.Controls.Add(this.checkBox1_Cumple);
            this.PestañaCumpleaños.Controls.Add(this.label2);
            this.PestañaCumpleaños.Controls.Add(this.numericUpDown2);
            this.PestañaCumpleaños.Controls.Add(this.label1);
            this.PestañaCumpleaños.Location = new System.Drawing.Point(4, 25);
            this.PestañaCumpleaños.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PestañaCumpleaños.Name = "PestañaCumpleaños";
            this.PestañaCumpleaños.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PestañaCumpleaños.Size = new System.Drawing.Size(270, 251);
            this.PestañaCumpleaños.TabIndex = 1;
            this.PestañaCumpleaños.Text = "Cumpleaños";
            // 
            // textBox_Coste_Cumple
            // 
            this.textBox_Coste_Cumple.Location = new System.Drawing.Point(110, 200);
            this.textBox_Coste_Cumple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Coste_Cumple.Name = "textBox_Coste_Cumple";
            this.textBox_Coste_Cumple.Size = new System.Drawing.Size(133, 22);
            this.textBox_Coste_Cumple.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coste:";
            // 
            // textBox_Texto_Tarta
            // 
            this.textBox_Texto_Tarta.Location = new System.Drawing.Point(15, 156);
            this.textBox_Texto_Tarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Texto_Tarta.Name = "textBox_Texto_Tarta";
            this.textBox_Texto_Tarta.Size = new System.Drawing.Size(228, 22);
            this.textBox_Texto_Tarta.TabIndex = 6;
            this.textBox_Texto_Tarta.TextChanged += new System.EventHandler(this.textBox_Texto_Tarta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto en la Tarta:";
            // 
            // checkBox1_Cumple
            // 
            this.checkBox1_Cumple.AutoSize = true;
            this.checkBox1_Cumple.Location = new System.Drawing.Point(193, 82);
            this.checkBox1_Cumple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1_Cumple.Name = "checkBox1_Cumple";
            this.checkBox1_Cumple.Size = new System.Drawing.Size(18, 17);
            this.checkBox1_Cumple.TabIndex = 3;
            this.checkBox1_Cumple.UseVisualStyleBackColor = true;
            this.checkBox1_Cumple.CheckedChanged += new System.EventHandler(this.checkBox1_Cumple_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decoración de Lujo";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(184, 34);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de personas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(273, 284);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Planificador";
            this.tabControl1.ResumeLayout(false);
            this.PestañaCenas.ResumeLayout(false);
            this.PestañaCenas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.PestañaCumpleaños.ResumeLayout(false);
            this.PestañaCumpleaños.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PestañaCenas;
        private System.Windows.Forms.TabPage PestañaCumpleaños;
        private System.Windows.Forms.Label lbl_num_personas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_opcion_saludable;
        private System.Windows.Forms.Label lbl_Deco_Lujo;
        private System.Windows.Forms.CheckBox checkBox2_Saludable;
        private System.Windows.Forms.CheckBox checkBox1_Lujo;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label lbl_Coste;
        private System.Windows.Forms.TextBox textBox_Coste_Cumple;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Texto_Tarta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1_Cumple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
    }
}

