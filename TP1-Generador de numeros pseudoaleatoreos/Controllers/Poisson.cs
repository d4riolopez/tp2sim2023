using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class Poisson : IControllerDistribucion
    {
        double lambda;
        public Poisson(double lambda)
        {
            this.lambda = lambda;
        }

        public double[] CalcularFe(int N, List<double> probabilidades)
        {
            double[] frecuenciasEsperadas = new double[probabilidades.Count];
            for (int i = 0; i < probabilidades.Count; i++)
            {
                frecuenciasEsperadas[i] = Math.Round(N * probabilidades[i]);
            }
            return frecuenciasEsperadas;
        }

        public List<double> CalcularProbabilidades(List<double> listaConValores, int N)
        {
            List<double> probabilidades = new List<double>();
            for (int i = 0; i < listaConValores.Count; i++)
            {
                double numerador1 = Math.Pow(lambda, listaConValores[i]);
                double numerador2 = Math.Exp(-lambda);
                double factorial = 1;
                for (double j = listaConValores[i]; j >= 1; j--)
                {
                    factorial *= j;
                }
                double probabilidad = (numerador1 * numerador2) / factorial;
                probabilidades.Add(probabilidad);
                
            }
            return probabilidades;
        }

        public List<double> GenerarNrosAleatorios(int cantidad)
        {
            List<double> listaNrosExponencialesAleatorios = new List<double>();
            
            Random rnd = new Random();

            double A = Math.Exp(-lambda);

            for (int i = 0; i < cantidad; i++)
            {
                double P = 1;
                int X = -1;

                do
                {
                    double U = rnd.NextDouble();
                    P *= U;
                    X += 1;
                } while (P >= A);
                
                listaNrosExponencialesAleatorios.Add(X);
            }

            return listaNrosExponencialesAleatorios;
        }
    }
}
