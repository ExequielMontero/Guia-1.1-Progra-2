using ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        
        Calculadora micalculadora = new Calculadora("fz", "negro");
        Resultados misresultados = new Resultados();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelomoto = Convert.ToInt32(nuModelo.Value);
            int añoacalcular = Convert.ToInt32(nuAño.Value);
            double valorfabricacion = Convert.ToDouble(tbFabricacion.Text);
            double tasadepreciacion = Convert.ToDouble(tbDepreciacion.Text);
            int vidautil = Convert.ToInt32(tbVida.Text);
            Moto mimoto = new Moto(marca, modelomoto, valorfabricacion);
            int tasadepre = añoacalcular - modelomoto;
            double depreli = micalculadora.DepreciacionLineal(valorfabricacion, modelomoto, añoacalcular, vidautil);
            double depreanu = micalculadora.DepreciacionAnual(valorfabricacion, tasadepre);

            misresultados.lbResultados.Items.Add($"Marca: {mimoto.Marca}, Modelo: {mimoto.Modelo}, Valor Fabricacion: {mimoto.Valorfrabrica}$");
            misresultados.lbResultados.Items.Add($"Depreciacion Inicial: {depreli}$");
            misresultados.lbResultados.Items.Add($"Depreciacion Anual: {depreanu}$");

            misresultados.ShowDialog();

            tbMarca.Clear();
            tbFabricacion.Clear();
            tbDepreciacion.Clear();
            tbVida.Clear();
            misresultados.lbResultados.Items.Clear();
            
        }
    }
}
