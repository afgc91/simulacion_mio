using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Utilidades
    {
        public static List<Estacion> Agrupar(List<Stop> paradas)
        {
            int contador = 0;

            List<Estacion> estaciones = new List<Estacion>();
            List<int> bloqueados = new List<int>();
            for (int i = 0; i < paradas.Count; i++ )
            {
                if (!bloqueados.Contains(i))
                {
                    Stop s = paradas[i];
                    String[] name = s.LongName.Trim().Split(' '); 
                    String nombre = "";
                    if (name[0].Length > 2)
                    {
                        if (name.Count() == 1)
                        {
                            nombre = name[0];
                        }
                        else if (name.Count() == 2)
                        {
                            nombre = name[0];
                        }
                        else if (name.Count() == 3)
                        {
                            nombre = name[0] + " " + name[1];
                        }
                        else if (name.Count() == 4)
                        {
                            nombre = name[0] + " " + name[1] + " " + name[2];
                        }

                    }
                    else
                    {
                        nombre = s.LongName;
                    }
                    
                    Estacion est = new Estacion(contador, nombre, s.DecimalLatitude, s.DecimalLongitude, 5);
                    est.AgregarParada(new Parada(s.StopId, s.LongName, s.DecimalLatitude, s.DecimalLongitude));
                    bloqueados.Add(i);
                    if (name[0].Length > 2)
                    {


                        for (int j = 0; j < paradas.Count; j++)
                        {
                            if (!bloqueados.Contains(j))
                            {
                                Stop s1 = paradas[j];
                                String[] name1 = s1.LongName.Trim().Split(' ');
                                String b = "";
                                if (name1.Count() == 1)
                                {
                                    b = name1[0];
                                }
                                else if (name1.Count() == 2)
                                {
                                    b = name1[0];
                                }
                                else if (name1.Count() == 3)
                                {
                                    b = name1[0] + " " + name1[1];
                                }
                                else if (name1.Count() == 4)
                                {
                                    b = name1[0] + " " + name1[1] + " " + name1[2];
                                }

                                if (s.LongName.Contains(b) && i != j)
                                {

                                    est.AgregarParada(new Parada(s1.StopId, name1[name1.Count()-1], s1.DecimalLatitude, s1.DecimalLongitude));
                                  
                                    bloqueados.Add(j);
                                }


                            }
                        }
                    }
                    estaciones.Add(est);
                }
            }     
            return estaciones;
        }

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

        private static String[] DarNombreEstTroncales() {
            String[] nombreEstTroncales = { "Terminal Menga", "Terminal Andres Sanin", "Chiminangos", "Unidad Deportiva", "Capri", "Universidades", "T.Canaveralejo",
                                    "Flora Industrial", "Salomia", "Popular", "Manzanares", "Fatima", "Rio Cali", "Torre de Cali", "Piloto", "San Nicolas",
                                    "La Ermita", "Plaza de Caicedo", "Centro", "Santa Rosa", "Fray Damian", "San Bosco", "7 de Agosto", "Trebol", "Villa Colombia",
                                    "Chapinero", "Atanasio Girardot", "Floresta", "Belalcazar", "San Pascual", "Sucre", "Petecuy", "San Pedro", "Santa Librada",
                                    "Manzana del Saber", "Estadio", "Tequendama", "Lido", "Plaza de Toros", "Pampalinda", "Refugio", "Caldas", "Melendez", "Buitrera",
                                    "Univalle", "Versalles", "Las Americas", "Prados del Norte", "Vipasa", "Alamos", "Nuevo Latir", "Amanecer", "Conquistadores", "Troncal Unida",
                                    "Villa Nueva", "Santa Monica", "Primitivo", "Cien Palos"};
            return nombreEstTroncales;
        }

        public static List<Estacion> AgruparParadas(List<Stop> paradas) {
            String[] troncales = DarCodEstTroncales();
            String[] nomTroncales = DarNombreEstTroncales();
            List<Estacion> estaciones = new List<Estacion>();
            int cont = 0;
            Estacion temp = null;
            for (int a=0; a < troncales.Length; a++ ) {
                temp = new Estacion(cont, nomTroncales[a], 0, 0, 0);
                Parada p=null;
                for (int b = 0; b < paradas.Count; b++ ) {
                    if (paradas[b].ShortName.Contains(troncales[a])&&StartEquals(troncales[a], paradas[b].ShortName)) {
                        p = new Parada(paradas[b].StopId, paradas[b].LongName, paradas[b].DecimalLatitude, paradas[b].DecimalLongitude);
                        temp.AgregarParada(p);
                    }
                }
                temp.SetLatitud(p.Latitud);
                temp.SetLongitud(p.Longitud);
                estaciones.Add(temp);
                cont += 1;
            }

            for (int i = 0; i < paradas.Count; i++ ) {
                if(!IsInList(paradas[i].ShortName, troncales)){
                    temp = new Estacion(cont, paradas[i].LongName, paradas[i].DecimalLatitude, paradas[i].DecimalLongitude, 0);
                    Parada p = new Parada(paradas[i].StopId, paradas[i].LongName, paradas[i].DecimalLatitude, paradas[i].DecimalLongitude);
                    temp.AgregarParada(p);
                    estaciones.Add(temp);
                    cont += 1;
                }
            }
            Console.WriteLine("Cantidad de estaciones: " + estaciones.Count);
            return estaciones;
        }

        private static bool IsInList(String cadena, String[] array) {
            for (int a = 0; a < array.Length; a++ ) {
                if (cadena.Contains(array[a])&&StartEquals(array[a], cadena)) {
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
        private static bool StartEquals(String original, String cadena) {
            for (int a = 0; a < original.Length; a++ ) {
                if (!original.ElementAt(a).Equals(cadena.ElementAt(a))) {
                    return false;
                }
            }
            return true;
        }

    }
}
