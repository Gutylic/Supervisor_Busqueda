using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Logica_Bloque_Buscar_Por_Ficha   
    {
        Bloque_Buscar_Por_Ficha BBPF = new Bloque_Buscar_Por_Ficha();

        public List<Tabla_De_Ejercicios> Logica_Mostrar_Ejercicios_Ficha_Completa(string Profesor, string Ano, string Colegio, string Materia, string Tema)
        {
            return BBPF.Mostrar_Ejercicios_Ficha_Completa(Profesor, Ano, Colegio, Materia, Tema).ToList();
        }
        
        public int? Logica_Contar_Ejercicios_Ficha_Completa(string Profesor, string Ano, string Colegio, string Materia, string Tema)
        {
            return BBPF.Contar_Ejercicios_Ficha_Completa(Profesor, Ano, Colegio, Materia, Tema);

        }

        public string Corregir_Datos_Ingresados_Para_La_Ficha(string Texto) // metodo para corregir la busqueda del cliente
        {
            string Linea = Texto.ToLower().Trim();
            Linea = Linea.Replace("á", "a");
            Linea = Linea.Replace("é;", "e");
            Linea = Linea.Replace("í;", "i");
            Linea = Linea.Replace("ó", "o");
            Linea = Linea.Replace("ú", "u");
            Linea = Linea.Replace(" ", "");
            Linea = Linea.Replace("Á;", "a");
            Linea = Linea.Replace("É", "e");
            Linea = Linea.Replace("Í", "i");
            Linea = Linea.Replace("Ó", "o");
            Linea = Linea.Replace("Ú", "u");
            Linea = Linea.Replace("ñ", "n");
            Linea = Linea.Replace("Ñ", "n");
            Linea = Linea.Replace("º", "");
            Linea = Linea.Trim(); // elimino los espacios delante y detras de la variable creada
            return Linea; // variable final limpia de wiris

        }

        public int Todos_Los_Datos_Vacios_En_La_Busqueda(string Profesor, string Ano, string Colegio, string Materia, string Tema) // enviando los datos recogidos en el panel de busqueda me dice si se lleno o esta vacio
        {
            if (Profesor == string.Empty && Ano == string.Empty && Colegio == string.Empty && Materia == string.Empty && Tema == string.Empty) //vacio
            {
                return 0;
            }
            return 1; // lleno
        }


        public string Logica_Buscar_Profesor(string Profesor) // buscar las etiquetas que determinan al profesor
        {
            if (Profesor == null) { Profesor = string.Empty; }
            return BBPF.Buscar_Profesor(Corregir_Datos_Ingresados_Para_La_Ficha(Profesor));
        }

        public string Logica_Buscar_Ano(string Ano) // buscar las etiquetas que determinan al ano
        {
            if (Ano == null) { Ano = string.Empty; }
            return BBPF.Buscar_Ano(Corregir_Datos_Ingresados_Para_La_Ficha(Ano));
        }

        public string Logica_Buscar_Tema(string Tema) // buscar las etiquetas que determinan el tema
        {
            if (Tema == null) { Tema = string.Empty; }
            return BBPF.Buscar_Tema(Corregir_Datos_Ingresados_Para_La_Ficha(Tema));
        }

        public string Logica_Buscar_Colegio(string Colegio) // buscar las etiquetas que determinan el colegio
        {
            if (Colegio == null) { Colegio = string.Empty; }
            return BBPF.Buscar_Colegio(Corregir_Datos_Ingresados_Para_La_Ficha(Colegio));
        }

        public string Logica_Buscar_Materia(string Materia) // buscar las etiquetas que determinan la materia
        {
            if (Materia == null) { Materia = string.Empty; }
            return BBPF.Buscar_Materia(Corregir_Datos_Ingresados_Para_La_Ficha(Materia));
        }


    }
}


    