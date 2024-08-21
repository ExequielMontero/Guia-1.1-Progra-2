using Ejercicio_3.Models;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        Peaje mipeaje = new Peaje();
        CargarPeaje cargar = new CargarPeaje();
        private int[] valordias = new int[30];
        public int Valordias { get { return valordias.Length; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int dia = Convert.ToInt32(cargar.nuDias.Value);
            guardardias(dia);
         
        }

        public void guardardias(int misdias)
        {
            int cont = 0;
            valordias[cont] = misdias;
            cont++;
        }

    }
}
