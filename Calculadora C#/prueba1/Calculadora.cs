using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void uno_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "9";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "0";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Resultado.Text);

            double sum;
            double rest;
            double mult;
            double div;

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    Resultado.Text = sum.ToString();
                    break;
                case "-":
                    rest = obj2.Restar((primero), (segundo));
                    Resultado.Text = rest.ToString();
                    break;
                case "*":
                    mult = obj3.Multiplicarr((primero), (segundo));
                    Resultado.Text = mult.ToString();
                    break;
                case "/":
                    div = obj4.Dividir((primero), (segundo));
                    Resultado.Text = div.ToString();
                    break;
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Resultado.Clear();
        }

        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            if (Resultado.Text.Length == 1)
                Resultado.Text = "";
            else
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
        }
    }
}
