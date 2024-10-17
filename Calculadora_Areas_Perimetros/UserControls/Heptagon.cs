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
    public partial class Heptagon : UserControl
    {
        public Heptagon()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLados.Text = "";
            tbLado.Text = "";
            tbCirCir.Text = "";
            tbCirIns.Text = "";
            tbArea.Text = "";
            tbPerimetro.Text = "";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables para los valores
                int? numLados = string.IsNullOrEmpty(tbLados.Text) ? (int?)null : int.Parse(tbLados.Text);
                double? lado = string.IsNullOrEmpty(tbLado.Text) ? (double?)null : double.Parse(tbLado.Text);
                double? radioCircunscrita = string.IsNullOrEmpty(tbCirCir.Text) ? (double?)null : double.Parse(tbCirCir.Text);
                double? radioInscrita = string.IsNullOrEmpty(tbCirIns.Text) ? (double?)null : double.Parse(tbCirIns.Text);
                double? area = string.IsNullOrEmpty(tbArea.Text) ? (double?)null : double.Parse(tbArea.Text);
                double? perimetro = string.IsNullOrEmpty(tbPerimetro.Text) ? (double?)null : double.Parse(tbPerimetro.Text);

                // Verificar que al menos se haya proporcionado un valor y el número de lados
                if (!numLados.HasValue || numLados < 3)
                {
                    MessageBox.Show("El número de lados debe ser mayor o igual a 3.");
                    return;
                }

                int count = new double?[] { lado, radioCircunscrita, radioInscrita, area, perimetro }.Count(x => x.HasValue);
                if (count < 1)
                {
                    MessageBox.Show("Por favor, ingresa al menos 1 valor para calcular el polígono regular.");
                    return;
                }

                // Iniciar el cálculo con la combinación de valores proporcionados
                CalcularPoligonoRegular(numLados.Value, lado, radioCircunscrita, radioInscrita, area, perimetro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CalcularPoligonoRegular(int numLados, double? lado, double? radioCircunscrita, double? radioInscrita,
                                             double? area, double? perimetro)
        {
            // Constante para el ángulo central del polígono
            double anguloCentral = 360.0 / numLados;
            double anguloCentralRad = (Math.PI * anguloCentral) / 180.0; // Convertir a radianes

            // 1. Si se tiene el lado, calcular los otros valores
            if (lado.HasValue)
            {
                // Perímetro = número de lados * longitud de un lado
                perimetro = numLados * lado.Value;
                tbPerimetro.Text = perimetro.ToString();

                // Radio circunscrito (radio de la circunferencia circunscrita)
                radioCircunscrita = lado.Value / (2 * Math.Sin(Math.PI / numLados));
                tbCirCir.Text = radioCircunscrita.ToString();

                // Radio inscrito (radio de la circunferencia inscrita)
                radioInscrita = lado.Value / (2 * Math.Tan(Math.PI / numLados));
                tbCirIns.Text = radioInscrita.ToString();

                // Área del polígono
                area = (perimetro.Value * radioInscrita.Value) / 2;
                tbArea.Text = area.ToString();
            }else

            // 2. Si se tiene el radio circunscrito, calcular los otros valores
            if (radioCircunscrita.HasValue)
            {
                // Lado del polígono
                lado = 2 * radioCircunscrita.Value * Math.Sin(Math.PI / numLados);
                tbLado.Text = lado.ToString();

                // Perímetro
                perimetro = numLados * lado.Value;
                tbPerimetro.Text = perimetro.ToString();

                // Radio inscrito
                radioInscrita = radioCircunscrita.Value * Math.Cos(Math.PI / numLados);
                tbCirIns.Text = radioInscrita.ToString();

                // Área
                area = (perimetro.Value * radioInscrita.Value) / 2;
                tbArea.Text = area.ToString();
            }else

            // 3. Si se tiene el radio inscrito, calcular los otros valores
            if (radioInscrita.HasValue)
            {
                // Lado del polígono
                lado = 2 * radioInscrita.Value * Math.Tan(Math.PI / numLados);
                tbLado.Text = lado.ToString();

                // Perímetro
                perimetro = numLados * lado.Value;
                tbPerimetro.Text = perimetro.ToString();

                // Radio circunscrito
                radioCircunscrita = radioInscrita.Value / Math.Cos(Math.PI / numLados);
                tbCirCir.Text = radioCircunscrita.ToString();

                // Área
                area = (perimetro.Value * radioInscrita.Value) / 2;
                tbArea.Text = area.ToString();
            }else

            // 4. Si se tiene el perímetro, calcular los otros valores
            if (perimetro.HasValue)
            {
                // Lado del polígono
                lado = perimetro.Value / numLados;
                tbLado.Text = lado.ToString();

                // Radio circunscrito
                radioCircunscrita = lado.Value / (2 * Math.Sin(Math.PI / numLados));
                tbCirCir.Text = radioCircunscrita.ToString();

                // Radio inscrito
                radioInscrita = lado.Value / (2 * Math.Tan(Math.PI / numLados));
                tbCirIns.Text = radioInscrita.ToString();

                // Área
                area = (perimetro.Value * radioInscrita.Value) / 2;
                tbArea.Text = area.ToString();
            }else

            // 5. Si se tiene el área, calcular los otros valores
            if (area.HasValue)
            {
                // Radio inscrito
                radioInscrita = Math.Sqrt(area.Value / (numLados * Math.Tan(Math.PI / numLados)));
                tbCirIns.Text = radioInscrita.ToString();

                // Lado del polígono
                lado = 2 * radioInscrita.Value * Math.Tan(Math.PI / numLados);
                tbLado.Text = lado.ToString();

                // Perímetro
                perimetro = numLados * lado.Value;
                tbPerimetro.Text = perimetro.ToString();

                // Radio circunscrito
                radioCircunscrita = lado.Value / (2 * Math.Sin(Math.PI / numLados));
                tbCirCir.Text = radioCircunscrita.ToString();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
