using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DatosAlumnoApp
{
    public class Serializador<T>
    {
        /// <summary>
        /// Guardar el estado de un objeto de tipo T en un archivo
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="elemento">Objeto a guardar</param>
        public void Guardar(string ruta, T elemento)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                bf.Serialize(fs, elemento);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// Carga un objeto de tipo T desde un archivo.
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <returns></returns>
        public T Cargar(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                return (T)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }
    }

}
