using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Ejercicio25
{

    public partial class Form1 : Form
    {
        private static double PRECIO_LETRA_TARTA = 0.25d;
        private static int MAX_LETRAS_TARTA_PEQ = 16;
        private static int MIN_LETRAS_TARTA_GRANDE = 40;
        
        public Form1()
        {
            InitializeComponent();

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void checkBox2_Saludable_CheckedChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void checkBox1_Lujo_CheckedChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void SinCalculo()
        {
           

            if (numericUpDown1.Value < 1 | numericUpDown2.Value < 1)
            {
                textBoxTotal.ForeColor = Color.Red;
                textBox_Coste_Cumple.ForeColor = Color.Red;
            }
            if (numericUpDown1.Value >= 1 | numericUpDown2.Value >= 1)
            {
                textBoxTotal.ForeColor = Color.Black;
                textBox_Coste_Cumple.ForeColor = Color.Black;
            }
        }

        private void Actualizar()
        {
            SinCalculo();
            Cenas cena = new Cenas();
            cena.NumPersonas = Convert.ToInt32(numericUpDown1.Value);
            cena.DecoracionLujo = checkBox1_Lujo.Checked;
            cena.OpcionSaludable = checkBox2_Saludable.Checked;
            textBoxTotal.Text = Convert.ToString(cena.calcularCoste());
            

        }

        // programación pestaña 2
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Actualizar2();
        }

        private void checkBox1_Cumple_CheckedChanged(object sender, EventArgs e)
        {
            Actualizar2();
        }

        private void textBox_Texto_Tarta_TextChanged(object sender, EventArgs e)
        {
            Actualizar2();
            
        }

        private void Actualizar2()
        {

            SinCalculo();
            Cumpleaños cumple = new Cumpleaños();
            cumple.NumPersonas = Convert.ToInt32(numericUpDown2.Value);
            cumple.DecoracionLujo = checkBox1_Cumple.Checked;
            textBox_Coste_Cumple.Text = Convert.ToString(cumple.calcularCoste());

            if (cumple.NumPersonas == 0)
            {
                SinCalculo();
                textBox_Coste_Cumple.Text = "0";
            }
            else
            {
                if (hayTextoEnTarta)
                {

                    if (cumple.NumPersonas > 8)
                    {
                        textBox_Texto_Tarta.MaxLength = MIN_LETRAS_TARTA_GRANDE;
                        textBox_Coste_Cumple.Text = Convert.ToString(CosteLetrasTarta() + cumple.calcularCoste());


                    }
                    else
                    {
                        if (textBox_Texto_Tarta.TextLength > MAX_LETRAS_TARTA_PEQ)
                        {
                            DialogResult result = MessageBox.Show("No puede poner tantas letras en la tarta pequeña.\nPara poder elegir la opción de la tarta grande, se necesita como mínimo 9 personas.\n¿Deseas cambiar el texto de la tarta? ", "Error", MessageBoxButtons.YesNo);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                textBox_Texto_Tarta.Text = "";
                            }
                            else
                            {
                                numericUpDown2.Value += 1;
                            }
                        }
                        else
                        {

                            textBox_Texto_Tarta.MaxLength = MAX_LETRAS_TARTA_PEQ;
                            textBox_Coste_Cumple.Text = Convert.ToString(CosteLetrasTarta() + cumple.calcularCoste());
                        }
                    }
                }
            }
        }

        private bool hayTextoEnTarta => textBox_Texto_Tarta.TextLength>0; 
        private double CosteLetrasTarta()
        {
            return textBox_Texto_Tarta.TextLength* PRECIO_LETRA_TARTA;
        }

        private void PestañaCenas_Click(object sender, EventArgs e)
        {

        }
    }
}
