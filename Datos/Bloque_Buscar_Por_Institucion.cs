using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Bloque_Buscar_Por_Institucion
    {
        DataClassesDataContext db = new DataClassesDataContext();
        int? Cantidad;

        public List<Tabla_De_Ejercicios> Mostrar_Ejercicio_Institucion(int Institucion)
        {
            return db.Mostrar_Ejercicios_Por_Institucion(Institucion).ToList();
        }

        public int? Contar_Ejercicio_Institucion(int Institucion)
        {
            db.Contar_Ejercicios_Por_Institucion(Institucion, ref Cantidad);
            return Cantidad;
        }
    }
}
