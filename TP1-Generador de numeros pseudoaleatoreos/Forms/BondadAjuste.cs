using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Generador_de_numeros_pseudoaleatoreos.Controllers;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Forms
{
    public partial class BondadAjuste : Form
    {
        ControllerBondadAjuste controlador;

        double Fe;
        double Fo;
        double C;
        int N;
        int cantIntervalos = 0;
        List<double> listaNrosAleat;
        List<double> listaIntervalos;
        string cmbDistribucionSeleccionada { get; set; }

        public BondadAjuste()
        {
            InitializeComponent();
        }

        public string GetDistribucionSeleccionada()
        {
            return this.cmbDistribucionSeleccionada;
        }

        /// <summary>
        /// Método que delega la responsabilidad de realizar la prueba en función.
        /// </summary>
        private void RealizarPrueba(object sender, EventArgs e)
        {
            label4.Visible = false;
            dgvNros.Visible = false;
            dgvNros.Rows.Clear();
            if (cmbDistribucion.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una distribucion para la prueba de bondad de ajuste.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((cmbK.SelectedItem == null || txtN.Text.ToString() == "" || txtDesviacionNormal.Text.ToString() == "" || txtMediaNormal.Text.ToString() == "") && (cmbDistribucion.SelectedItem.ToString() == "Distribucion Normal (Convolucion)" || cmbDistribucion.SelectedItem.ToString() == "Distribucion Normal (Box-Muller)"))
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }   
            if ((txtN.Text.ToString() == "" || textBox2.Text.ToString() == "") && (cmbDistribucion.SelectedItem.ToString() == "Distribucion Poisson"))
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if((textBox2.Text.ToString() != "") && (double.Parse(textBox2.Text)) <= 0 && cmbDistribucion.SelectedItem.ToString() == "Distribucion Poisson")
            {
                MessageBox.Show("Lambda debe ser positivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((cmbK.SelectedItem == null || txtN.Text.ToString() == "" || txtLambdaExponencial.Text.ToString() == "") && (cmbDistribucion.SelectedItem.ToString() == "Distribucion Exponencial Neg."))
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((txtLambdaExponencial.Text.ToString() != "") && (double.Parse(txtLambdaExponencial.Text) <= 0 && cmbDistribucion.SelectedItem.ToString() == "Distribucion Exponencial Neg."))
            {
                MessageBox.Show("Lambda debe ser positivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((cmbK.SelectedItem == null || txtN.Text.ToString() == "" || txtA.Text.ToString() == "" || txtB.Text.ToString() == "") && (cmbDistribucion.SelectedItem.ToString() == "Distribucion Uniforme"))
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((txtA.Text.ToString() != "" || txtB.Text.ToString() != "") && (double.Parse(txtA.Text) > double.Parse(txtB.Text)))
            {
                MessageBox.Show("El valor de A debe ser menor que el valor de B, por favor ingrese otro valor ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if ((txtDesviacionNormal.Text.ToString() != "") && (double.Parse(txtDesviacionNormal.Text) < 0) && (cmbDistribucion.SelectedItem.ToString() == "Distribucion Normal (Box-Muller)" || cmbDistribucion.SelectedItem.ToString() == "Distribucion Normal (Convolucion)"))
            {
                MessageBox.Show("No se pueden ingresar numeros menores a 0, por favor ingrese otro valor ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmbDistribucionSeleccionada = cmbDistribucion.SelectedItem.ToString();
            if(Convert.ToInt32(txtN.Text) <= 50000)
            {
                N = Convert.ToInt32(txtN.Text);
            } else
            {
                N = 50000;
            }

            if (cmbDistribucionSeleccionada == "Distribucion Poisson")
            {
                controlador.RealizarPruebaLenguaje(N, 0);
            }
            else
            {
                controlador.RealizarPruebaLenguaje(N, cantIntervalos);
            }
        }

        public double GetLambdaExponencial()
        {
            return Convert.ToDouble(this.txtLambdaExponencial.Text);
        }

        public double GetLambdaPoisson()
        {
            return Convert.ToDouble(this.textBox2.Text);
        }

        public void GenerarHistograma(int[] frecuencias_observadas, double[] frecuencias_esperadas, List<double> listaIntervalos)
        {
            histograma.Series["Fe"].Points.Clear();
            histograma.Series["Fo"].Points.Clear();
            if (cmbDistribucionSeleccionada == "Distribucion Poisson")
            {
                for (int i = 0; i <= listaIntervalos.Count - 1; i++)
                // Recorre los intervalos y va agregandolos al grafico junto con las frecuencias
                {
                    histograma.Series["Fe"].Points.AddXY(listaIntervalos[i], frecuencias_esperadas[i]); //Agrega la fe al grafico             
                    histograma.Series["Fo"].Points.AddXY(listaIntervalos[i], frecuencias_observadas[i]);//Agrega la fo al grafico
                }
            }
            else
            {
                for (int i = 0; i < listaIntervalos.Count - 1; i++)
                // Recorre los intervalos y va agregandolos al grafico junto con las frecuencias
                {
                    histograma.Series["Fe"].Points.AddXY(listaIntervalos[i] + " - " + listaIntervalos[i + 1], frecuencias_esperadas[i]); //Agrega la fe al grafico             
                    histograma.Series["Fo"].Points.AddXY(listaIntervalos[i] + " - " + listaIntervalos[i + 1], frecuencias_observadas[i]);//Agrega la fo al grafico
                }
            }
        }

        /// <summary>
        /// Método que se encarga de llenar la tabla de frecuencias en base a los 
        /// datos obtenidos, a partir de la frecuencia observada y esperada obtenidas, y
        /// las formulas de estadistico de muestra y estadistico acumulado.
        /// </summary>
        public void LlenarTablaChiCuadrado(List<double> intervalos, int[] contadoresFo, double[] Fe, double[] c, double[] c_acumulado)
        {
            dgvChiCuadrado.Rows.Clear();
            if (cmbDistribucionSeleccionada == "Distribucion Poisson")
            {
                for (int i = 0; i <= intervalos.Count - 2; i++)
                {
                    dgvChiCuadrado.Rows.Add(
                        intervalos[i],
                        contadoresFo[i],
                        Fe[i],
                        Math.Truncate(c[i] * 10000) / 10000,
                        Math.Truncate(c_acumulado[i] * 10000) / 10000
                        );
                }
            }
            else
            {
                string[] txtIntervalos = new string[intervalos.Count - 1];
                for (int i = 0; i <= intervalos.Count - 2; i++)
                {
                    txtIntervalos[i] = intervalos[i].ToString() + "-" + intervalos[i + 1].ToString();
                    dgvChiCuadrado.Rows.Add(
                    txtIntervalos[i],
                    contadoresFo[i],
                    Fe[i],
                    Math.Truncate(c[i] * 10000) / 10000,
                    Math.Truncate(c_acumulado[i] * 10000) / 10000
                    );
                }
            }
        }

        public void LlenarTablaKS(List<double> intervalos, int[] contadoresFo, double[] Fe, List<double> probabilidades, double[] Po, double[] PoAcum, double[] Pe, double[] PeAcum, double[] diferenciaAcum, double[] maxDifAcum)
        {
            dgvKs.Rows.Clear();

            for (int i = 0; i < intervalos.Count - 1; i++)
            {
                string desdeHasta = intervalos[i] + " - " + intervalos[i + 1];
                if (i == intervalos.Count)
                {
                    desdeHasta = intervalos[i] + " - " + 1;
                }

                dgvKs.Rows.Add(
                    desdeHasta,
                    contadoresFo[i],
                    Fe[i],
                    Po[i],
                    PoAcum[i],
                    Pe[i],
                    PeAcum[i],
                    diferenciaAcum[i],
                    maxDifAcum[i]
                    );
            }
        }

        /// <summary>
        /// Método que se encarga de limpiar los campos del formulario.
        /// </summary>
        private void LimpiarCampos()
        {
            dgvNros.Rows.Clear();
            dgvChiCuadrado.Rows.Clear();
            dgvKs.Rows.Clear();
            cmbK.SelectedItem = null;
            txtN.Text = "";
            histograma.Series["Fe"].Points.Clear();
            histograma.Series["Fo"].Points.Clear();
            lblHipotesis.Text = "";
            lblHipotesisKs.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void cmbK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cantIntervalos = Convert.ToInt32(cmbK.SelectedItem.ToString());
        }

        private void BondadAjuste_Load(object sender, EventArgs e)
        {
            controlador = new ControllerBondadAjuste(this);
        }

        /// <summary>
        /// Método que toma la lista de números pseudo-aleatorios generados por parámetro
        /// y los agrega uno por uno a un elemento del tipo Data Grid View para que 
        /// puedan ser visualizados.
        /// </summary>
        public void MostrarNumeros(List<double> nros)
        {
            listaNrosAleat = nros;
            dgvNros.Rows.Clear();
            for (int i = 0; i < nros.Count; i++)
            {
            dgvNros.Rows.Add(i + 1, nros[i].ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void MostrarResultadoHipotesis(string mensaje, Color color)
        {
            lblHipotesis.Text = mensaje;
            lblHipotesis.Visible = true;
            lblHipotesis.ForeColor = color;
        }

        private void DeshabilitarParametros()
        {
            gbUniforme.Visible = false;
            gbPoisson.Visible = false;
            gbNormal.Visible = false;
            gbExponencial.Visible = false;
        }

        public double GetMediaNormal()
        {
            return Convert.ToDouble(txtMediaNormal.Text.ToString());
        }

        public double GetDesvEstandarNormal()
        {
            return Convert.ToDouble(txtDesviacionNormal.Text.ToString());
        }

        private void VerSerie(object sender, EventArgs e)
        {
            controlador.MostrarSerie();
            dgvNros.Visible = true;
            label4.Visible = true;
        }

        public void MostrarResultadoHipotesisKs(string mensaje, Color color)
        {
            if (GetDistribucionSeleccionada() != "Distribucion Poisson")
            {
                lblHipotesisKs.Text = mensaje;
                lblHipotesisKs.Visible = true;
                lblHipotesisKs.ForeColor = color;
            }
        }

        public double GetAUniforme()
        {
            return Convert.ToDouble(txtA.Text.ToString());
        }
        public double GetBUniforme()
        {
            return Convert.ToDouble(txtB.Text.ToString());
        }

        private void ValidarDistribucion(object sender, EventArgs e)
        {
            DeshabilitarParametros();
            dgvKs.Visible = true;
            lblHipotesisKs.Visible = true;
            label1.Visible = true;
            cmbK.Visible = true;
            switch (cmbDistribucion.SelectedItem.ToString())
            {
                case "Distribucion Normal (Box-Muller)":
                    gbNormal.Visible = true;
                    break;
                case "Distribucion Normal (Convolucion)":
                    gbNormal.Visible = true;

                    break;
                case "Distribucion Exponencial Neg.":
                    gbExponencial.Visible = true;

                    break;
                case "Distribucion Uniforme":
                    gbUniforme.Visible = true;
                    break;
                case "Distribucion Poisson":
                    gbPoisson.Visible = true;
                    cmbK.Visible = false;
                    dgvKs.Visible = false;
                    lblHipotesisKs.Visible = false;
                    label1.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}
