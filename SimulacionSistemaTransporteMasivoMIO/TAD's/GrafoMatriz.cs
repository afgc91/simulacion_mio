using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.TAD_s
{
    class GrafoMatriz<E> : IGrafo<E>
    {

        public static int CANTIDAD_VERTICES = 200;
        private Vertice<E>[] vertices;
        private double[][] matriz;
        private int cantidadVertices;
        private int cantidadAristas;

        public GrafoMatriz()
        {
            vertices = new Vertice<E>[CANTIDAD_VERTICES];
            matriz = new double[CANTIDAD_VERTICES][];
            cantidadVertices = 0;
            cantidadAristas = 0;
        }

        public void inicializarMatriz()
        {
            for (int i = 0; i < CANTIDAD_VERTICES; i++)
            {
                for (int j = 0; j < CANTIDAD_VERTICES; j++)
                {
                    if (i == j)
                    {
                        matriz[i][j] = 0;
                    }
                    else
                    {
                        matriz[i][j] = Double.MaxValue;
                    }
                }
            }
        }
        public void AgregarVertice(E elemento)
        {
            Vertice<E> e = new Vertice<E>(elemento);
            vertices[cantidadVertices] = e;
            cantidadVertices++;
        }

        public void AgregarArista(E inicio, E fin, double ponderacion)
        {
            int inicioM = EncontrarVertice(inicio);
            int finM = EncontrarVertice(fin);
            if (inicioM != -1 && finM != -1)
            {
                matriz[inicioM][finM] = ponderacion;
            }
          
        }
        /// <summary>
        /// Encuentra la posición del vertice en el arreglo
        /// </summary>
        /// <param name="elemento">Vertice a encontrar</param>
        /// <returns>-1 si no esta en el arreglo, int con la pos si esta el elemento</returns>
        private int EncontrarVertice(E elemento)
        {
            int retorno = -1;
            for (int i = 0; i < cantidadVertices && retorno == -1; i++)
            {
                if (elemento.Equals(vertices[i].elemento))
                {
                    retorno = i;
                }
            }
                return retorno;
        }

        public void EliminarVertice(E elemento)
        {
            int pos = EncontrarVertice(elemento);
            if (pos != -1)
            {
                vertices[pos] = null;
            }
        }

        public void ElinimarArista(E inicio, E fin, double ponderacion)
        {
            int inicioM = EncontrarVertice(inicio);
            int finM = EncontrarVertice(fin);
            if (inicioM != -1 && finM != -1)
            {
                matriz[inicioM][finM] = 0;
            }
        }

        public List<E> DarAdyacencias(E elemento)
        {
            List<E> adyacencias = new List<E>();
            int pos = EncontrarVertice(elemento);
            if (pos != -1)
            {
                for (int i = 0; i < cantidadVertices; i++)
                {
                    if (matriz[pos][i] != 0)
                    {
                        adyacencias.Add(vertices[i].elemento);
                    }
                }
            }
            return adyacencias;
        }

        public bool HayCamino(E inicio, E fin)
        {
            throw new NotImplementedException();
        }

        public List<E> DarCamino(E inicio, E fin)
        {
            throw new NotImplementedException();
        }

        public List<E> BFS(E elemento)
        {
            throw new NotImplementedException();
        }


        public int CantidadVertices()
        {
            return cantidadVertices;
        }

        public int CantidadAristas()
        {
            return cantidadAristas;
        }
    }
}
