using Ejercicio_3__Solo_una_clase_.models;

namespace Ejercicio_3__Solo_una_clase_
{
    public partial class Form1 : Form
    {
        Resultados misresultados = new Resultados();
        Peaje mipeaje = new Peaje();
        public int actualdia;
        public int[] actualdias;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (misresultados.ShowDialog() == DialogResult.OK)
            {
                int dia = Convert.ToInt32(misresultados.nuDias.Value) - 1;
                actualdia = dia;
                actualdias = mipeaje.Dias;
                int cantvehiculos = Convert.ToInt32(misresultados.tbAutos.Text);
                int[] dias = new int[30];
                dias = mipeaje.Dias;
                dias[dia] = cantvehiculos;
                mipeaje.Cantidadtotalvehiculomes = mipeaje.Cantidadtotalvehiculomes + cantvehiculos;
                mipeaje.corroborardias();
                mipeaje.calcularpromedio();
                mipeaje.diasmayoresalpromedio();
            }
            misresultados.tbAutos.Clear();

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            lbResultados.Items.Add($"Dia: {actualdia+1}, Cantidad de vehiculos: {actualdias(actualdia)}");
        }
    }
}
