namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Valores");

            List<int> numeros = ObtenerNumerosValidos();
            if (numeros == null) return;

            listBoxNumeros.Items.Clear();
            foreach (int num in numeros)
            {
                listBoxNumeros.Items.Add(num);
                chart1.Series["Valores"].Points.AddXY(num, num);
            }
        }



        private void btnNumerosImpares_Click(object sender, EventArgs e)
        {
            List<int> numeros = ObtenerNumerosValidos();
            if (numeros == null) return;

            listBoxNumeros.Items.Clear();
            List<int> impares = new List<int>();
            foreach (int num in numeros)
            {
                if (!EsPar(num))
                {
                    listBoxNumeros.Items.Add(num);
                    GenerarGrafico(numeros, "Impares");
                    impares.Add(num);
                }
            }
            GenerarGrafico(impares, "Impares");
        }

        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            List<int> numeros = ObtenerNumerosValidos();
            if (numeros == null) return;

            listBoxNumeros.Items.Clear();
            List<int> primos = new List<int>();
            foreach (int num in numeros)
            {
                if (EsPrimo(num))
                {
                    listBoxNumeros.Items.Add(num);
                    primos.Add(num);
                }
            }
            GenerarGrafico(primos, "primos");

        }
        private bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            if (num <= 3) return true;
            if (num % 2 == 0 || num % 3 == 0) return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0) return false;
            }

            return true;
        }

        private void btnNumerosPares_Click_1(object sender, EventArgs e)
        {
            List<int> numeros = ObtenerNumerosValidos();
            if (numeros == null) return;

            listBoxNumeros.Items.Clear();

            List<int> pares = new List<int>();

            foreach (int num in numeros)
            {
                if (EsPar(num))
                {
                    listBoxNumeros.Items.Add(num);
                    pares.Add(num);
                }
            }

            GenerarGrafico(pares, "Pares");
        }
        private bool EsPar(int num)
        {
            return num % 2 == 0;
        }

        private List<int> ObtenerNumerosValidos()
        {
            if (!int.TryParse(txtDesde.Text, out int desde) || !int.TryParse(txtHasta.Text, out int hasta))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos Desde y Hasta.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesde.BackColor = Color.Red;
                txtHasta.BackColor = Color.Red;
                return null;
            }

            int maxDistancia = 20;
            if (desde > hasta || hasta - desde > maxDistancia)
            {
                MessageBox.Show($"La distancia máxima entre números es {maxDistancia}.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesde.BackColor = Color.Red;
                txtHasta.BackColor = Color.Red;
                return null;
            }

            txtDesde.BackColor = SystemColors.Window;
            txtHasta.BackColor = SystemColors.Window;

            List<int> numeros = new List<int>();
            for (int i = desde; i <= hasta; i++)
            {
                numeros.Add(i);
            }
            return numeros;
        }








        private void GenerarGrafico(List<int> numeros, string serieName)
        {
            chart1.Series.Clear();
            chart1.Series.Add(serieName);

            foreach (int num in numeros)
            {
                chart1.Series[serieName].Points.AddXY(num, num);
            }
        }


    }
}

