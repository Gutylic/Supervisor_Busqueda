using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Logica;

namespace Busqueda
{
    public partial class Enunciado_Por_Profundidad : System.Web.UI.Page
    {
        Logica_Bloque_Buscar_Por_Enunciado LBBPE = new Logica_Bloque_Buscar_Por_Enunciado();
        protected void Page_Load(object sender, EventArgs e)
        {
            Etiqueta_Administrador_Chico.Text = ((string)Session["Administrador"]).ToUpper();
            Etiqueta_Administrador_Grande.Text = ((string)Session["Administrador"]).ToUpper();
            Etiqueta_Hora_Grande.Text = DateTime.Now.ToString();
            Etiqueta_Hora_Chica.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            Etiqueta_Localizador_Grande.Text = Request.UserHostAddress.ToString();
            Etiqueta_Localizador_Chico.Text = Request.UserHostAddress.ToString();

            if (!Page.IsPostBack) // la primera vez que carga
            {
                Cargar_Variables_De_URL(Request.QueryString["Enunciado"]); // carga las variables de la URL                
                Listado_De_Parecidos((string)ViewState["Enunciado"], 0); // Llama al datalist de enunciados parecidos, desde la pagina cero
                Condiciones_Paginacion(); // datos para armado de la paginacion del datalist

            }
        }

        protected void Volver_A_Consola_Click(object sender, EventArgs e)
        {
            Response.Redirect("Buscar_Ejercicio.aspx");
        }

        #region Variables

        public void Cargar_Variables_De_URL(string Enunciado)
        {
            ViewState["Enunciado"] = Enunciado; // recupera desde el URL el Enunciado1
        }

        #endregion




        #region DataList



        public void Listado_De_Parecidos(string Enunciado, int Pagina)
        {
            Resultado_DataList.DataSource = LBBPE.Logica_Mostrar_Ejercicios_Profundidad(Enunciado).Skip(Pagina * 10).Take(10); // datalist que muestra los enunciados similares de a 10 datos 
            Resultado_DataList.DataBind();
        }



        #endregion


        #region Paginacion_Del_DataList
        public void Condiciones_Paginacion()
        {
            ViewState["Pagina_Enunciado"] = 0; // arranca de la pagina cero
            Centros_Paginados.Visible = false; // contenedor de los paginados siguiente y anterior centrales
            Siguiente_Primero.Visible = true; // siguiente primero arranca true
            Anterior_Ultimo.Visible = false; // anterior ultimo es false
            ViewState["Cantidad_De_Datos_Enunciado"] = LBBPE.Logica_Contar_Ejercicios_Profundidad((string)ViewState["Enunciado"]); //cantidad de datos al buscar por enunciados            
            if ((int)ViewState["Cantidad_De_Datos_Enunciado"] == 0)
            {
                Lista.Visible = false;
                return;
            }
            Lista.Visible = true;
            ViewState["Cantidad_De_Paginas_Enunciado"] = (int)ViewState["Cantidad_De_Datos_Enunciado"] / 10; //cantidad de paginas que se generan empezando por el cero
            ViewState["Resto_Enunciado"] = (int)ViewState["Cantidad_De_Datos_Enunciado"] % 10; // cantidad de ejercicios que faltan para completar una hoja
            if ((int)ViewState["Resto_Enunciado"] == 0) // si el resto es exacto necesito una hoja menos porque se arranca de la hoja cero
            {
                ViewState["Cantidad_De_Paginas_Enunciado"] = (int)ViewState["Cantidad_De_Paginas_Enunciado"] - 1; // resto una hoja
            }
            if ((int)ViewState["Cantidad_De_Datos_Enunciado"] <= 10) // si cuento con menos de 10 datos no muestra siguiente primero
            {
                Siguiente_Primero.Visible = false;
            }
        }

        protected void Siguiente_Click(object sender, EventArgs e)
        {
            ViewState["Pagina_Enunciado"] = (int)ViewState["Pagina_Enunciado"] + 1; // se suma una hoja
            if ((int)ViewState["Pagina_Enunciado"] == (int)ViewState["Cantidad_De_Paginas_Enunciado"]) // se fija si estoy en la ultima hoja
            {
                Listado_De_Parecidos((string)ViewState["Enunciado"], (int)ViewState["Pagina_Enunciado"]); // llama al datalist 
                Centros_Paginados.Visible = false; // como es la ultima pagina la paginacion centrada es falsa
                Extremos_Paginados.Visible = true; // como es la ultima pagina la paginacion externa es verdadera
                Siguiente_Primero.Visible = false; // siguiente primero es falso pues estoy en la ultima hoja
                Anterior_Ultimo.Visible = true; // anterior ultimo verdadero pues estoy en la ultima hoja
            }
            else // si no estoy en la ultima hoja
            {
                Listado_De_Parecidos((string)ViewState["Enunciado"], (int)ViewState["Pagina_Enunciado"]); // llama al datalist
                Centros_Paginados.Visible = true; // solo muestra los paginados centrales de siguiente y anterior
                Extremos_Paginados.Visible = false; // no muestra los paginados externos de siguiente y anterior porque no estoy ni en la primera ni en la ultima hoja
            }
        }

        protected void Anterior_Click(object sender, EventArgs e)
        {
            ViewState["Pagina_Enunciado"] = (int)ViewState["Pagina_Enunciado"] - 1; //se resta una hoja
            if ((int)ViewState["Pagina_Enunciado"] == 0) // estoy en la primera pagina
            {
                Listado_De_Parecidos((string)ViewState["Enunciado"], (int)ViewState["Pagina_Enunciado"]); // llama al datalist
                Centros_Paginados.Visible = false; // como es la ultima pagina la paginacion centrada es falsa
                Extremos_Paginados.Visible = true; // como es la ultima pagina la paginacion externa es verdadera
                Siguiente_Primero.Visible = true;// siguiente primero es falso pues estoy en la ultima hoja
                Anterior_Ultimo.Visible = false;// anterior ultimo verdadero pues estoy en la ultima hoja
            }
            else // no estoy en la primera hoja
            {
                Listado_De_Parecidos((string)ViewState["Enunciado"], (int)ViewState["Pagina_Enunciado"]); // llama al datalist
                Centros_Paginados.Visible = true; // aparece pues no estoy ni en la primera ni en la ultima hoja 
                Extremos_Paginados.Visible = false; // no muestra los paginados externos de siguiente y anterior porque no estoy en la primera pagina
            }
        }

        #endregion

    }
}