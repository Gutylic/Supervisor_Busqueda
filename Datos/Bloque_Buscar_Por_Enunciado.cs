using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Bloque_Buscar_Por_Enunciado
    {
        DataClassesDataContext db = new DataClassesDataContext();
        int? Cantidad;

        public List<Tabla_MATH_De_Ejercicios> Mostrar_Ejercicios_Porcentaje(string Enunciado_1, string Enunciado_2)
        {
            return db.Mostrar_Ejercicios_Por_Porcentaje_Del_Enunciado(Enunciado_1, Enunciado_2).ToList();
        }

        public List<Tabla_MATH_De_Ejercicios> Mostrar_Ejercicios_Profundidad(string Enunciado)
        {
            return db.Mostrar_Ejercicios_Por_Profundidad_Del_Enunciado(Enunciado).ToList();
        }

        public List<Vista_Buscar_Ejercicios> Mostrar_Ejercicios_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            return db.Mostrar_Ejercicios_Por_Palabras_Claves_Del_Enunciado(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10).ToList();
        }

        public int? Contar_Ejercicios_Porcentaje(string Enunciado_1, string Enunciado_2)
        {
            db.Contar_Ejercicios_Por_Porcentaje_Del_Enunciado(Enunciado_1, Enunciado_2, ref Cantidad);
            return Cantidad;
        }

        public int? Contar_Ejercicios_Profundidad(string Enunciado)
        {
            db.Contar_Ejercicios_Por_Profundidad_Del_Enunciado(Enunciado, ref Cantidad);
            return Cantidad;
        }

        public int? Contar_Ejercicios_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            db.Contar_Ejercicios_Por_Palabras_Claves_Del_Enunciado(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10, ref Cantidad);
            return Cantidad;
        }
        
        public List<Vista_Buscar_Videos> Mostrar_Videos_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            return db.Mostrar_Videos_Por_Palabras_Claves_Del_Enunciado(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10).ToList();
        }

        public int? Contar_Videos_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            db.Contar_Videos_Por_Palabras_Claves_Del_Enunciado(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10, ref Cantidad);
            return Cantidad;
        }
    }
}

