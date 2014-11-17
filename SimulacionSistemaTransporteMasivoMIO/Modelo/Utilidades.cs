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
            //String[] troncales = DarCodEstTroncales();
            String[] nomTroncales = DarNombreEstTroncales();
            List<Estacion> estaciones = new List<Estacion>();
            int cont = 0;
            Estacion temp = null;
            for (int a=0; a < nomTroncales.Length; a++ ) {
                temp = new Estacion(cont, nomTroncales[a], 0, 0, 0);
                Parada p=null;
                for (int b = 0; b < paradas.Count; b++ ) {
                    if (paradas[b].LongName.Contains(nomTroncales[a]) && StartEquals(nomTroncales[a], paradas[b].LongName.Trim()) ) {

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

        public static bool GenerarPasajeros(int cantidad, int cantidadEstacion, int duracion, int idEst)
        {
            bool respuesta = true;
            List<String> pasajeros = new List<String>();
            Random a = new Random();
            for (int i = 0; i < cantidad;i++){
                Pasajero pas = new Pasajero(i, (int)(a.Next() * cantidadEstacion), (int)(a.Next() * cantidadEstacion), GetPoisson(duracion));
                pasajeros.Add(pas.ToString());
            }

            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\"+idEst+".txt" , pasajeros);

                return respuesta;
        }


        public static int GetPoisson(double lambda)
        {
            return (lambda < 30.0) ? PoissonSmall(lambda) : PoissonLarge(lambda);
        }


        private static int PoissonSmall(double lambda)
        {
            // Algorithm due to Donald Knuth, 1969.
            double p = 1.0, L = Math.Exp(-lambda);
            int k = 0;
            do
            {
                k++;
                p *= GetUniform();
            }
            while (p > L);
            return k - 1;
        }

        private static int PoissonLarge(double lambda)
        {
            // "Rejection method PA" from "The Computer Generation of 
            // Poisson Random Variables" by A. C. Atkinson,
            // Journal of the Royal Statistical Society Series C 
            // (Applied Statistics) Vol. 28, No. 1. (1979)
            // The article is on pages 29-35. 
            // The algorithm given here is on page 32.

            double c = 0.767 - 3.36 / lambda;
            double beta = Math.PI / Math.Sqrt(3.0 * lambda);
            double alpha = beta * lambda;
            double k = Math.Log(c) - lambda - Math.Log(beta);

            for ( ; ; )
            {
                double u = GetUniform();
                double x = (alpha - Math.Log((1.0 - u) / u)) / beta;
                int n = (int)Math.Floor(x + 0.5);
                if (n < 0)
                    continue;
                double v = GetUniform();
                double y = alpha - beta * x;
                double temp = 1.0 + Math.Exp(y);
                double lhs = y + Math.Log(v / (temp * temp));
                double rhs = k + n * Math.Log(lambda) - LogFactorial(n);
                if (lhs <= rhs)
                    return n;
            }
        }

            private static double LogFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (n > 254)
        {
            double x = n + 1;
            return (x - 0.5)*Math.Log(x) - x + 0.5*Math.Log(2*Math.PI) + 1.0/(12.0*x);
        }
        else
        {
            double[] lf = 
            {
                0.000000000000000,
                0.000000000000000,
                0.693147180559945,
                1.791759469228055,
                3.178053830347946,
                4.787491742782046,
                6.579251212010101,
                8.525161361065415,
                10.604602902745251,
                12.801827480081469,
                15.104412573075516,
                17.502307845873887,
                19.987214495661885,
                22.552163853123421,
                25.191221182738683,
                27.899271383840894,
                30.671860106080675,
                33.505073450136891,
                36.395445208033053,
                39.339884187199495,
                42.335616460753485,
                45.380138898476908,
                48.471181351835227,
                51.606675567764377,
                54.784729398112319,
                58.003605222980518,
                61.261701761002001,
                64.557538627006323,
                67.889743137181526,
                71.257038967168000,
                74.658236348830158,
                78.092223553315307,
                81.557959456115029,
                85.054467017581516,
                88.580827542197682,
                92.136175603687079,
                95.719694542143202,
                99.330612454787428,
                102.968198614513810,
                106.631760260643450,
                110.320639714757390,
                114.034211781461690,
                117.771881399745060,
                121.533081515438640,
                125.317271149356880,
                129.123933639127240,
                132.952575035616290,
                136.802722637326350,
                140.673923648234250,
                144.565743946344900,
                148.477766951773020,
                152.409592584497350,
                156.360836303078800,
                160.331128216630930,
                164.320112263195170,
                168.327445448427650,
                172.352797139162820,
                176.395848406997370,
                180.456291417543780,
                184.533828861449510,
                188.628173423671600,
                192.739047287844900,
                196.866181672889980,
                201.009316399281570,
                205.168199482641200,
                209.342586752536820,
                213.532241494563270,
                217.736934113954250,
                221.956441819130360,
                226.190548323727570,
                230.439043565776930,
                234.701723442818260,
                238.978389561834350,
                243.268849002982730,
                247.572914096186910,
                251.890402209723190,
                256.221135550009480,
                260.564940971863220,
                264.921649798552780,
                269.291097651019810,
                273.673124285693690,
                278.067573440366120,
                282.474292687630400,
                286.893133295426990,
                291.323950094270290,
                295.766601350760600,
                300.220948647014100,
                304.686856765668720,
                309.164193580146900,
                313.652829949878990,
                318.152639620209300,
                322.663499126726210,
                327.185287703775200,
                331.717887196928470,
                336.261181979198450,
                340.815058870798960,
                345.379407062266860,
                349.954118040770250,
                354.539085519440790,
                359.134205369575340,
                363.739375555563470,
                368.354496072404690,
                372.979468885689020,
                377.614197873918670,
                382.258588773060010,
                386.912549123217560,
                391.575988217329610,
                396.248817051791490,
                400.930948278915760,
                405.622296161144900,
                410.322776526937280,
                415.032306728249580,
                419.750805599544780,
                424.478193418257090,
                429.214391866651570,
                433.959323995014870,
                438.712914186121170,
                443.475088120918940,
                448.245772745384610,
                453.024896238496130,
                457.812387981278110,
                462.608178526874890,
                467.412199571608080,
                472.224383926980520,
                477.044665492585580,
                481.872979229887900,
                486.709261136839360,
                491.553448223298010,
                496.405478487217580,
                501.265290891579240,
                506.132825342034830,
                511.008022665236070,
                515.890824587822520,
                520.781173716044240,
                525.679013515995050,
                530.584288294433580,
                535.496943180169520,
                540.416924105997740,
                545.344177791154950,
                550.278651724285620,
                555.220294146894960,
                560.169054037273100,
                565.124881094874350,
                570.087725725134190,
                575.057539024710200,
                580.034272767130800,
                585.017879388839220,
                590.008311975617860,
                595.005524249382010,
                600.009470555327430,
                605.020105849423770,
                610.037385686238740,
                615.061266207084940,
                620.091704128477430,
                625.128656730891070,
                630.172081847810200,
                635.221937855059760,
                640.278183660408100,
                645.340778693435030,
                650.409682895655240,
                655.484856710889060,
                660.566261075873510,
                665.653857411105950,
                670.747607611912710,
                675.847474039736880,
                680.953419513637530,
                686.065407301994010,
                691.183401114410800,
                696.307365093814040,
                701.437263808737160,
                706.573062245787470,
                711.714725802289990,
                716.862220279103440,
                722.015511873601330,
                727.174567172815840,
                732.339353146739310,
                737.509837141777440,
                742.685986874351220,
                747.867770424643370,
                753.055156230484160,
                758.248113081374300,
                763.446610112640200,
                768.650616799717000,
                773.860102952558460,
                779.075038710167410,
                784.295394535245690,
                789.521141208958970,
                794.752249825813460,
                799.988691788643450,
                805.230438803703120,
                810.477462875863580,
                815.729736303910160,
                820.987231675937890,
                826.249921864842800,
                831.517780023906310,
                836.790779582469900,
                842.068894241700490,
                847.352097970438420,
                852.640365001133090,
                857.933669825857460,
                863.231987192405430,
                868.535292100464630,
                873.843559797865740,
                879.156765776907600,
                884.474885770751830,
                889.797895749890240,
                895.125771918679900,
                900.458490711945270,
                905.796028791646340,
                911.138363043611210,
                916.485470574328820,
                921.837328707804890,
                927.193914982476710,
                932.555207148186240,
                937.921183163208070,
                943.291821191335660,
                948.667099599019820,
                954.046996952560450,
                959.431492015349480,
                964.820563745165940,
                970.214191291518320,
                975.612353993036210,
                981.015031374908400,
                986.422203146368590,
                991.833849198223450,
                997.249949600427840,
                1002.670484599700300,
                1008.095434617181700,
                1013.524780246136200,
                1018.958502249690200,
                1024.396581558613400,
                1029.838999269135500,
                1035.285736640801600,
                1040.736775094367400,
                1046.192096209724900,
                1051.651681723869200,
                1057.115513528895000,
                1062.583573670030100,
                1068.055844343701400,
                1073.532307895632800,
                1079.012946818975000,
                1084.497743752465600,
                1089.986681478622400,
                1095.479742921962700,
                1100.976911147256000,
                1106.478169357800900,
                1111.983500893733000,
                1117.492889230361000,
                1123.006317976526100,
                1128.523770872990800,
                1134.045231790853000,
                1139.570684729984800,
                1145.100113817496100,
                1150.633503306223700,
                1156.170837573242400,
            };
            return lf[n];
        }
    }

            private static uint GetUint()
            {
                uint m_z =0;
                uint m_w=0;
                 m_z = 36969 * (m_z & 65535) + (m_z >> 16);
                 m_w = 18000 * (m_w & 65535) + (m_w >> 16);
                return (m_z << 16) + m_w;
            }

            public static double GetUniform()
            {
                // 0 <= u < 2^32
                uint u = GetUint();
                // The magic number below is 1/(2^32 + 2).
                // The result is strictly between 0 and 1.
                return (u + 1.0) * 2.328306435454494e-10;
            }
    
        }

    }

