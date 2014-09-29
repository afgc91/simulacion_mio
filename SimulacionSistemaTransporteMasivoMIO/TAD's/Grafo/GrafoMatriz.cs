using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.TAD_s
{
    public class GrafoMatriz<E> : IGrafo<E>
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

        private void inicializarMatriz()
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
            if (EncontrarVertice(elemento) == -1)
            {
                vertices[cantidadVertices] = e;
                cantidadVertices++;
            }
            else
            {
                throw new Exception("El vertice ya se encuentra en el grafo");
            }
        }

        public void AgregarArista(E inicio, E fin, double ponderacion)
        {
            int inicioM = EncontrarVertice(inicio);
            int finM = EncontrarVertice(fin);
            if (inicioM != -1 && finM != -1)
            {
                if (matriz[inicioM][finM] == Double.MaxValue)
                    matriz[inicioM][finM] = ponderacion;
                else
                    throw new Exception("Ya existe una arista");
            }
            else
            {
                throw new Exception("No existe el vertice");
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
                cantidadVertices--;
            }else{
                throw new Exception("No se encuentra el vertice");
            }
            
        }

        public void ElinimarArista(E inicio, E fin, double ponderacion)
        {
            int inicioM = EncontrarVertice(inicio);
            int finM = EncontrarVertice(fin);
            if (inicioM != -1 && finM != -1)
            {
                matriz[inicioM][finM] = Double.MaxValue;
                cantidadAristas--;
            }
            else
            {
                throw new Exception("El vertice no existe");
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
                    if (matriz[pos][i] != Double.MaxValue)
                    {
                        adyacencias.Add(vertices[i].elemento);
                    }
                }
            }
            return adyacencias;
        }

        public bool HayCamino(E inicio, E fin)
        {
            List<E> e = BFS(inicio);
            if (e.Contains(fin))
            {
                return true;
            }
            return false;
        }

        public List<E> DarCamino(E inicio, E fin)
        {
            List<E> elementos = DarAdyacencias(inicio);
            List<E> resultado = new List<E>();
            resultado.Add(inicio);
            foreach(E e in elementos){
                if (HayCamino(e, fin))
                {
                    auxDarCamino(e, fin, resultado);
                }
            }
            return resultado;
        }
        private void auxDarCamino(E inicio, E fin, List<E> element){
            List<E> elementos = DarAdyacencias(inicio);
            if (!inicio.Equals(fin))
            {
                foreach (E e in elementos)
                {
                    if (HayCamino(e, fin))
                    {
                        element.Add(e);
                        auxDarCamino(e, fin, element);
                    }
                }
            }
    }
     

        public List<E> BFS(E elemento)
        {
            List<E> elementos = new List<E>();
            Queue<E> cola = new Queue<E>();
            List<E> adyacentes = DarAdyacencias(elemento);
            elementos.Add(elemento);
            for (int i = 0; i < adyacentes.Count; i++)
            {
                cola.Enqueue(adyacentes[i]);
                elementos.Add(adyacentes[i]);
            }
            while (cola.Count > 0)
            {
                E elemento1 = cola.Dequeue();
                List<E> elementos2 = DarAdyacencias(elemento1);
                for (int i = 0; i < elementos2.Count; i++)
                {
                    if (!elementos.Contains(elementos2[i]))
                    {
                        cola.Enqueue(elementos2[i]);
                        elementos.Add(elementos2[i]);
                    }
                }
            }

                return elementos;
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
