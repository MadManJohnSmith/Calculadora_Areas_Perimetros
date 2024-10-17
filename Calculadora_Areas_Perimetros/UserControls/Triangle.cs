using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Areas_Perimetros.UserControls
{
    public partial class Triangle : UserControl
    {
        public Triangle()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLadoA.Text = "";
            tbLadoB.Text = "";
            tbLadoC.Text = "";
            tbAngAlfa.Text = "";
            tbAngBeta.Text = "";
            tbAngGamma.Text = "";
            tbAltA.Text = "";
            tbAltB.Text = "";
            tbAltC.Text = "";
            tbArea.Text = "";
            tbPerimetro.Text = "";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables para los valores de los lados, ángulos, área, perímetro y alturas
                double? ladoA = string.IsNullOrEmpty(tbLadoA.Text) ? (double?)null : double.Parse(tbLadoA.Text);
                double? ladoB = string.IsNullOrEmpty(tbLadoB.Text) ? (double?)null : double.Parse(tbLadoB.Text);
                double? ladoC = string.IsNullOrEmpty(tbLadoC.Text) ? (double?)null : double.Parse(tbLadoC.Text);

                double? angAlfa = string.IsNullOrEmpty(tbAngAlfa.Text) ? (double?)null : double.Parse(tbAngAlfa.Text);
                double? angBeta = string.IsNullOrEmpty(tbAngBeta.Text) ? (double?)null : double.Parse(tbAngBeta.Text);
                double? angGamma = string.IsNullOrEmpty(tbAngGamma.Text) ? (double?)null : double.Parse(tbAngGamma.Text);

                double? area = string.IsNullOrEmpty(tbArea.Text) ? (double?)null : double.Parse(tbArea.Text);
                double? perimetro = string.IsNullOrEmpty(tbPerimetro.Text) ? (double?)null : double.Parse(tbPerimetro.Text);

                // Si tenemos tres lados (SSS), calcular el resto
                if (ladoA.HasValue && ladoB.HasValue && ladoC.HasValue)
                {
                    CalcularTrianguloPorLados(ladoA.Value, ladoB.Value, ladoC.Value);
                }
                // Si tenemos dos lados y un ángulo (SAS), calcular el resto
                else if (ladoA.HasValue && ladoB.HasValue && angGamma.HasValue)
                {
                    CalcularTrianguloSAS(ladoA.Value, ladoB.Value, angGamma.Value);
                }
                // Si tenemos un lado y dos ángulos (ASA o AAS), calcular el resto
                else if (ladoA.HasValue && angAlfa.HasValue && angBeta.HasValue)
                {
                    CalcularTrianguloASA(ladoA.Value, angAlfa.Value, angBeta.Value);
                }
                // Si tenemos el área y dos lados, calcular el resto
                else if (area.HasValue && ladoA.HasValue && ladoB.HasValue)
                {
                    CalcularPorAreaYLados(area.Value, ladoA.Value, ladoB.Value);
                }
                // Si solo tenemos el perímetro y un lado, usar para calcular otros valores
                else if (perimetro.HasValue && ladoA.HasValue)
                {
                    CalcularPorPerimetroYUnLado(perimetro.Value, ladoA.Value);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa suficientes datos para calcular el triángulo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CalcularTrianguloPorLados(double ladoA, double ladoB, double ladoC)
        {
            // Usar el teorema del coseno para calcular los ángulos
            double angAlfa = Math.Acos((Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2) - Math.Pow(ladoA, 2)) / (2 * ladoB * ladoC)) * (180 / Math.PI);
            double angBeta = Math.Acos((Math.Pow(ladoA, 2) + Math.Pow(ladoC, 2) - Math.Pow(ladoB, 2)) / (2 * ladoA * ladoC)) * (180 / Math.PI);
            double angGamma = 180 - angAlfa - angBeta;

            // Calcular el perímetro
            double perimetro = ladoA + ladoB + ladoC;

            // Calcular el área con la fórmula de Herón
            double s = perimetro / 2;
            double area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            // Calcular las alturas
            double altA = 2 * area / ladoA;
            double altB = 2 * area / ladoB;
            double altC = 2 * area / ladoC;

            // Mostrar resultados en los textbox correspondientes
            tbAngAlfa.Text = angAlfa.ToString();
            tbAngBeta.Text = angBeta.ToString();
            tbAngGamma.Text = angGamma.ToString();
            tbPerimetro.Text = perimetro.ToString();
            tbArea.Text = area.ToString();
            tbAltA.Text = altA.ToString();
            tbAltB.Text = altB.ToString();
            tbAltC.Text = altC.ToString();
        }
        private void CalcularTrianguloSAS(double ladoA, double ladoB, double angGamma)
        {
            // Usar el teorema del coseno para calcular el lado C
            double ladoC = Math.Sqrt(Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2) - 2 * ladoA * ladoB * Math.Cos(angGamma * Math.PI / 180));

            // Usar el teorema del seno para calcular los otros ángulos
            double angAlfa = Math.Asin(ladoA * Math.Sin(angGamma * Math.PI / 180) / ladoC) * (180 / Math.PI);
            double angBeta = 180 - angAlfa - angGamma;

            // Calcular el perímetro y el área
            double perimetro = ladoA + ladoB + ladoC;
            double s = perimetro / 2;
            double area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            // Calcular las alturas
            double altA = 2 * area / ladoA;
            double altB = 2 * area / ladoB;
            double altC = 2 * area / ladoC;

            // Mostrar los resultados
            tbLadoC.Text = ladoC.ToString();
            tbAngAlfa.Text = angAlfa.ToString();
            tbAngBeta.Text = angBeta.ToString();
            tbPerimetro.Text = perimetro.ToString();
            tbArea.Text = area.ToString();
            tbAltA.Text = altA.ToString();
            tbAltB.Text = altB.ToString();
            tbAltC.Text = altC.ToString();
        }

        private void CalcularTrianguloASA(double ladoA, double angAlfa, double angBeta)
        {
            // Calcular el ángulo Gamma
            double angGamma = 180 - angAlfa - angBeta;

            // Usar el teorema del seno para calcular los otros lados
            double ladoB = ladoA * Math.Sin(angBeta * Math.PI / 180) / Math.Sin(angAlfa * Math.PI / 180);
            double ladoC = ladoA * Math.Sin(angGamma * Math.PI / 180) / Math.Sin(angAlfa * Math.PI / 180);

            // Calcular el perímetro y el área
            double perimetro = ladoA + ladoB + ladoC;
            double s = perimetro / 2;
            double area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            // Calcular las alturas
            double altA = 2 * area / ladoA;
            double altB = 2 * area / ladoB;
            double altC = 2 * area / ladoC;

            // Mostrar resultados
            tbLadoB.Text = ladoB.ToString();
            tbLadoC.Text = ladoC.ToString();
            tbAngGamma.Text = angGamma.ToString();
            tbPerimetro.Text = perimetro.ToString();
            tbArea.Text = area.ToString();
            tbAltA.Text = altA.ToString();
            tbAltB.Text = altB.ToString();
            tbAltC.Text = altC.ToString();
        }
        private void CalcularPorAreaYLados(double area, double ladoA, double ladoB)
        {
            // Calcular el ángulo entre los dos lados dados usando la fórmula del área
            double angGamma = Math.Asin((2 * area) / (ladoA * ladoB)) * (180 / Math.PI);

            // Usar el teorema del coseno para calcular el tercer lado
            double ladoC = Math.Sqrt(Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2) - 2 * ladoA * ladoB * Math.Cos(angGamma * Math.PI / 180));

            // Calcular los otros ángulos usando el teorema del seno
            double angAlfa = Math.Asin(ladoA * Math.Sin(angGamma * Math.PI / 180) / ladoC) * (180 / Math.PI);
            double angBeta = 180 - angGamma - angAlfa;

            // Calcular el perímetro
            double perimetro = ladoA + ladoB + ladoC;

            // Calcular las alturas
            double altA = 2 * area / ladoA;
            double altB = 2 * area / ladoB;
            double altC = 2 * area / ladoC;

            // Mostrar resultados
            tbAngAlfa.Text = angAlfa.ToString();
            tbAngBeta.Text = angBeta.ToString();
            tbAngGamma.Text = angGamma.ToString();
            tbLadoC.Text = ladoC.ToString();
            tbPerimetro.Text = perimetro.ToString();
            tbAltA.Text = altA.ToString();
            tbAltB.Text = altB.ToString();
            tbAltC.Text = altC.ToString();
        }
        private void CalcularPorPerimetroYUnLado(double perimetro, double ladoA)
        {
            // Suponemos que los otros dos lados son iguales (triángulo isósceles)
            double ladoB = (perimetro - ladoA) / 2;
            double ladoC = ladoB;

            // Calcular el área usando la fórmula de Herón
            double s = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            // Calcular los ángulos usando el teorema del coseno
            double angAlfa = Math.Acos((Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2) - Math.Pow(ladoA, 2)) / (2 * ladoB * ladoC)) * (180 / Math.PI);
            double angBeta = (180 - angAlfa) / 2; // Ángulos iguales en triángulo isósceles
            double angGamma = angBeta;

            // Calcular las alturas
            double altA = 2 * area / ladoA;
            double altB = 2 * area / ladoB;
            double altC = 2 * area / ladoC;

            // Mostrar resultados
            tbLadoB.Text = ladoB.ToString();
            tbLadoC.Text = ladoC.ToString();
            tbAngAlfa.Text = angAlfa.ToString();
            tbAngBeta.Text = angBeta.ToString();
            tbAngGamma.Text = angGamma.ToString();
            tbArea.Text = area.ToString();
            tbAltA.Text = altA.ToString();
            tbAltB.Text = altB.ToString();
            tbAltC.Text = altC.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
