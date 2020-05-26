using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica_9
{
    class Archivo
    {
        private string rutaArchivo;

        public Archivo(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public bool GuardarArchivo(Object objeto)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, objeto);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Object LeerArchivo()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read);
                Object objeto = (Object)formatter.Deserialize(fs);
                fs.Close();
                return objeto;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
