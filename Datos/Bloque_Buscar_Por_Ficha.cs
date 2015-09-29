using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Bloque_Buscar_Por_Ficha
    {

        DataClassesDataContext db = new DataClassesDataContext();
        int? Cantidad;
        string Etiqueta_Armada;

        public List<Tabla_De_Ejercicios> Mostrar_Ejercicios_Ficha_Completa(string Profesor, string Ano, string Colegio, string Materia, string Tema)
        {
            return db.Mostrar_Ejercicios_Por_Ficha_Completa(Profesor, Ano, Colegio, Materia, Tema).ToList();
        }


        public int? Contar_Ejercicios_Ficha_Completa(string Profesor, string Ano, string Colegio, string Materia, string Tema)
        {
            db.Contar_Ejercicios_Por_Ficha_Completa(Profesor, Ano, Colegio, Materia, Tema, ref Cantidad);
            return Cantidad;
        }


        public string Buscar_Profesor(string Dato) // vamos a formar la etiqueta de consulta para el profesor
        {
            Etiqueta_Armada = string.Empty;
            if (Dato == string.Empty) // dato llega vacio 
            {
                return "\"p*\"";  // devuelve la cadena string con un comodin especial para constains
            }
            IEnumerable<Tabla_De_Profesores> Etiqueta_Tabla_Profesor = (db.Buscar_En_Tabla_Profesores(Dato).ToList());  // busca en la tabla profesores y me devuelve una lista              
            foreach (Tabla_De_Profesores s in Etiqueta_Tabla_Profesor) // paso la lista a una variable string
            {
                Etiqueta_Armada = Etiqueta_Armada + "p" + s.Etiqueta_Profesor + " or "; //separo cada componente de la lista con un or especial para la busqueda constains
            }
            if (Etiqueta_Armada == string.Empty)
            {
                Etiqueta_Armada = "p0";
            }
            else
            {
                Etiqueta_Armada = Etiqueta_Armada.Trim().Substring(0, Etiqueta_Armada.Length - 3);
            }

            return Etiqueta_Armada; // agregar la etiqueta cero que es la etiqueta por defecto
        }

        public string Buscar_Materia(string Dato) // vamos a formar la etiqueta de consulta para el materia
        {
            Etiqueta_Armada = string.Empty;
            if (Dato == string.Empty) // dato llega vacio
            {
                return "\"m*\"";// devuelve la cadena string con un comodin especial para constains
            }
            IEnumerable<Tabla_De_Materias> Etiqueta_Tabla_Materia = (db.Buscar_En_Tabla_Materias(Dato).ToList());// busca en la tabla materias y me devuelve una lista    
            foreach (Tabla_De_Materias s in Etiqueta_Tabla_Materia) // paso la lista a una variable string
            {
                Etiqueta_Armada = Etiqueta_Armada + "m" + s.Etiqueta_Materia + " or ";//separo cada componente de la lista con un or especial para la busqueda constains
            }
            if (Etiqueta_Armada == string.Empty)
            {
                Etiqueta_Armada = "m0";
            }
            else
            {
                Etiqueta_Armada = Etiqueta_Armada.Trim().Substring(0, Etiqueta_Armada.Length - 3);
            }

            return Etiqueta_Armada;// agregar la etiqueta cero que es la etiqueta por defecto
        }

        public string Buscar_Tema(string Dato) // etiqueta la consulta
        {
            Etiqueta_Armada = string.Empty;
            if (Dato == string.Empty) // dato llega vacio
            {
                return "\"t*\"";// devuelve la cadena string con un comodin especial para constains
            }
            IEnumerable<Tabla_De_Temas> Etiqueta_Tabla_Tema = (db.Buscar_En_Tabla_Temas(Dato).ToList());// busca en la tabla temas y me devuelve una lista                 
            foreach (Tabla_De_Temas s in Etiqueta_Tabla_Tema)  // paso la lista a una variable string 
            {
                Etiqueta_Armada = Etiqueta_Armada + "t" + s.Etiqueta_Tema + " or ";//separo cada componente de la lista con un or especial para la busqueda constains
            }
            if (Etiqueta_Armada == string.Empty)
            {
                Etiqueta_Armada = "t0";
            }
            else
            {
                Etiqueta_Armada = Etiqueta_Armada.Trim().Substring(0, Etiqueta_Armada.Length - 3);
            }

            return Etiqueta_Armada;// agregar la etiqueta cero que es la etiqueta por defecto

        }

        public string Buscar_Ano(string Dato) // etiqueta la consulta
        {
            Etiqueta_Armada = string.Empty;
            if (Dato == string.Empty) // dato llega vacio
            {
                return "\"a*\"";// devuelve la cadena string con un comodin especial para constains
            }
            IEnumerable<Tabla_De_Anos> Etiqueta_Tabla_Ano = (db.Buscar_En_Tabla_Anos(Dato).ToList());// busca en la tabla Años y me devuelve una lista  
            foreach (Tabla_De_Anos s in Etiqueta_Tabla_Ano) // paso la lista a una variable string  
            {
                Etiqueta_Armada = Etiqueta_Armada + "a" + s.Etiqueta_Ano + " or ";//separo cada componente de la lista con un or especial para la busqueda constains
            }

            if (Etiqueta_Armada == string.Empty)
            {
                Etiqueta_Armada = "a0";
            }
            else
            {
                Etiqueta_Armada = Etiqueta_Armada.Trim().Substring(0, Etiqueta_Armada.Length - 3);
            }
            

            return Etiqueta_Armada;// agregar la etiqueta cero que es la etiqueta por defecto
        }

        public string Buscar_Colegio(string Dato) // etiqueta la consulta
        {
            Etiqueta_Armada = string.Empty;
            if (Dato == string.Empty) // dato llega vacio
            {
                return "\"c*\"";// devuelve la cadena string con un comodin especial para constains
            }
            IEnumerable<Tabla_De_Colegios> Etiqueta_Tabla_Colegio = (db.Buscar_En_Tabla_Colegios(Dato).ToList());// busca en la tabla Colegio y me devuelve una lista  
            foreach (Tabla_De_Colegios s in Etiqueta_Tabla_Colegio) // paso la lista a una variable string 
            {
                Etiqueta_Armada = Etiqueta_Armada + "c" + s.Etiqueta_Colegio + " or ";//separo cada componente de la lista con un or especial para la busqueda constains
            }
            if (Etiqueta_Armada == string.Empty)
            {
                Etiqueta_Armada = "c0";
            }
            else
            {
                Etiqueta_Armada = Etiqueta_Armada.Trim().Substring(0, Etiqueta_Armada.Length - 3);
            }

            return Etiqueta_Armada;// agregar la etiqueta cero que es la etiqueta por defecto
        }

    }
}
