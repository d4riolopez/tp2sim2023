using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Generador_de_numeros_pseudoaleatoreos.Forms;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ControllerBondadAjuste
    {
        BondadAjuste interfaz;
        List<double> listaIntervalos;
        List<double> listaNrosConDistribucion;
        int[] frecuencias_observadas;
        double[] frecuencias_esperadas;
        List<double> probabilidades;
        int parametros_empiricos;
        IControllerDistribucion distribucion;

        double[] arrayChiCuadrado = new double[] { 3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507, 16.919, 18.307, 19.675, 21.026, 
                                                   22.362, 23.685, 24.996, 26.296, 27.587, 28.869, 30.144, 31.410, 32.671, 33.924, 35.172, 36.415, 
                                                   37.652, 38.885, 40.113, 41.337, 42.557 };
        double[] arrayKs = new double[] { 0.97500, 0.84189, 0.70760, 0.62394, 0.56328, 0.51926, 0.48342, 0.45427, 0.43001, 0.40925, 0.39122, 0.37543, 
                                          0.36143, 0.34890, 0.33750, 0.32733, 0,31796, 0.30936, 0.30143, 0.29408, 0.28724, 0.28087, 0.27490, 0.26931,
                                          0.26404, 0.25908, 0.25438, 0.24993, 0.24571, 0.24170, 0.23788, 0.23424, 0.23076, 0.22743, 0.22425};


        public ControllerBondadAjuste(BondadAjuste interfaz)
        {
            this.interfaz = interfaz;
        }

        private void CalcularFrecuencias(int N)
        {
            if (interfaz.GetDistribucionSeleccionada() == "Distribucion Poisson")
                frecuencias_observadas = CalcularFoP();
            else
                frecuencias_observadas = CalcularFo();

            frecuencias_esperadas = distribucion.CalcularFe(N, probabilidades);
        }

        public void RealizarPruebaLenguaje(int N, int cantIntervalos)
        {
            GenerarNrosConDistribucion(N, cantIntervalos);
            CalcularFrecuencias(N);
            interfaz.GenerarHistograma(frecuencias_observadas, frecuencias_esperadas, listaIntervalos);
            RealizarPruebaKS(cantIntervalos, N);
            RealizarPruebaChiCuadrado(cantIntervalos, N);
        }

        /// <summary>
        /// Método encargado de realizar el calculo de cada uno de los parámetros a mostrar
        /// en la Tabla y el Histograma de frecuencias, definiendo también si la hipotesis
        /// se rechaza o no se rechaza a partir de los valores obtenidos de la distribución.
        /// </summary>
        private void RealizarPruebaChiCuadrado(int cantIntervalos, int N)
        {
            if (interfaz.GetDistribucionSeleccionada() == "Distribucion Poisson")
                frecuencias_observadas = CalcularFoP();
            else
                frecuencias_observadas = CalcularFo();

            frecuencias_esperadas = distribucion.CalcularFe(N, probabilidades);
            Acumular();

            double[] estadisticos = CalcularEstadisticoMuestreo(frecuencias_esperadas, frecuencias_observadas);
            double[] estadisticos_acum = EstadisticosAcumulados(estadisticos);
            interfaz.LlenarTablaChiCuadrado(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, estadisticos, estadisticos_acum);
            int k = listaIntervalos.Count - 1;
            int gradosLibertad = k - 1 - parametros_empiricos;
            if (estadisticos_acum[estadisticos_acum.Length - 2] < arrayChiCuadrado[gradosLibertad - 1])
            {
                string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 1] + " < " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";
                if (interfaz.GetDistribucionSeleccionada() == "Distribucion Uniforme")
                    mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " < " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";

                string hex = "#0096c7";
                Color color = System.Drawing.ColorTranslator.FromHtml(hex);
                interfaz.MostrarResultadoHipotesis(mensaje, color);
            }
            else
            {
                string mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 1] + " > " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                if (interfaz.GetDistribucionSeleccionada() == "Distribucion Uniforme")
                    mensaje = " Estadístico de prueba: " + estadisticos_acum[estadisticos_acum.Length - 2] + " > " + " Valor tabulado: " + arrayChiCuadrado[gradosLibertad - 1] + " con " + gradosLibertad + " grados de libertad\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                Color color = Color.DarkRed;
                interfaz.MostrarResultadoHipotesis(mensaje, color);
            }
        }

        private void Acumular()
        {
            List<double> frecuencias_esperadas_acumuladas = new List<double>();
            List<int> frecuencias_observadas_acumuladas = new List<int>();
            int indice = 0;
            frecuencias_esperadas_acumuladas.Add(frecuencias_esperadas[0]);
            frecuencias_observadas_acumuladas.Add(frecuencias_observadas[0]);

            List<double> listaIntervalosArtificiales = new List<double>();

            listaIntervalosArtificiales.Add(listaIntervalos[0]);

            for(int i = 1; i <= frecuencias_esperadas.Length - 1; i++)
            {
                if (frecuencias_esperadas_acumuladas[indice] <= 5)
                {
                    frecuencias_esperadas_acumuladas[indice] += frecuencias_esperadas[i];
                    frecuencias_observadas_acumuladas[indice] += frecuencias_observadas[i];             
                } 
                else
                {
                    indice += 1;
                    frecuencias_esperadas_acumuladas.Add(frecuencias_esperadas[i]);
                    frecuencias_observadas_acumuladas.Add(frecuencias_observadas[i]);

                    listaIntervalosArtificiales.Add(listaIntervalos[i]);
                }
            }
            if (interfaz.GetDistribucionSeleccionada() != "Distribucion Uniforme")
                listaIntervalosArtificiales.Add(listaIntervalos[listaIntervalos.Count - 1]);

            if (frecuencias_esperadas_acumuladas[indice] < 5)
            {
                frecuencias_esperadas_acumuladas[indice-1] += frecuencias_esperadas_acumuladas[indice];
                frecuencias_observadas_acumuladas[indice - 1] += frecuencias_observadas_acumuladas[indice];

                frecuencias_esperadas_acumuladas.RemoveAt(indice);
                frecuencias_observadas_acumuladas.RemoveAt(indice);
                listaIntervalosArtificiales.RemoveAt(indice - 1);
            }
            frecuencias_esperadas = frecuencias_esperadas_acumuladas.ToArray();
            frecuencias_observadas = frecuencias_observadas_acumuladas.ToArray();
            listaIntervalos = listaIntervalosArtificiales;
        }

        private void GenerarNrosConDistribucion(int N, int cantIntervalos)
        {
            switch (interfaz.GetDistribucionSeleccionada())
            {
                case "Distribucion Normal (Box-Muller)":
                    double mediaBox = interfaz.GetMediaNormal();
                    double desvEstandarBox = interfaz.GetDesvEstandarNormal();
                    distribucion = new Normal(desvEstandarBox, mediaBox, 1);
                    listaNrosConDistribucion = distribucion.GenerarNrosAleatorios(N);
                    GenerarIntervalos(cantIntervalos, listaNrosConDistribucion);
                    probabilidades = distribucion.CalcularProbabilidades(listaIntervalos, N);
                    parametros_empiricos = 2;
                    break;
                case "Distribucion Normal (Convolucion)":
                    double mediaConv = interfaz.GetMediaNormal();
                    double desvEstandarConv = interfaz.GetDesvEstandarNormal();
                    distribucion = new Normal(desvEstandarConv, mediaConv, 2);
                    listaNrosConDistribucion = distribucion.GenerarNrosAleatorios(N);
                    GenerarIntervalos(cantIntervalos, listaNrosConDistribucion);
                    probabilidades = distribucion.CalcularProbabilidades(listaIntervalos, N);
                    parametros_empiricos = 2;
                    break;
                case "Distribucion Exponencial Neg.":
                    double lambda = interfaz.GetLambdaExponencial();
                    distribucion = new ExponencialNegativa(lambda);
                    listaNrosConDistribucion = distribucion.GenerarNrosAleatorios(N);
                    GenerarIntervalos(cantIntervalos, listaNrosConDistribucion);
                    probabilidades = distribucion.CalcularProbabilidades(listaIntervalos, N);
                    parametros_empiricos = 1;
                    break;
                case "Distribucion Uniforme":
                    double A = interfaz.GetAUniforme();
                    double B = interfaz.GetBUniforme();
                    distribucion = new Uniforme(A, B);
                    listaNrosConDistribucion = distribucion.GenerarNrosAleatorios(N);
                    GenerarIntervalos(cantIntervalos, listaNrosConDistribucion, A, B);
                    frecuencias_esperadas = distribucion.CalcularFe(N, listaIntervalos);
                    probabilidades = distribucion.CalcularProbabilidades(listaIntervalos, N);
                    parametros_empiricos = 0; 
                    break;
                case "Distribucion Poisson": // No se le hace el KS
                    double lambdaPoisson = interfaz.GetLambdaPoisson();
                    distribucion = new Poisson(lambdaPoisson);
                    listaNrosConDistribucion = distribucion.GenerarNrosAleatorios(N);
                    List <double> listaValores = listaNrosConDistribucion.Distinct().OrderBy(number => number).ToList();
                    IEnumerable<int> listaIntervalosP = Enumerable.Range(Convert.ToInt32(listaValores[0]), Convert.ToInt32((listaValores[listaValores.Count-1]- listaValores[0] )+ 1));
                    listaIntervalos = listaIntervalosP.Select(x => Convert.ToDouble(x)).ToList();
                    probabilidades = distribucion.CalcularProbabilidades(listaIntervalos, N);
                    // No puede usar calcularFo porque no tiene intervalos
                    parametros_empiricos = 1;
                    break;
                default:
                    break;
            }
        }

        private void RealizarPruebaKS(int cantIntervalos, int N)
        {
            if (interfaz.GetDistribucionSeleccionada() == "Distribucion Poisson") return;

            frecuencias_esperadas = distribucion.CalcularFe(N, probabilidades);
            double[] probabilidad = CalcularProbabilidad(frecuencias_observadas, N);
            double[] probabilidadAcum = CalcularProbabilidadAcum(probabilidad);
            double[] probabilidadE = CalcularProbabilidadE(probabilidades);
            double[] probabilidadEAcum = CalcularProbabilidadEAcum(probabilidadE);
            double[] diferenciaAcum = CalcularDiferenciaAcum(probabilidadAcum, probabilidadEAcum);
            double[] maxDifAcum = CalcularMaxDifAcum(diferenciaAcum);

            interfaz.LlenarTablaKS(listaIntervalos, frecuencias_observadas, frecuencias_esperadas, probabilidades, probabilidad, probabilidadAcum, probabilidadE, probabilidadEAcum, diferenciaAcum, maxDifAcum);
            double valor_tabulado = 1.36 / (Math.Sqrt(listaNrosConDistribucion.Count));

            if (N <= 35)
            {
                valor_tabulado = arrayKs[N - 1];
            } else
            {
                valor_tabulado = 1.52/Math.Sqrt(N);
            }

            if ( maxDifAcum.Max() < valor_tabulado)
            {
                string mensaje = " Estadístico de prueba: " + maxDifAcum[maxDifAcum.Length-2] + " < " + " Valor tabulado: " + valor_tabulado + " con una muestra de" + N + "\n" +
                    "\t La hipotesis no se rechaza. Nivel de significancia 1−∝= 0,95";
                string hex = "#0096c7";
                Color color = System.Drawing.ColorTranslator.FromHtml(hex);
                interfaz.MostrarResultadoHipotesisKs(mensaje, color);
            }
            else
            {
                string mensaje = " Estadístico de prueba: " + maxDifAcum[maxDifAcum.Length-2] + " > " + " Valor tabulado: " + valor_tabulado + " con una muestra de " + N + "\n" +
                    "\t La hipotesis se rechaza. Nivel de significancia 1−∝= 0,95";
                Color color = Color.DarkRed;
                interfaz.MostrarResultadoHipotesisKs(mensaje, color);
            }
        }

        /// <summary>
        /// Método que permite definir los intervalos de nuestra distribución, a partir
        /// de la cantidad de intervalos seleccionada.
        /// </summary>
        private void GenerarIntervalos(int cantIntervalos, List<double> listaNrosAleatorios, double a = 1, double b = 0)
        {
            listaIntervalos = new List<double>();
            double minimo;
            double maximo;
            if (a > b)
            {
                minimo = listaNrosAleatorios.Min();
                maximo = listaNrosAleatorios.Max();
            }
            else
            {
                minimo = a;
                maximo = b;
            }
            double intervalo = ( (maximo - minimo)/ (double)cantIntervalos);
            double acum = minimo;
            for (int i = 0; i <= cantIntervalos; i++)
            {
                listaIntervalos.Add(Math.Round(acum, 3));
                acum += intervalo;
                acum = (Math.Truncate(acum * 10000) / 10000);
            }
        }

        public void MostrarSerie()
        {
            if (this.listaNrosConDistribucion != null)
                interfaz.MostrarNumeros(listaNrosConDistribucion);
            else
                MessageBox.Show("No hay números generados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Método que calcula la Frecuencia Observada recorriendo cada uno de los intervalos 
        /// y estableciendo una condición para verificar a que intervalo pertenece cada uno
        /// de los números pseudo-aleatorios, y devuelve como resultado un array en donde cada 
        /// posición corresponde con cada uno de los intervalos.
        /// </summary>
        private int[] CalcularFo()
        {
            int[] contadoresFo = new int[listaIntervalos.Count];
            int contador = 0;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                if (i == (listaIntervalos.Count - 1))
                {
                    contador = listaNrosConDistribucion.Count(x => x >= listaIntervalos[i - 1] && x < listaIntervalos[listaIntervalos.Count - 1]);
                    contadoresFo[i] = contador;
                }
                else
                {
                    contador = listaNrosConDistribucion.Count(x => x >= listaIntervalos[i] && x < listaIntervalos[i + 1]);
                    contadoresFo[i] = contador;
                }
            }
            return contadoresFo;
        }

        private int[] CalcularFoP()
        {
            int[] contadoresFo = new int[listaIntervalos.Count];
            int contador = 0;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                contador = listaNrosConDistribucion.Count(x => x == listaIntervalos[i]);
                contadoresFo[i] = contador;
               
            }
            return contadoresFo;
        }

        /// <summary>
        /// Método que toma como parámetros el arrray de Frecuencias Observadas y 
        /// el de Frecuencias Esperadas y a partir de los mismos calcula el valor
        /// del estadístico de muestra para cada uno de los intervalos, y devuelve
        /// estos mismos valores contenidos en un array de doubles.
        /// </summary>
        private double[] CalcularEstadisticoMuestreo(double[] frecuencias_esperadas, int[] frecuencias_observadas)
        {
            double[] c = new double[frecuencias_esperadas.Length];
            for (int i = 0; i <= frecuencias_esperadas.Length - 1; i++)
            {
                c[i] = Math.Pow((frecuencias_observadas[i] - frecuencias_esperadas[i]), 2) / frecuencias_esperadas[i];
            }
            return c;
        }

        /// <summary>
        /// Método que calcula el estadistico acumulado a partir de los estadísticos
        /// obtenidos en cada uno de los intervalos, y retorna los valores obtenidos
        /// para cada intervalo contenidos en un array de doubles.
        /// </summary>
        private double[] EstadisticosAcumulados(double[] estadisticos)
        {
            double[] c_acum = new double[frecuencias_esperadas.Length];
            double aux = 0;
            for (int i = 0; i <= frecuencias_esperadas.Length - 1; i++)
            {
                c_acum[i] = estadisticos[i] + aux;
                aux = c_acum[i];
            }
            return c_acum;
        }


        private double[] CalcularProbabilidad(int[] frecuenciasObservadas, int N)
        {
            double NasDouble = Convert.ToDouble(N);
            double[] Po = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                Po[i] = Convert.ToDouble(frecuencias_observadas[i] / NasDouble);
            }
            return Po;
        }

        private double[] CalcularProbabilidadAcum(double[] probabilidades)
        {
            double[] PoAcum = new double[listaIntervalos.Count];
            double aux = 0;
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                PoAcum[i] = probabilidades[i] + aux;
                aux = PoAcum[i];
            }
            return PoAcum;
        }

        private double[] CalcularProbabilidadE(List<double> probabilidades)
        {
            double[] Pe = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                Pe[i] = probabilidades[i];
            }
            return Pe;
        }

        private double[] CalcularProbabilidadEAcum(double[] probabilidadE)
        {
            double[] PeAcum = new double[listaIntervalos.Count];
            double aux = 0;
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                PeAcum[i] = probabilidadE[i] + aux;
                aux = PeAcum[i];
            }
            return PeAcum;
        }

        private double[] CalcularDiferenciaAcum(double[] probabilidadAcum, double[] probabilidadEAcum)
        {
            double[] dif = new double[listaIntervalos.Count];
            for (int i = 0; i < listaIntervalos.Count - 1; i++)
            {
                dif[i] = Math.Abs(probabilidadAcum[i] - probabilidadEAcum[i]);
            }
            return dif;
        }
        private double[] CalcularMaxDifAcum(double[] difAcum)
        {
            double[] maxDif = new double[listaIntervalos.Count];
            maxDif[0] = difAcum[0];
            for (int i = 1; i < listaIntervalos.Count - 1; i++)
            {
                if (maxDif[i - 1] < difAcum[i])
                    maxDif[i] = difAcum[i];
                else
                    maxDif[i] = maxDif[i - 1];
            }
            return maxDif;
        }
    }
}
