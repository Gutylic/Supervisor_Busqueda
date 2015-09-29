using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public class Bloque_Consola_De_Control
    {
        DataClassesDataContext db = new DataClassesDataContext();

        int? Categoria;
        int? ID_Administrador;
        int? ID_Empresa;

        public class Tres_Datos_Int_Para_Loguearse // clase extra utilizada para que alguna clase me devuelva dos valores
        {
            public int? Identificador_Administrador { get; set; }
            public int? Identificador_Empresa { get; set; }
            public int? Categoria { get; set; }
        }

        public Tres_Datos_Int_Para_Loguearse Ingresar_Como_Administrador(string Administrador, string Empresa, string Password, int Ingreso, string IP_Address)
        {
            Tres_Datos_Int_Para_Loguearse Datos = new Tres_Datos_Int_Para_Loguearse();
            db.Logueo_Administrador(Administrador, Password, Empresa,IP_Address, Ingreso, ref Categoria, ref ID_Administrador, ref ID_Empresa);
            Datos.Identificador_Administrador = ID_Administrador;
            Datos.Identificador_Empresa = ID_Empresa;
            Datos.Categoria = Categoria;
            return Datos;

        }

    }
}

