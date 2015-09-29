using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Logica_Bloque_Consola_De_Control
    {

        Bloque_Consola_De_Control BCDC = new Bloque_Consola_De_Control();

        public class Tres_Datos_Int_Para_Loguearse // clase extra utilizada para que alguna clase me devuelva dos valores
        {
            public int? Identificador_Administrador { get; set; }
            public int? Identificador_Empresa { get; set; }
            public int? Categoria { get; set; }
        }


        public Tres_Datos_Int_Para_Loguearse Logica_Ingresar_Como_Administrador(string Administrador, string Password, string Empresa, int Ingreso, string IP_Address)
        {
            Tres_Datos_Int_Para_Loguearse Datos = new Tres_Datos_Int_Para_Loguearse();

            Datos.Identificador_Administrador = BCDC.Ingresar_Como_Administrador(Administrador, Empresa, Password, Ingreso, IP_Address).Identificador_Administrador;
            Datos.Identificador_Empresa = BCDC.Ingresar_Como_Administrador(Administrador, Empresa, Password, Ingreso, IP_Address).Identificador_Empresa;
            Datos.Categoria = BCDC.Ingresar_Como_Administrador(Administrador, Empresa, Password, Ingreso, IP_Address).Categoria;
            if (Datos.Categoria == null)
            {
                Datos.Categoria = -10;
            }

            return Datos;

        }

        

    }
}
