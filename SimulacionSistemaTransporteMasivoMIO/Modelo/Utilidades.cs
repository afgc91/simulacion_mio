using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;
using Troschuetz.Random;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Utilidades
    {

        private static String[] DarCodEstTroncales()
        {
            String[] estTroncales = { "TMENGA", "A.SANI", "CHIMI", "UDP", "CAPRI", "UNIV", "T.C",
                                    "FLORAI", "SALOM", "POPU", "MZAN", "FATI", "RIOC", "TORRE", "PILOT", "SANIC",
                                    "ERMI", "CAICED", "CENTRO", "STROSA", "FRAY", "SANBO", "7AGO", "TREB", "VICOL",
                                    "CHAPI", "ATGI", "FLORE", "BELAL", "SANPAS", "SUCRE", "PTCUY", "SANPED", "SNTLIB",
                                    "MANZA", "ESTAD", "TEQUE", "LIDO", "PLATOR", "PAMPA", "REFUG", "CALDAS", "MELEN", "BUITRE",
                                    "UNIVAL", "VERSALL", "L.AMERI", "PRADNOR", "VIPASA", "ALAMOS", "N.LATIR", "AMANECE", "CONQUIS", "TRONCAL",
                                    "VLNUEVA", "ST.MONI", "PRIMITI", "C.PALOS"};

            return estTroncales;
        }

        private static String[] DarNombreEstTroncales()
        {
            String[] nombreEstTroncales = { "Terminal Menga", "Terminal Andres Sanin", "Chiminangos", "Unidad Deportiva", "Capri", "Universidades", "T.Canaveralejo",
                                    "Flora Industrial", "Salomia", "Popular", "Manzanares", "Fatima", "Rio Cali", "Torre de Cali", "Piloto", "San Nicolas",
                                    "La Ermita", "Plaza de Caicedo", "Centro", "Santa Rosa", "Fray Damian", "San Bosco", "7 de Agosto", "Trebol", "Villa Colombia",
                                    "Chapinero", "Atanasio Girardot", "Floresta", "Belalcazar", "San Pascual", "Sucre", "Petecuy", "San Pedro", "Santa Librada",
                                    "Manzana del Saber", "Estadio", "Tequendama", "Lido", "Plaza de Toros", "Pampalinda", "Refugio", "Caldas", "Melendez", "Buitrera",
                                    "Univalle", "Versalles", "Las Americas", "Prados del Norte", "Vipasa", "Alamos", "Nuevo Latir", "Amanecer", "Conquistadores", "Troncal Unida",
                                    "Villa Nueva", "Santa Monica", "Primitivo", "Cien Palos"};
            return nombreEstTroncales;
        }

        /// <summary>
        /// Permite agrupar aquellas paradas que se ecuentran en una misma estación.
        /// Precondición: Las paradas existen.
        /// Precondición: Las estaciones existen.
        /// </summary>
        /// <param name="paradas"></param>
        /// <param name="sim"></param>
        /// <returns></returns>
        public static List<Estacion> AgruparParadas(List<Stop> paradas, Simulacion sim)
        {
            //String[] troncales = DarCodEstTroncales();
            String[] nomTroncales = DarNombreEstTroncales();
            List<Estacion> estaciones = new List<Estacion>();
            int cont = 0;
            Estacion temp = null;
            for (int a = 0; a < nomTroncales.Length; a++)
            {
                temp = new Estacion(cont, nomTroncales[a], 0, 0, 0, sim);
                Parada p = null;
                for (int b = 0; b < paradas.Count; b++)
                {
                    if (paradas[b].LongName.Contains(nomTroncales[a]) && StartEquals(nomTroncales[a], paradas[b].LongName.Trim()))
                    {
                        p = new Parada(paradas[b].StopId, paradas[b].LongName, paradas[b].DecimalLatitude, paradas[b].DecimalLongitude);
                        temp.AgregarParada(p);
                    }
                }
                temp.SetLatitud(p.Latitud);
                temp.SetLongitud(p.Longitud);
                estaciones.Add(temp);
                cont += 1;
            }

            for (int i = 0; i < paradas.Count; i++)
            {
                if (!IsInList(paradas[i].ShortName, nomTroncales))
                {
                    temp = new Estacion(cont, paradas[i].LongName, paradas[i].DecimalLatitude, paradas[i].DecimalLongitude, 0, sim);
                    Parada p = new Parada(paradas[i].StopId, paradas[i].LongName, paradas[i].DecimalLatitude, paradas[i].DecimalLongitude);
                    temp.AgregarParada(p);
                    estaciones.Add(temp);
                    cont += 1;
                }
            }
            Console.WriteLine("Cantidad de estaciones: " + estaciones.Count);
            return estaciones;
        }

        private static bool IsInList(String cadena, String[] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                if (cadena.Contains(array[a]) && StartEquals(array[a], cadena))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Permite verificar si la cadena 'cadena' empieza con la subcadena 'original'.
        /// Precondición: cadena contiene a original.
        /// </summary>
        /// <param name="original"></param>
        /// <param name="cadena"></param>
        /// <returns></returns>
        private static bool StartEquals(String original, String cadena)
        {
            for (int a = 0; a < original.Length; a++)
            {
                if (!original.ElementAt(a).Equals(cadena.ElementAt(a)))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Permite generar los pasajeros que llegan a cada una de las estaciones haciendo uso de distribución de Poisson.
        /// Postcondición: se crea lista de eventos futuros de pasajeros.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="duracion"></param>
        /// <param name="estaciones"></param>
        /// <param name="idEstIn"></param>
        /// <returns name="respuesta"></returns>
        public static bool GenerarPasajeros(int cantidad, int duracion, Estacion[] estaciones, int idEstIn)
        {
            bool respuesta = true;
            List<Pasajero> pasajeros = new List<Pasajero>();
            Random a = new Random();
            Random b = new Random();
            int baseSim = 0;
            for (int i = 0; i < cantidad; i++)
            {
                int tiemp = (int)Proximo(0.3, b);
                baseSim = baseSim + tiemp;
                if (baseSim > 1080)
                {
                    baseSim = 0;
                }
                Pasajero pas = new Pasajero(i, estaciones[idEstIn].GetId(), estaciones[(int)(a.Next(estaciones.Length))].GetId(), baseSim);

                pasajeros.Add(pas);
            }
            pasajeros.Sort();
            List<string> pasajeros1 = new List<string>();
            for (int i = 0; i < pasajeros.Count; i++)
            {
                pasajeros1.Add(pasajeros[i].ToString());
            }

            System.IO.File.WriteAllLines(@"..\\..\\Almacenamiento\Pasajeros\estacion" + idEstIn + ".txt", pasajeros1);


            return respuesta;
        }

        /// <summary>
        /// Permite generar el tiempo que se demora en ocurrir un proximo evento segun una distribucion de Poisson.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="a"></param>
        /// <returns double></returns>
        private static double Proximo(double rate, Random a)
        {
            double num = a.NextDouble();
            //Console.WriteLine(num);
            return (Math.Log(1.0 - num)) / -rate;
        }

        public static List<Ruta> GenerarRutas(List<LineStop> paradas, List<Line> ruts, GrafoMatriz<Estacion> est)
        {
            List<Ruta> rutas = new List<Ruta>();
            Estacion[] esta = est.DarVertices();

            return rutas;
        }


    }

}

