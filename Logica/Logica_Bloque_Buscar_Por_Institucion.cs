using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Logica_Bloque_Buscar_Por_Institucion
    {
        Bloque_Buscar_Por_Institucion BBPI = new Bloque_Buscar_Por_Institucion();

        public List<Tabla_De_Ejercicios> Logica_Mostrar_Ejercicio_Institucion(int Institucion)
        {
            return BBPI.Mostrar_Ejercicio_Institucion(Institucion).ToList();
        }

        public int? Logica_Contar_Ejercicio_Institucion(int Institucion)
        {
            return BBPI.Contar_Ejercicio_Institucion(Institucion);

        }
    }
}

