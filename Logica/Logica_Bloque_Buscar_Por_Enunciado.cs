using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Logica_Bloque_Buscar_Por_Enunciado
    {
        Bloque_Buscar_Por_Enunciado BBPE = new Bloque_Buscar_Por_Enunciado();

        public List<Tabla_MATH_De_Ejercicios> Logica_Mostrar_Ejercicios_Porcentaje(string Enunciado_1, string Enunciado_2)
        {
            return BBPE.Mostrar_Ejercicios_Porcentaje(Enunciado_1, Enunciado_2).ToList();
        }

        public List<Tabla_MATH_De_Ejercicios> Logica_Mostrar_Ejercicios_Profundidad(string Enunciado)
        {
            return BBPE.Mostrar_Ejercicios_Profundidad(Enunciado).ToList();
        }

        public List<Vista_Buscar_Ejercicios> Logica_Mostrar_Ejercicios_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            return BBPE.Mostrar_Ejercicios_Clave(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10).ToList();
        }

        public List<Vista_Buscar_Videos> Logica_Mostrar_Videos_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            return BBPE.Mostrar_Videos_Clave(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10).ToList();
        }

        public class Dos_Datos_String_Para_Enunciado_Por_Porcentaje // clase extra utilizada para que alguna clase me devuelva dos valores
        {
            public string Valor_1 { get; set; }
            public string Valor_2 { get; set; }
        }

        public Dos_Datos_String_Para_Enunciado_Por_Porcentaje Logica_Por_Porcentaje(string Enunciado)
        {
            Dos_Datos_String_Para_Enunciado_Por_Porcentaje Datos = new Dos_Datos_String_Para_Enunciado_Por_Porcentaje();
            string[] Palabras = Enunciado.Split(' ');
            int Cantidad_De_Palabras = Enunciado.Split(' ').Length + 1;
            int Resultado = (Cantidad_De_Palabras * 25) / 100;

            string Enunciado_1 = string.Empty;
            string Enunciado_2 = string.Empty;

            if (Palabras.Length == 3)
            {
                Datos.Valor_1 = "\"" + Palabras[0] + "\"";  // Variable 1
                Datos.Valor_2 = "\"" + Palabras[2] + "\"";  // Variable 2          
                return Datos;
            }
            if (Palabras.Length <= 2)
            {
                Datos.Valor_1 = null;
                return Datos;
            }


            for (int I = 0; I < Resultado; I++)
            {
                Enunciado_1 = Enunciado_1 + " " + Palabras[I];
                Enunciado_2 = Enunciado_2 + " " + Palabras[(2 * Resultado) + I];
            }

            Enunciado_1 = Enunciado_1.Trim();
            Enunciado_2 = Enunciado_2.Trim();

            Datos.Valor_1 = "\"" + Enunciado_1 + "\"";  // Variable 1
            Datos.Valor_2 = "\"" + Enunciado_2 + "\"";  // Variable 2          
            return Datos;
        }

        public int? Logica_Contar_Ejercicios_Profundidad(string Enunciado)
        {
            return BBPE.Contar_Ejercicios_Profundidad(Enunciado);
        }


        public int? Logica_Contar_Ejercicios_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            return BBPE.Contar_Ejercicios_Clave(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10);

        }

        public int? Logica_Contar_Videos_Clave(string Var_1, string Var_2, string Var_3, string Var_4, string Var_5, string Var_6, string Var_7, string Var_8, string Var_9, string Var_10)
        {
            return BBPE.Contar_Videos_Clave(Var_1, Var_2, Var_3, Var_4, Var_5, Var_6, Var_7, Var_8, Var_9, Var_10);

        }

        public string Correcion_Enunciado_MATH(string Enunciado)
        {
            Enunciado = Enunciado.Remove(0, 49); // quitar los cararcteres de adelante
            Enunciado = Enunciado.Remove(Enunciado.Length - 7, 7).ToLower(); // sacar los de atras y poner en minusculas
            Enunciado = Enunciado.Replace("&#225;", "a");
            Enunciado = Enunciado.Replace("&#233;", "e");
            Enunciado = Enunciado.Replace("&#237;", "i");
            Enunciado = Enunciado.Replace("&#243;", "o");
            Enunciado = Enunciado.Replace("&#250;", "u");
            Enunciado = Enunciado.Replace("&#241;", "n");
            Enunciado = Enunciado.Replace("&#193;", "a");
            Enunciado = Enunciado.Replace("&#201;", "e");
            Enunciado = Enunciado.Replace("&#205;", "i");
            Enunciado = Enunciado.Replace("&#211;", "o");
            Enunciado = Enunciado.Replace("&#218;", "u");
            return Enunciado = Enunciado.Replace("&#209;", "n");
        }

        public string Logica_Buscar_Por_Profundidad(string Enunciado, int Profundidad)
        {
            string Resultado = Correcion_Enunciado_MATH(Enunciado);
            string Respuesta = Resultado.Substring(0, Profundidad);
            return Respuesta;
        }

        public int? Logica_Contar_Ejercicios_Porcentaje(string Enunciado_1, string Enunciado_2)
        {
            return BBPE.Contar_Ejercicios_Porcentaje(Enunciado_1, Enunciado_2);
        }


        public string Correccion_Profesor_Limpio(string Enunciado)
        {
            string Linea = "";
            // quitare todos los caracteres que genera wiris para que el codigo quede limpio y sin espacio
            string[] Terminos_Borrados = new string[] { "<msubsup>", "<mmultiscripts>", "<presubsup>", "</presubsup>", "<mprescripts/>", "<none/>", "</mmultiscripts>", "</msubsup>", "<mo largeop=\"true\">", "<mrow/>", "<munder>", "</munder>", "<munderover>", "</munderover>", "<mover>", "</mover>", "<menclose notation=\"updiagonalstrike\">", "</menclose>", "<mfenced open=\"|\" close=\"|\">", "</mfenced>", "<mi mathvariant=\"normal\">", "<mfrac>", "</mfrac>", "<msup>", "</msup>", "<msub>", "</msub>", "<mrow>", "</mrow>", "<msqrt>", "</msqrt>", "<mroot>", "</mroot>", "<mi>", "</mi>", "<mn>", "</mn>", "<mo>", "</mo>", "<mspace linebreak=\"newline\"/>", "&#8201;", "</math>", "<math xmlns=\"http://www.w3.org/1998/Math/MathML\">", "<maction actiontype=\"argument\">", "</maction>", "<mstyle displaystyle=\"true\">", "</mstyle>", "<mfenced open=\"||\" close=\"||\">", "<menclose notation=\"circle\">", "<menclose notation=\"actuarial\">", "<menclose notation=\"roundedbox\">", "<menclose notation=\"roundedbox\"/>", "<menclose notation=\"top\">", "<menclose notation=\"left\">", "<menclose notation=\"box\"/>", "<menclose notation=\"right\">", "<menclose notation=\"bottom\"/>", "<mfenced open=\"&#8970;\" close=\"&#8971;\">", "<mfenced open=\"&lt;\" close=\"&#62;\" separators=\"|\">", "<mfenced open=\"&#8968;\" close=\"&#8969;\">", "<menclose notation=\"top\"/>", "<menclose notation=\"left\"/>", "<menclose notation=\"right\"/>", "<menclose notation=\"circle\"/>", "<menclose notation=\"actuarial\"/>", "<menclose notation=\"bottom\">", "<menclose notation=\"box\">", "<menclose notation=\"downdiagonalstrike\">", "<menclose notation=\"downdiagonalstrike updiagonalstrike\">", "<menclose notation=\"horizontalstrike\">", "<menclose notation=\"verticalstrike\">", "<menclose>", "<menclose notation=\"verticalstrike horizontalstrike\">", "<menclose notation=\"horizontalstrike\">", "<menclose notation=\"downdiagonalstrike\"/>", "<menclose notation=\"downdiagonalstrike updiagonalstrike\"/>", "<menclose notation=\"verticalstrike\"/>", "<menclose>", "<menclose notation=\"verticalstrike horizontalstrike\"/>", "<menclose/>", "<mtable>", "<mtr>", "<mtd/>", "</mtr>", "</mtable>", "<mtd>", "</mtd>", "<mfenced open=\"[\" close=\"]\">", "<mfenced>", "<mfenced open=\"[\" close=\"]\">", "<mfenced open=\"[\" close=\"]\">", "<mfenced open=\"{\" close=\"\">", "<mtable columnalign=\"left\">", "<mfenced open=\"\" close=\"}\">" };
            string[] Enunciado_Limpio = Enunciado.Split(Terminos_Borrados, StringSplitOptions.RemoveEmptyEntries);
            foreach (string Caracter in Enunciado_Limpio) // genero una variable nueva ya corregida si los caracteres raros de wiris
            {
                Linea = Linea + Caracter;
            }
            // pongo todos los terminos en minusculas y saco los acentos
            Linea = Linea.ToLower();
            Linea = Linea.Replace("&#225;", "a");
            Linea = Linea.Replace("&#233;", "e");
            Linea = Linea.Replace("&#237;", "i");
            Linea = Linea.Replace("&#243;", "o");
            Linea = Linea.Replace("&#250;", "u");
            Linea = Linea.Replace("&#160;", " ");
            Linea = Linea.Replace("&#193;", "a");
            Linea = Linea.Replace("&#201;", "e");
            Linea = Linea.Replace("&#205;", "i");
            Linea = Linea.Replace("&#211;", "o");
            Linea = Linea.Replace("&#218;", "u");
            Linea = Linea.Replace("&#209;", "n");
            Linea = Linea.Trim(); // elimino los espacios delante y detras de la variable creada
            return Linea; // variable final limpia de wiris

        }

        public Dos_Datos_String_Para_Enunciado_Por_Porcentaje Logica_Por_Porcentaje(string Enunciado, int Porcentaje)
        {
            Dos_Datos_String_Para_Enunciado_Por_Porcentaje Datos = new Dos_Datos_String_Para_Enunciado_Por_Porcentaje();
            Enunciado = Correccion_Profesor_Limpio(Enunciado);
            int Cantidad = Enunciado.Split(' ').Length; // cuento la cantidad de espacios en blanco para determinar la cantidad de palabras que tiene el enunciado
            Cantidad = (Cantidad * Porcentaje) / 100; // cuento cuantos caracteres tiene la nueva variable
            int J = 0; // variable que contara la cantidad de caracteres que hay hasta el momento
            int I = 0; // variable que mira que espacio fue utilizado
            int L = 0; // solo permite 3 espacios
            int[] Valor = new int[3]; // variable valor da la ubicacion que quiero al 25%
            foreach (char S in Enunciado) // lee variable por variable el enunciado 
            {
                J = J + 1;
                if (S == ' ')
                {
                    I = I + 1; // cuenta la posicion del caracter
                    if (I == Cantidad * (L + 1))
                    {
                        Valor[L] = J;
                        L = L + 1;
                        if (L == 3)
                        {
                            break;
                        }
                    }
                }
            }
            string Enunciado_1 = Enunciado.Substring(0, Valor[0] - 1); // calcula una variable inicial y una intermedia
            string Enunciado_2 = Enunciado.Substring(Valor[1], Valor[2] - Valor[1] - 1); // busca el tercer percentil de 25%
            Datos.Valor_1 = "\"" + Enunciado_1 + "\"";  // Variable 1
            Datos.Valor_2 = "\"" + Enunciado_2 + "\"";  // Variable 2          
            return Datos;
        }

        public string Logica_Palabras_Claves(string Enunciado)
        {
            return Correccion_Profesor_Limpio(Enunciado);
        }

    }
}

