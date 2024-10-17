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
    public partial class Trapezoid : UserControl
    {
        public Trapezoid()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLadoA.Text = "";
            tbLadoB.Text = "";
            tbLadoC.Text = "";
            tbLadoD.Text = "";
            tbAngAlfa.Text = "";
            tbAngBeta.Text = "";
            tbAngGamma.Text = "";
            tbAngDelta.Text = "";
            tbAlt.Text = "";
            tbArea.Text = "";
            tbPerimetro.Text = "";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables para los valores de los lados, ángulos, altura, área y perímetro
                double? ladoA = string.IsNullOrEmpty(tbLadoA.Text) ? (double?)null : double.Parse(tbLadoA.Text);
                double? ladoB = string.IsNullOrEmpty(tbLadoB.Text) ? (double?)null : double.Parse(tbLadoB.Text);
                double? ladoC = string.IsNullOrEmpty(tbLadoC.Text) ? (double?)null : double.Parse(tbLadoC.Text);
                double? ladoD = string.IsNullOrEmpty(tbLadoD.Text) ? (double?)null : double.Parse(tbLadoD.Text);

                double? angAlfa = string.IsNullOrEmpty(tbAngAlfa.Text) ? (double?)null : double.Parse(tbAngAlfa.Text);
                double? angBeta = string.IsNullOrEmpty(tbAngBeta.Text) ? (double?)null : double.Parse(tbAngBeta.Text);
                double? angGamma = string.IsNullOrEmpty(tbAngGamma.Text) ? (double?)null : double.Parse(tbAngGamma.Text);
                double? angDelta = string.IsNullOrEmpty(tbAngDelta.Text) ? (double?)null : double.Parse(tbAngDelta.Text);

                double? altura = string.IsNullOrEmpty(tbAlt.Text) ? (double?)null : double.Parse(tbAlt.Text);
                double? area = string.IsNullOrEmpty(tbArea.Text) ? (double?)null : double.Parse(tbArea.Text);
                double? perimetro = string.IsNullOrEmpty(tbPerimetro.Text) ? (double?)null : double.Parse(tbPerimetro.Text);

                // Verificar que al menos se hayan proporcionado 4 valores
                int count = new double?[] { ladoA, ladoB, ladoC, ladoD, angAlfa, angBeta, angGamma, angDelta, altura, area, perimetro }.Count(x => x.HasValue);
                if (count < 4)
                {
                    MessageBox.Show("Por favor ingresa al menos 4 valores para calcular el trapecio.");
                    return;
                }

                // Comenzar el cálculo basado en la combinación de 4 valores proporcionados
                CalcularTrapecio(ladoA, ladoB, ladoC, ladoD, angAlfa, angBeta, angGamma, angDelta, altura, area, perimetro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CalcularTrapecio(double? ladoA, double? ladoB, double? ladoC, double? ladoD,
                                      double? angAlfa, double? angBeta, double? angGamma, double? angDelta,
                                      double? altura, double? area, double? perimetro)
        {
            // 1. Si se tienen los lados y la altura, calcular el área, perímetro y los ángulos
            if (ladoA.HasValue && ladoB.HasValue && ladoC.HasValue && ladoD.HasValue)
            {
                if (!altura.HasValue && !area.HasValue && !perimetro.HasValue)
                {
                    // Calcular el perímetro
                    perimetro = ladoA + ladoB + ladoC + ladoD;
                    tbPerimetro.Text = perimetro.ToString();

                    // Aproximar la altura (si es un trapecio isósceles)
                    altura = Math.Sqrt(Math.Pow(ladoC.Value, 2) - Math.Pow((ladoB.Value - ladoA.Value) / 2, 2));
                    tbAlt.Text = altura.ToString();

                    // Calcular el área
                    area = ((ladoA.Value + ladoB.Value) / 2) * altura;
                    tbArea.Text = area.ToString();

                    // Calcular ángulos usando trigonometría
                    double baseDiferencia = Math.Abs(ladoB.Value - ladoA.Value) / 2;
                    angAlfa = Math.Atan2(altura.Value, baseDiferencia) * (180 / Math.PI);
                    angBeta = 180 - angAlfa; // Ángulos adyacentes en un trapecio isósceles
                    angGamma = angAlfa; // Ángulo en la otra base
                    angDelta = angBeta; // Ángulo opuesto a Beta

                    tbAngAlfa.Text = angAlfa.ToString();
                    tbAngBeta.Text = angBeta.ToString();
                    tbAngGamma.Text = angGamma.ToString();
                    tbAngDelta.Text = angDelta.ToString();
                }
            }else

            // 2. Si se tienen 2 lados, altura y el área, calcular los demás lados y ángulos
            if (ladoA.HasValue && ladoB.HasValue && altura.HasValue && area.HasValue)
            {
                tbAlt.Text = altura.ToString();
                tbArea.Text = area.ToString();

                // Calcular los otros dos lados
                ladoC = Math.Sqrt(Math.Pow(area.Value / ((ladoA.Value + ladoB.Value) / 2), 2) - Math.Pow(altura.Value, 2));
                ladoD = ladoC;
                tbLadoC.Text = ladoC.ToString();
                tbLadoD.Text = ladoD.ToString();

                // Calcular ángulos usando trigonometría inversa
                double baseDiferencia = Math.Abs(ladoB.Value - ladoA.Value) / 2;
                angAlfa = Math.Atan2(altura.Value, baseDiferencia) * (180 / Math.PI);
                angBeta = 180 - angAlfa;
                angGamma = angAlfa;
                angDelta = angBeta;

                tbAngAlfa.Text = angAlfa.ToString();
                tbAngBeta.Text = angBeta.ToString();
                tbAngGamma.Text = angGamma.ToString();
                tbAngDelta.Text = angDelta.ToString();
            }else

            // 3. Si se tienen 3 lados y el perímetro, calcular el lado restante y ángulos
            if (ladoA.HasValue && ladoB.HasValue && ladoC.HasValue && perimetro.HasValue)
            {
                ladoD = perimetro.Value - (ladoA.Value + ladoB.Value + ladoC.Value);
                tbLadoD.Text = ladoD.ToString();

                // Calcular ángulos (suponiendo trapecio isósceles)
                double baseDiferencia = Math.Abs(ladoB.Value - ladoA.Value) / 2;
                angAlfa = Math.Atan2(altura.Value, baseDiferencia) * (180 / Math.PI);
                angBeta = 180 - angAlfa;
                angGamma = angAlfa;
                angDelta = angBeta;

                tbAngAlfa.Text = angAlfa.ToString();
                tbAngBeta.Text = angBeta.ToString();
                tbAngGamma.Text = angGamma.ToString();
                tbAngDelta.Text = angDelta.ToString();
            }else

            // 4. Si se tienen los ángulos y los lados A, B, calcular el área y la altura
            if (angAlfa.HasValue && angBeta.HasValue && ladoA.HasValue && ladoB.HasValue)
            {
                // Se puede usar trigonometría para calcular la altura y el área
                altura = ladoA.Value * Math.Sin(angAlfa.Value * (Math.PI / 180));
                tbAlt.Text = altura.ToString();

                // Calcular el área
                area = ((ladoA.Value + ladoB.Value) / 2) * altura;
                tbArea.Text = area.ToString();

                // Calcular el perímetro
                perimetro = ladoA + ladoB + Math.Sqrt(Math.Pow(ladoB.Value - ladoA.Value, 2) + Math.Pow(altura.Value, 2));
                tbPerimetro.Text = perimetro.ToString();
            }else

            // 5. Si se tiene el área y 3 lados, calcular el lado restante y los ángulos
            if (area.HasValue && ladoA.HasValue && ladoB.HasValue && ladoC.HasValue)
            {
                altura = (2 * area.Value) / (ladoA.Value + ladoB.Value);
                tbAlt.Text = altura.ToString();

                ladoD = perimetro - (ladoA + ladoB + ladoC);
                tbLadoD.Text = ladoD.ToString();

                // Calcular ángulos
                double baseDiferencia = Math.Abs(ladoB.Value - ladoA.Value) / 2;
                angAlfa = Math.Atan2(altura.Value, baseDiferencia) * (180 / Math.PI);
                angBeta = 180 - angAlfa;
                angGamma = angAlfa;
                angDelta = angBeta;

                tbAngAlfa.Text = angAlfa.ToString();
                tbAngBeta.Text = angBeta.ToString();
                tbAngGamma.Text = angGamma.ToString();
                tbAngDelta.Text = angDelta.ToString();
            }else

            // 6. Si se tiene el área, altura y un lado, calcular el otro lado
            if (area.HasValue && altura.HasValue && ladoA.HasValue)
            {
                ladoB = (2 * area.Value / altura.Value) - ladoA.Value;
                tbLadoB.Text = ladoB.ToString();

                // Calcular ángulos
                double baseDiferencia = Math.Abs(ladoB.Value - ladoA.Value) / 2;
                angAlfa = Math.Atan2(altura.Value, baseDiferencia) * (180 / Math.PI);
                angBeta = 180 - angAlfa;
                angGamma = angAlfa;
                angDelta = angBeta;

                tbAngAlfa.Text = angAlfa.ToString();
                tbAngBeta.Text = angBeta.ToString();
                tbAngGamma.Text = angGamma.ToString();
                tbAngDelta.Text = angDelta.ToString();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
