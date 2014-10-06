using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.TAD_s
{
    public interface IGrafo<E>
    {
        /// <summary>
        /// Este metodo se encarga de agregar un vertice al grafo
        /// </summary>
        /// <param name="elemento">Elemento que se desea agregar</param>
        void AgregarVertice(E elemento);
        /// <summary>
        /// Este metodo se encarga de agregar una arista al grafo
        /// </summary>
        /// <param name="inicio">Vertice de inicio</param>
        /// <param name="fin">Vertice de fin</param>
        /// <param name="ponderacion">Peso de la arista</param>
        void AgregarArista(E inicio, E fin, double ponderacion);
        /// <summary>
        /// Este metodo se encarga de eliminar un vertice
        /// </summary>
        /// <param name="elemento">Vertice que se desea eliminar</param>
        void EliminarVertice(E elemento);
        /// <summary>
        /// Este metodo se encarga de eliminar una Arista
        /// </summary>
        /// <param name="inicio">Vertice de inicio</param>
        /// <param name="fin">Vertice de fin</param>
        /// <param name="ponderacion">Peso de la arista</param>
        void ElinimarArista(E inicio, E fin, double ponderacion);
        /// <summary>
        /// Este metodo se encarga de dar las adyacencias de un vertice
        /// </summary>
        /// <param name="elemento">Vertice a encontrar adyacencias</param>
        /// <returns>Retorna una lista con los vertices adyacentes</returns>
        List<E> DarAdyacencias(E elemento);
        /// <summary>
        /// Este metodo determina si existe un camino entre dos vertices
        /// </summary>
        /// <param name="inicio">Vertice de inicio</param>
        /// <param name="fin">Vertice destino</param>
        /// <returns>True si existe un camino, False si no lo hay</returns>
        Boolean HayCamino(E inicio, E fin);
        /// <summary>
        /// Este metodo se encarga de retornar una lista de vertices 
        /// que se debe seguir para llegar de uno a otro
        /// <pre>Existe un camino entre los vertices</pre>
        /// </summary>
        /// <param name="inicio">Vertice de inicio</param>
        /// <param name="fin">Vertice destino</param>
        /// <returns>Lista con los vertices que se debe seguir</returns>
        List<E> DarCamino(E inicio, E fin);
        /// <summary>
        /// Recorrido en amplitud
        /// </summary>
        /// <param name="elemento">Vertice de inicio</param>
        /// <returns>Lista con el recorrido</returns>
        List<E> BFS(E elemento);
        /// <summary>
        /// Retorna la distancia minima entre un vertices de inicio y el resto de vertices
        /// </summary>
        /// <param name="inicio">Vertice de inicio</param>
        /// <returns>Arreglo de objetos con la información relevante</returns>
        object[] Dijkstra(E inicio);
        /// <summary>
        /// Retorna la cantidad de vertices en el grafo
        /// </summary>
        /// <returns>Cantidad de vertices</returns>
        int CantidadVertices();
        /// <summary>
        /// Retorna la cantidad de aristas en el grafo
        /// </summary>
        /// <returns>Cantidad de aristas</returns>
        int CantidadAristas();
    }
}
