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
    public partial class Squaer__ : UserControl
    {
        public Squaer__()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLado.Text = "";
            tbDiagonal.Text = "";
            tbCirIns.Text = "";
            tbCirCir.Text = "";
            tbArea.Text = "";
            tbPerimetro.Text = "";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables para los valores del lado, diagonal, circunferencia inscrita, circunscrita, área y perímetro
                double? lado = string.IsNullOrEmpty(tbLado.Text) ? (double?)null : double.Parse(tbLado.Text);
                double? diagonal = string.IsNullOrEmpty(tbDiagonal.Text) ? (double?)null : double.Parse(tbDiagonal.Text);
                double? cirIns = string.IsNullOrEmpty(tbCirIns.Text) ? (double?)null : double.Parse(tbCirIns.Text);
                double? cirCir = string.IsNullOrEmpty(tbCirCir.Text) ? (double?)null : double.Parse(tbCirCir.Text);
                double? area = string.IsNullOrEmpty(tbArea.Text) ? (double?)null : double.Parse(tbArea.Text);
                double? perimetro = string.IsNullOrEmpty(tbPerimetro.Text) ? (double?)null : double.Parse(tbPerimetro.Text);

                // Si se ha proporcionado el lado, calcular el resto
                if (lado.HasValue)
                {
                    CalcularPorLado(lado.Value);
                }
                // Si se ha proporcionado la diagonal, calcular el resto
                else if (diagonal.HasValue)
                {
                    CalcularPorDiagonal(diagonal.Value);
                }
                // Si se ha proporcionado la circunferencia inscrita, calcular el resto
                else if (cirIns.HasValue)
                {
                    CalcularPorCirIns(cirIns.Value);
                }
                // Si se ha proporcionado la circunferencia circunscrita, calcular el resto
                else if (cirCir.HasValue)
                {
                    CalcularPorCirCir(cirCir.Value);
                }
                // Si se ha proporcionado el área, calcular el resto
                else if (area.HasValue)
                {
                    CalcularPorArea(area.Value);
                }
                // Si se ha proporcionado el perímetro, calcular el resto
                else if (perimetro.HasValue)
                {
                    CalcularPorPerimetro(perimetro.Value);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa al menos un valor para calcular el cuadrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CalcularPorLado(double lado)
        {
            // Calcular el resto de los valores
            double diagonal = lado * Math.Sqrt(2);
            double cirIns = lado / 2;
            double cirCir = diagonal / 2;
            double area = lado * lado;
            double perimetro = lado * 4;

            // Mostrar resultados
            tbDiagonal.Text = diagonal.ToString();
            tbCirIns.Text = cirIns.ToString();
            tbCirCir.Text = cirCir.ToString();
            tbArea.Text = area.ToString();
            tbPerimetro.Text = perimetro.ToString();
        }

        private void CalcularPorDiagonal(double diagonal)
        {
            double lado = diagonal / Math.Sqrt(2);
            double cirIns = lado / 2;
            double cirCir = diagonal / 2;
            double area = lado * lado;
            double perimetro = lado * 4;

            tbLado.Text = lado.ToString();
            tbCirIns.Text = cirIns.ToString();
            tbCirCir.Text = cirCir.ToString();
            tbArea.Text = area.ToString();
            tbPerimetro.Text = perimetro.ToString();
        }

        private void CalcularPorCirIns(double cirIns)
        {
            double lado = cirIns * 2;
            double diagonal = lado * Math.Sqrt(2);
            double cirCir = diagonal / 2;
            double area = lado * lado;
            double perimetro = lado * 4;

            tbLado.Text = lado.ToString();
            tbDiagonal.Text = diagonal.ToString();
            tbCirCir.Text = cirCir.ToString();
            tbArea.Text = area.ToString();
            tbPerimetro.Text = perimetro.ToString();
        }

        private void CalcularPorCirCir(double cirCir)
        {
            double diagonal = cirCir * 2;
            double lado = diagonal / Math.Sqrt(2);
            double cirIns = lado / 2;
            double area = lado * lado;
            double perimetro = lado * 4;

            tbLado.Text = lado.ToString();
            tbDiagonal.Text = diagonal.ToString();
            tbCirIns.Text = cirIns.ToString();
            tbArea.Text = area.ToString();
            tbPerimetro.Text = perimetro.ToString();
        }

        private void CalcularPorArea(double area)
        {
            double lado = Math.Sqrt(area);
            double diagonal = lado * Math.Sqrt(2);
            double cirIns = lado / 2;
            double cirCir = diagonal / 2;
            double perimetro = lado * 4;

            tbLado.Text = lado.ToString();
            tbDiagonal.Text = diagonal.ToString();
            tbCirIns.Text = cirIns.ToString();
            tbCirCir.Text = cirCir.ToString();
            tbPerimetro.Text = perimetro.ToString();
        }

        private void CalcularPorPerimetro(double perimetro)
        {
            double lado = perimetro / 4;
            double diagonal = lado * Math.Sqrt(2);
            double cirIns = lado / 2;
            double cirCir = diagonal / 2;
            double area = lado * lado;

            tbLado.Text = lado.ToString();
            tbDiagonal.Text = diagonal.ToString();
            tbCirIns.Text = cirIns.ToString();
            tbCirCir.Text = cirCir.ToString();
            tbArea.Text = area.ToString();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
