using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calorias()
        {
            //Declaramos las variables
            double altura, caloria, edad, peso, RBM;
            string actividad;
            //Condiciones que evalúan si los campos de Texto esta vacíos
            if (TextBox_Altura.Text == "")
            {
                MessageBox.Show("Ingrese la altura", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBox_Altura.Focus();
            }
            else
            {
                if (TextBox_Edad.Text == "")
                {
                    MessageBox.Show("Ingrese la edad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBox_Edad.Focus();
                }
                else
                {
                    if (TextBox_Peso.Text == "")
                    {
                        MessageBox.Show("Ingrese el peso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBox_Peso.Focus();
                    }
                    else
                    {
                        //Métodos que convierte en un tipo double el valor que se ingrese por el TextBox
                        altura = Convert.ToDouble(TextBox_Altura.Text);
                        edad = Convert.ToDouble(TextBox_Edad.Text);
                        peso = Convert.ToDouble(TextBox_Peso.Text);
                        //Método para extraer el Item seleccionado en ComboBox
                        actividad = ComboBox_Actividades.SelectedItem.ToString();

                        //La sentencia switch 
                        switch (actividad)
                        {
                            case"Actividades":
                                MessageBox.Show("Seleccione una actvidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case"Sedentaria":
                            //Condición que evalúa el RadioButton si es seleccionado
                                if (RadioButton_F.Checked)
                                {
                                    //Formula del RITMO METABÓLICO BASAL femenino
                                    RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad);
                                    caloria = (RBM * 1.2);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                else
                                {
                                    //Formula del RITMO METABÓLICO BASAL masculino
                                    RBM = 66 + (13.7* peso) + (5 * altura) - (6.8 * edad);
                                    caloria = (RBM * 1.2);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                break;
                            case "Ligera":
                                //Condición que evalúa el RadioButton si es seleccionado
                                if (RadioButton_F.Checked)
                                {
                                    //Formula del RITMO METABÓLICO BASAL femenino
                                    RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad);
                                    caloria = (RBM * 1.375);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                else
                                {
                                    //Formula del RITMO METABÓLICO BASAL masculino
                                    RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad);
                                    caloria = (RBM * 1.375);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                break;
                            case "Moderada":
                                //Condición que evalúa el RadioButton si es seleccionado
                                if (RadioButton_F.Checked)
                                {
                                    //Formula del RITMO METABÓLICO BASAL femenino
                                    RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad);
                                    caloria = (RBM * 1.55);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                else
                                {
                                    //Formula del RITMO METABÓLICO BASAL masculino
                                    RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad);
                                    caloria = (RBM * 1.55);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                break;
                            case "Dinamica":
                                //Condición que evalúa el RadioButton si es seleccionado
                                if (RadioButton_F.Checked)
                                {
                                    //Formula del RITMO METABÓLICO BASAL femenino
                                    RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad);
                                    caloria = (RBM * 1.725);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                else
                                {
                                    //Formula del RITMO METABÓLICO BASAL masculino
                                    RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad);
                                    caloria = (RBM * 1.725);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                break;
                            case "Muy dinamica":
                                //Condición que evalúa el RadioButton si es seleccionado
                                if (RadioButton_F.Checked)
                                {
                                    //Formula del RITMO METABÓLICO BASAL femenino
                                    RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad);
                                    caloria = (RBM * 1.9);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                else
                                {
                                    //Formula del RITMO METABÓLICO BASAL masculino
                                    RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad);
                                    caloria = (RBM * 1.9);
                                    Label_Calorias.Text = caloria.ToString();
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void Button_Calcular_Click(object sender, EventArgs e)
        {
            Calorias();
        }

        private void Button_Restaurar_Click(object sender, EventArgs e)
        {
            TextBox_Altura.Text = " ";
            TextBox_Edad.Text = " ";
            TextBox_Peso.Text = " ";
            Label_Calorias.Text = "0";
            TextBox_Altura.Focus();
            ComboBox_Actividades.SelectedItem = "Actividades";

        }
    }
}
    

                     
     