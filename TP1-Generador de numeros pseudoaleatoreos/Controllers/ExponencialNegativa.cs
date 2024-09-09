using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class ExponencialNegativa : IControllerDistribucion
    {
        double lambda;
        public ExponencialNegativa(double lambda) 
        {
            this.lambda = lambda; 
        }

        public double[] CalcularFe(int N, List<double> probabilidades)
        {
            double[] frecuenciasEsperadas = new double[probabilidades.Count];
            for (int i = 0; i < probabilidades.Count; i++)
            {
                frecuenciasEsperadas[i] = N * probabilidades[i];
            }
            return frecuenciasEsperadas;
        }

        public List<double> CalcularProbabilidades(List<double> intervalos, int N)
        {
            List<double> probabilidades = new List<double>();
            for (int i = 0; i < intervalos.Count - 1; i++)
            {
                double probabilidad = (1 - Math.Exp(-lambda * intervalos[i + 1])) - (1 - Math.Exp(-lambda * intervalos[i]));
                probabilidades.Add(probabilidad);
            }
            return probabilidades;
        }

        public List<double> GenerarNrosAleatorios(int cantidad)
        {
            List<double> listaNrosExponencialesAleatorios = new List<double>();
            Random generador = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                double rnd = Math.Truncate(generador.NextDouble() * 10000) / 10000;
                double x = ((-1)/this.lambda) * Math.Log(1 - rnd);
                //if (x >= 1)
                //{
                //    MessageBox.Show(x.ToString() + "debido a un rnd de: " + rnd.ToString() + " y un lambda de: " + lambda.ToString());
                //}
                listaNrosExponencialesAleatorios.Add(x);
            }
            return listaNrosExponencialesAleatorios;
        }
    }
}
