using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Controllers
{
    interface IControllerDistribucion
    {
        List<double> CalcularProbabilidades(List<double> listaIntervalos, int N);
        List<double> GenerarNrosAleatorios(int cantidad);

        double[] CalcularFe(int N, List<double> probabilidades);
    }
}
