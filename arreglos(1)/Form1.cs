namespace arreglos_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnCargarMatriz.Click += btnCargarMatriz_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCargarMatriz_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[3, 3]; // Aqui creamos la matriz que en este caso es 3x3
            int suma = 0;                  // Creamos una variable para la suma que iniciara en cero

            // Pedir valores al usuario
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Ingrese el valor para la posición [{i},{j}]:",
                        "Cargar Matriz", "0");

                    // Convertir a entero
                    if (int.TryParse(input, out int valor))
                    {
                        matriz[i, j] = valor;
                        suma += valor; // Sumar el valor
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un número válido.");
                        j--; // repetir el mismo índice
                    }
                }
            }

            // Mostrar la matriz en un string
            string mostrarMatriz = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mostrarMatriz += matriz[i, j] + " ";
                }
                mostrarMatriz += "\n";
            }

            // Mostrar matriz y suma en un Label
            lblResultado.Text = $"Matriz:\n{mostrarMatriz}\nSuma total: {suma}";
        }
    }
}