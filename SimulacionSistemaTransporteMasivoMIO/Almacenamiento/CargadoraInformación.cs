using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class CargadoraInformación
    {
        /// <summary>
        /// Instancias cuyo archivo será cargado.
        /// </summary>
        public String Instance;

        public CargadoraInformación(String ins) {
            Instance = ins;
            Console.WriteLine("");
        }

        public List<String> CargarArchivo(String fileName) {
            //FileInfo file = (from f in new DirectoryInfo(@"C:\").GetFiles()
            //           where f.Name.Equals(fileName)
            //           select f).First();

            List<String> list = new List<String>();
            StreamReader reader = new StreamReader(@"C:\Users\Public\Base de datos MIO\"+fileName);
            String line = "";
            int cont = 0;
            while (true) {
                line = reader.ReadLine();
                //Console.WriteLine(line);
                cont += 1;
                if (line==null)
                {
                    //Console.WriteLine("No hay más líneas");
                    break;
                }
                list.Add(line);
            }
            Console.WriteLine("Cantidad líneas: " + cont);
            return list; 
        }
    }
}
