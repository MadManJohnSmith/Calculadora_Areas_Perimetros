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
    public partial class Circle : UserControl
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbRadio.Text = "";
            tbDiametro.Text = "";
            tbArea.Text = "";
            tbPerimetro.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables para los valores
                double? radio = string.IsNullOrEmpty(tbRadio.Text) ? (double?)null : double.Parse(tbRadio.Text);
                double? diametro = string.IsNullOrEmpty(tbDiametro.Text) ? (double?)null : double.Parse(tbDiametro.Text);
                double? area = string.IsNullOrEmpty(tbArea.Text) ? (double?)null : double.Parse(tbArea.Text);
                double? perimetro = string.IsNullOrEmpty(tbPerimetro.Text) ? (double?)null : double.Parse(tbPerimetro.Text);

                // Verificar que al menos se haya proporcionado un valor
                int count = new double?[] { radio, diametro, area, perimetro }.Count(x => x.HasValue);
                if (count < 1)
                {
                    MessageBox.Show("Por favor, ingresa al menos 1 valor para calcular el círculo.");
                    return;
                }

                // Iniciar el cálculo con la combinación de valores proporcionados
                CalcularCirculo(radio, diametro, area, perimetro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CalcularCirculo(double? radio, double? diametro, double? area, double? perimetro)
        {
            const double PI = Math.PI;

            // 1. Si se tiene el radio, calcular los otros valores
            if (radio.HasValue)
            {
                // Diametro = 2 * radio
                diametro = 2 * radio.Value;
                tbDiametro.Text = diametro.ToString();

                // Perímetro = 2 * PI * radio
                perimetro = 2 * PI * radio.Value;
                tbPerimetro.Text = perimetro.ToString();

                // Área = PI * radio^2
                area = PI * Math.Pow(radio.Value, 2);
                tbArea.Text = area.ToString();
            }

            // 2. Si se tiene el diámetro, calcular los otros valores
            if (diametro.HasValue)
            {
                // Radio = diametro / 2
                radio = diametro.Value / 2;
                tbRadio.Text = radio.ToString();

                // Perímetro = PI * diametro
                perimetro = PI * diametro.Value;
                tbPerimetro.Text = perimetro.ToString();

                // Área = PI * radio^2
                area = PI * Math.Pow(radio.Value, 2);
                tbArea.Text = area.ToString();
            }

            // 3. Si se tiene el área, calcular los otros valores
            if (area.HasValue)
            {
                // Radio = sqrt(area / PI)
                radio = Math.Sqrt(area.Value / PI);
                tbRadio.Text = radio.ToString();

                // Diametro = 2 * radio
                diametro = 2 * radio.Value;
                tbDiametro.Text = diametro.ToString();

                // Perímetro = 2 * PI * radio
                perimetro = 2 * PI * radio.Value;
                tbPerimetro.Text = perimetro.ToString();
            }

            // 4. Si se tiene el perímetro, calcular los otros valores
            if (perimetro.HasValue)
            {
                // Radio = perimetro / (2 * PI)
                radio = perimetro.Value / (2 * PI);
                tbRadio.Text = radio.ToString();

                // Diametro = 2 * radio
                diametro = 2 * radio.Value;
                tbDiametro.Text = diametro.ToString();

                // Área = PI * radio^2
                area = PI * Math.Pow(radio.Value, 2);
                tbArea.Text = area.ToString();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
