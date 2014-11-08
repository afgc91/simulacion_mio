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




    }
}
