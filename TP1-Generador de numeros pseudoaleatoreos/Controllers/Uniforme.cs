using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class Uniforme : IControllerDistribucion
    {
        double A;
        double B;
        double Fe;

        public Uniforme(double a, double b){
            this.A = a;
            this.B = b;
        }

        public double[] CalcularFe(int N, List<double> probabilidades)
        {
            double[] frecuenciasEsperadas = new double[probabilidades.Count];
            Fe = N / ( (double) probabilidades.Count -1);
            for (int i = 0; i < probabilidades.Count -1; i++)
            {
                frecuenciasEsperadas[i] = Fe;
            }
            return frecuenciasEsperadas;
        }

        public List<double> CalcularProbabilidades(List<double> listaIntervalos, int N)
        {
            List<double> probabilidades = new List<double>();
            double probabilidad = Fe / N;
            for (int i = 0; i < listaIntervalos.Count; i++)
            {
                probabilidades.Add(probabilidad);
            }
            return probabilidades;
            // throw new NotImplementedException();
        }

        public List<double> GenerarNrosAleatorios(int cantidad)
        {
            List<double> listaNrosExponencialesAleatorios = new List<double>();
            Random generador = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                double rnd = Math.Truncate(generador.NextDouble() * 10000) / 10000;
                double x = this.A + (rnd * (this.B - this.A));
                listaNrosExponencialesAleatorios.Add(x);
            }
            return listaNrosExponencialesAleatorios;
        }
    }
}
