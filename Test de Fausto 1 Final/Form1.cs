using System;
using System.Threading;
using System.Windows.Forms;

namespace Test_de_Fausto_1
{
    public partial class Form1 : Form
    {
        private readonly Columna[] columnas = new Columna[4]; // Arreglo de columnas
        private long limiteSuperior = 0; // L�mite superior para encontrar n�meros primos
        private Thread[] threads = new Thread[4]; // Arreglo de hilos para procesamiento en segundo plano

        public Form1()
        {
            InitializeComponent();
            InitializeColumnas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeColumnas()
        {
            // Pasar las referencias de los ListViews al crear las instancias de Columna
            columnas[0] = new Columna(1, listView1);
            columnas[1] = new Columna(2, listView2);
            columnas[2] = new Columna(3, listView3);
            columnas[3] = new Columna(4, listView4);
        }

        // Clase que representa una columna para encontrar n�meros primos
        private class Columna
        {
            private readonly int indice;
            private readonly long limiteInferior;
            private readonly ListView listView; // Almacenar la referencia al ListView
            public long limiteSuperior;
            private volatile bool running = true; // Variable volatile para controlar el estado del hilo
            private volatile bool paused = false; // Variable volatile para indicar si el hilo est� pausado
            private volatile bool stopped = false; // Variable volatile para indicar si el hilo est� detenido

            public Columna(int indice, ListView listView)
            {
                this.indice = indice;
                this.limiteInferior = 1; // L�mite inferior de cada columna
                this.listView = listView; // Guardar la referencia al ListView
            }

            // M�todo para encontrar n�meros primos en la columna
            public void EncontrarPrimos()
            {
                long inicio = limiteInferior + (indice - 1) * ((limiteSuperior - limiteInferior + 1) / 4);
                long fin = inicio + ((limiteSuperior - limiteInferior + 1) / 4) - 1;

                for (long numero = inicio; numero <= fin && running; numero++)
                {
                    // Si el hilo est� pausado, esperar hasta que se reanude
                    while (paused)
                    {
                        Thread.Sleep(100); // Esperar 100 milisegundos antes de verificar de nuevo
                    }

                    if (EsPrimo(numero))
                    {
                        AgregarPrimo(numero);
                    }
                }

                stopped = true; // Indicar que el hilo ha sido detenido
            }

            // M�todo para verificar si un n�mero es primo
            private bool EsPrimo(long numero)
            {
                if (numero < 2) return false;
                for (long i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0) return false;
                }
                return true;
            }

            // M�todo para agregar un n�mero primo a la columna
            private void AgregarPrimo(long primo)
            {
                // Agrega el n�mero primo al ListView en la interfaz gr�fica
                listView.Invoke(new Action(() =>
                {
                    // Agrega un nuevo ListViewItem al ListView con la informaci�n del n�mero primo
                    ListViewItem item = new ListViewItem(new string[] { primo.ToString(), "Activo", "" });

                    // Calcula el progreso en porcentaje
                    double progreso = ((double)(primo - limiteInferior + 1) / (limiteSuperior - limiteInferior + 1)) * 100;

                    // Actualiza el progreso en el tercer campo del ListViewItem
                    item.SubItems[2].Text = progreso.ToString() + "%";

                    // Agrega el nuevo item al ListView
                    listView.Items.Add(item);
                }));

                // Introduce un peque�o retraso para simular la generaci�n progresiva de n�meros primos
                Thread.Sleep(50);
            }

            // M�todo para detener la b�squeda de primos en la columna
            public void Detener()
            {
                running = false;
            }

            // M�todo para pausar la b�squeda de primos en la columna
            public void Pausar()
            {
                paused = true;
            }

            // M�todo para reanudar la b�squeda de primos en la columna
            public void Reanudar()
            {
                paused = false;
            }

            // M�todo para verificar si el hilo est� detenido
            public bool EstaDetenido()
            {
                return stopped;
            }
        }

        // Evento del bot�n "Limite"
        private void limite_btn_Click(object sender, EventArgs e)
        {
            PedirLimiteSuperior();
        }

        // M�todo para solicitar al usuario el l�mite superior
        private void PedirLimiteSuperior()
        {
            long limite;
            // Obtener el valor del textBox1 en lugar de usar Console.ReadLine()
            do
            {
                // Utilizar el MessageBox para solicitar el l�mite superior
                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el l�mite superior para encontrar n�meros primos:", "Ingresar l�mite superior", "", -1, -1);
                if (!long.TryParse(input, out limite) || limite <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un n�mero entero v�lido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (limite <= 0);

            limiteSuperior = limite;

            // Detener los hilos antes de limpiar los ListView y reiniciar el proceso
            foreach (Thread thread in threads)
            {
                if (thread != null && thread.IsAlive)
                {
                    DetenerHilo(thread);
                }
            }

            // Limpiar los ListView antes de iniciar la b�squeda de primos
            foreach (ListView listView in new ListView[] { listView1, listView2, listView3, listView4 })
            {
                listView.Items.Clear();
            }

            // Establecer el l�mite superior en cada columna
            for (int i = 0; i < 4; i++)
            {
                columnas[i].limiteSuperior = limiteSuperior;
            }

            // Iniciar un hilo para cada columna
            for (int i = 0; i < 4; i++)
            {
                threads[i] = new Thread(columnas[i].EncontrarPrimos);
                threads[i].Start();
            }
        }

        // M�todo para detener un hilo y esperar a que termine
        private void DetenerHilo(Thread thread)
        {
            if (thread != null && thread.IsAlive)
            {
                columnas[Array.IndexOf(threads, thread)].Detener();
                while (!columnas[Array.IndexOf(threads, thread)].EstaDetenido())
                {
                    Thread.Sleep(100); // Esperar a que el hilo se detenga
                }
            }
        }

        // Evento del bot�n "Limpiar"
        private void limpiar_btn1_Click(object sender, EventArgs e)
        {
            // Limpiar los ListView antes de iniciar la b�squeda de primos
            foreach (ListView listView in new ListView[] { listView1, listView2, listView3, listView4 })
            {
                listView.Items.Clear();
            }
        }

        // Evento del bot�n de pausa y reanudaci�n de cada columna
        private void pausa_c1_reload_Click(object sender, EventArgs e)
        {
            PausarColumna(0);
        }

        private void pausa_c2_Click(object sender, EventArgs e)
        {
            PausarColumna(1);
        }

        private void pausa_c3_Click(object sender, EventArgs e)
        {
            PausarColumna(2);
        }

        private void pausa_c4_Click(object sender, EventArgs e)
        {
            PausarColumna(3);
        }

        private void reanudar_c1_Click(object sender, EventArgs e)
        {
            ReanudarColumna(0);
        }

        private void reanudar_c2_Click(object sender, EventArgs e)
        {
            ReanudarColumna(1);
        }

        private void reanudar_c3_Click(object sender, EventArgs e)
        {
            ReanudarColumna(2);
        }

        private void reanudar_c4_Click(object sender, EventArgs e)
        {
            ReanudarColumna(3);
        }

        // M�todo para pausar la b�squeda de primos en una columna
        private void PausarColumna(int indice)
        {
            if (threads[indice] != null && threads[indice].IsAlive)
            {
                columnas[indice].Pausar();
            }
        }

        // M�todo para reanudar la b�squeda de primos en una columna
        private void ReanudarColumna(int indice)
        {
            if (threads[indice] != null && threads[indice].IsAlive)
            {
                columnas[indice].Reanudar();
            }
        }

        // Evento del bot�n de detener cada columna
        private void detener_c1_Click(object sender, EventArgs e)
        {
            DetenerColumna(0);
        }

        private void detener_c2_Click(object sender, EventArgs e)
        {
            DetenerColumna(1);
        }

        private void detener_c3_Click(object sender, EventArgs e)
        {
            DetenerColumna(2);
        }

        private void detener_c4_Click(object sender, EventArgs e)
        {
            DetenerColumna(3);
        }

        // M�todo para detener la b�squeda de primos en una columna y esperar a que termine
        private void DetenerColumna(int indice)
        {
            if (threads[indice] != null && threads[indice].IsAlive)
            {
                DetenerHilo(threads[indice]);
            }
        }
    }
}
