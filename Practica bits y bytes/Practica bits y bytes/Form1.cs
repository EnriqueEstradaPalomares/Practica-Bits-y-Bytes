using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_bits_y_bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void btnprocess_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtnumero.Text);
            if (sensor1IsUp(numero))
                label1.Text = "ON";
            else
                label1.Text = "OFF";
            //--------------------------------------
            if (sensor2IsUp(numero))
                label2.Text = "ON";
            else
                label2.Text = "OFF";
            //----------------------------------------
            lblLlenado.Text = llenadoState(numero);
            //---------------------------------------
            lblVieto.Text = directionWind(numero);
            //-----------------------------------
            lblData.Text = date(numero);
        }

        private bool sensor1IsUp(int num)
        {
            num>>= 6;// recorre 6 posisiones dejando el bit 6 en posision 1
            if ((byte)(num & 1) == 1)//AND y compara con 1
            {
                return true;
            }
            else
                return false;
        }

        private bool sensor2IsUp(int num)
        {
            num>>= 6;
            if ((byte)(num & 1) == 1)
            {
                return true;
            }
            else
                return false;
        }
        private string llenadoState(int num)
        {
            num>>= 4;
            byte a = ((byte)(num & 3));
            switch(a)
            {
                case 0:
                    return "Vacio (0%)";
                    break;
                case 1:
                    return "Nivel Medion (50%)";
                    break;
                case 2:
                    return "Nivel Lleno (100%)";
                    break;
                case 3:
                    return "En proceso (+%)";
                    break;
                default:
                    return "N/A";
                    break;
            }
        }

        private string directionWind(int num)
        {
            num>>= 1;
            byte a = ((byte)(num & 6));
            switch (a)
            {
                case 0:
                    return "N";
                    break;
                case 1:
                    return "NE";
                    break;
                case 2:
                    return "E";
                    break;
                case 3:
                    return "SE";
                    break;
                case 4:
                    return "S";
                    break;
                case 5:
                    return "SO";
                    break;
                case 6:
                    return "O";
                    break;
                default:
                    return "NO";
                    break;
            }
        }

        private string date(int num)
        {
            byte dia;
            byte mes;
            int year;
            dia = (byte)(num & 31);
            num>>=  5;
            mes = (byte)(num & 15);
            if (mes > 12)
                mes = 12;
            num >>= 4;
            year = (byte)(num & 127);
            year += 1990;
            return year + "/" + mes + "/" + dia;
        }

        private void btnProcessData_Click(object sender, EventArgs e)
        {
            int dia = dateTimePicker1.Value.Day;
            int mes = dateTimePicker1.Value.Month;
            int anio = dateTimePicker1.Value.Year;
            txtNum.Text = Convert.ToString(processData(dia, mes, anio));
        }

        private int processData(int dia, int mes, int anio)
        {
            int fecha;
            anio -= 1900;
            fecha = (byte)(dia);
            mes <<= 5;
            fecha = fecha | mes;
            anio <<= 9;
            fecha = fecha | anio;
            return fecha;
        }
    }
}
