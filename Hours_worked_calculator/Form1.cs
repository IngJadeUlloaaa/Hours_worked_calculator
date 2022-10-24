using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hours_worked_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we declare variables
            int dias, pagos, salario_bruto;
            double bonificacion, salario_neto;
            bool hijos;
            //read data
            dias = Convert.ToInt32(textday.Text);
            pagos = Convert.ToInt32(textdaysalary.Text);
            hijos = Convert.ToBoolean(checkson.Checked);

            salario_bruto = dias * pagos;

            //condictionals
            if(salario_bruto < 1000) {

                bonificacion = Convert.ToDouble(salario_bruto * 0.1);
            }
            else { 
            
                if(salario_bruto >= 1000 && salario_bruto <= 2500) {

                    bonificacion = Convert.ToDouble(salario_bruto * 0.2);
                }
                else {

                    bonificacion = Convert.ToDouble(salario_bruto * 0.25);
                }
            }

            //second condictional
            if (hijos == true) {

                bonificacion = bonificacion * 2;
            }

            salario_neto = Convert.ToDouble(salario_bruto + bonificacion);

            textgrosssalary.Text = Convert.ToString(salario_bruto);
            textbonus.Text = Convert.ToString(bonificacion);
            textnetsalary.Text = Convert.ToString(salario_neto);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear
            textdaysalary.Clear();
            textday.Clear();
            textgrosssalary.Clear();
            textbonus.Clear();
            textnetsalary.Clear();

            //focus
            textday.Focus();
        }
    }
}
