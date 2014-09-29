using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas
{
    public interface IArregloCola<E>
    {
        /// <summary>
        /// Este metodo se encarga de agregar un elemento
        /// a una cola en el arreglo
        /// </summary>
        /// <pre>La posición esta en el arreglo</pre>
        /// <param name="elemento">Elemento a agregar</param>
        /// <param name="pos">Posicion de la cola en el arreglo</param>
        void AgregarElemento(E elemento, int pos);
        /// <summary>
        /// Este metodo se encarga de eliminar un elemento
        /// a una cola en el arreglo
        /// </summary>
        /// <pre>La posición esta en el arreglo</pre>
        /// <param name="pos">Posición de la cola en el arreglo</param>
        void EliminarElemento(int pos);
        /// <summary>
        /// Determina si una cola en el arreglo se encuentra vacia
        /// </summary>
        /// <pre>La posición esta en el arreglo</pre>
        /// <param name="pos">Posición de la cola en el arreglo</param>
        /// <returns>True si la cola esta vacia, false si tiene elementos</returns>
        bool ColaVacia(int pos);
        /// <summary>
        /// Retorna el tamaño de la cola especificada
        /// </summary>
        /// <pre>La posición esta en el arreglo</pre>
        /// <param name="pos">Posición de la cola en el arreglo</param>
        /// <returns>Entero con el tamaño de la cola</returns>
        int TamanoCola(int pos);
        /// <summary>
        /// Obtiene pero no elimina un elemento de la cola
        /// </summary>
        /// <pre>La posición esta en el arreglo</pre>
        /// <param name="pos">Posición de la cola en el arreglo</param>
        /// <returns>Elemento de la cola</returns>
        E ObtenerElemento(int pos);
        /// <summary>
        /// Retorna la cantidad de colas de la estructura
        /// </summary>
        /// <returns>Entero con la cantidad de elementos.</returns>
        int DarTamano();

    }
}
