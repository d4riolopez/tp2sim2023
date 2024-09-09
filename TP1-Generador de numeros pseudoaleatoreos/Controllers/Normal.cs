using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    class Normal : IControllerDistribucion
    {
        double desvEstandar;
        double media;
        int tipoDistribucion;

        public Normal(double desvEstandar, double media, int tipoDistribucion)
        {
            this.desvEstandar = desvEstandar;
            this.media = media;
            this.tipoDistribucion = tipoDistribucion;
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
                double difEntreHasta = (intervalos[i + 1]-intervalos[i]);
                double marcaClase = (intervalos[i] + intervalos[i + 1]) / 2;
                double calculo = ((marcaClase - media) / desvEstandar);
                double exponente = Math.Pow(calculo,2);
                double numerador = (Math.Exp(-0.5 * (exponente)));
                double denominador = (desvEstandar * Math.Sqrt(2 * Math.PI));
                double probabilidad = (numerador / denominador) * difEntreHasta;
                probabilidades.Add(probabilidad);
            }
            return probabilidades;
        }

        public List<double> GenerarNrosAleatorios(int cantidad)
        {
            List<double> listaNrosNormalesAleatorios = new List<double>();
            if (tipoDistribucion == 1)
            {
                Random generador = new Random();
                for (int i = 0; i < cantidad / 2; i++)
                {
                    double rnd = generador.NextDouble(); 
                    double rnd2 = generador.NextDouble();
                    double primerParte = ((Math.Sqrt(-2 * Math.Log(rnd))));
                    double segundaParte = Math.Cos(2 * Math.PI * rnd2);
                    double segundaParteN2 = Math.Sin(2 * Math.PI * rnd2);
                    double N1 = ((primerParte * segundaParte) * desvEstandar) + media;
                    double N2 = ((primerParte * segundaParteN2) * desvEstandar) + media;
                    if(N1==(Double.NaN) || N2 ==(Double.NaN) || Double.IsInfinity(N1) || Double.IsInfinity(N2))
                    {
                        MessageBox.Show("N1: " + N1.ToString() + " N2: " + N2.ToString());
                    }
                    listaNrosNormalesAleatorios.Add(N1);
                    listaNrosNormalesAleatorios.Add(N2);
                }
            }
            else
            {
                Random generador = new Random();

                for (int i = 0; i < cantidad; i++)
                {
                    double acum = 0;
                    for (int j = 0; j < 12; j++)
                    {
                        double rnd = Math.Truncate(generador.NextDouble() * 10000) / 10000;
                        acum = acum + rnd;
                    }
                    double z = ((acum - 6) * desvEstandar) + media;
                    listaNrosNormalesAleatorios.Add(z);
                }
            }
            return listaNrosNormalesAleatorios;
        }
    }
}
