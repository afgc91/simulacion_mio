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

            for (int i = 0; i < paradas.Count; i++ )
            {
                Stop s = paradas[i];
                String[] name = s.LongName.Trim().Split(' ');
                Estacion est = new Estacion(contador, s.LongName, s.DecimalLatitude, s.DecimalLongitude, 5);
                est.Paradas.Add(new Parada(s.StopId, s.LongName, s.DecimalLatitude, s.DecimalLongitude));
               
                if (name[0].Length > 2)
                {
                    Console.WriteLine(name[0]);

                    for (int j = i + 1; j < paradas.Count; j++)
                    {
                        Stop s1 = paradas[j];
                        String[] name1 = s1.LongName.Split(' ');
                        String b = "";
                        if (name1.Count() == 1)
                        {
                            b = name1[0];
                        }else
                        if (name1.Count() == 2)
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
                        
                        if (s.LongName.Contains(b))
                        {
                            est.Paradas.Add(new Parada(s1.StopId, s1.LongName, s1.DecimalLatitude, s1.DecimalLongitude));
                        }
                        else
                        {
                            i = j;
                            j = paradas.Count;
                        }
                    }
                }
                    estaciones.Add(est);
            }
            return estaciones;
        }




    }
}
