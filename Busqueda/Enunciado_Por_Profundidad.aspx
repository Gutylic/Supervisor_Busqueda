<%@ Page Language="C#" ValidateRequest="false" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Enunciado_Por_Profundidad.aspx.cs" Inherits="Busqueda.Enunciado_Por_Profundidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="generator" content="Bootply" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href="css/bootstrap.min.css" rel="stylesheet">

<link href="css/enunciado_por_profundidad.css" rel="stylesheet" />
<link href="css/Encabezado.css" rel="stylesheet" />
    <title>Buscar por Profundidad</title>
</head>
<body>
    <form id="form1" runat="server">   
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
        <div>

           <div class="container">
                      
            
             <nav class="navbar navbar-fixed-top header fondo_encabezado">
 	            <div class="container"> 
                                         
                    <div class="row">
                        <div class="col-xs-12 visible-xs administrador" >
                            <asp:Label ID="Administrador_chico" runat="server" Text="">Adm:</asp:Label>
                            <asp:Label ID="Etiqueta_Administrador_Chico" CssClass ="etiqueta_administrador_chico" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col-xs-12 hidden-xs administrador">
                            <asp:Label ID="Administrador_grande" runat="server" Text="">Administrador:</asp:Label>
                            <asp:Label ID="Etiqueta_Administrador_Grande" CssClass ="etiqueta_administrador_grande" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-4 visible-xs ip chico">
                            <asp:Label ID="Localizador_chico" runat="server">Desde:</asp:Label>
                            <asp:Label ID="Etiqueta_Localizador_Chico" CssClass ="etiqueta_administrador_chico" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col-xs-4 hidden-xs ip chico">
                            <asp:Label ID="Localizador_Grande" runat="server">Conectado:</asp:Label>
                            <asp:Label ID="Etiqueta_Localizador_Grande" CssClass ="etiqueta_administrador_chico" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col-xs-4 consola_de_control" style="text-align:center; ">
                            <h1 class="titulo">Buscador</h1>
                        </div>
                        <div class="col-xs-4 cerrar_session">                             
                            <asp:LinkButton ID="Volver_A_Consola" ToolTip="Volver a Consola de Control" runat="server" OnClick="Volver_A_Consola_Click">X</asp:LinkButton>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 visible-xs hora_chica_num" >
                            <asp:Label ID="Hora_chico" runat="server" >Hora:</asp:Label>
                            <asp:Label ID="Etiqueta_Hora_Chica" runat="server" ></asp:Label>
                        </div>
                        <div class="col-xs-12 hidden-xs hora_grande" >
                            <asp:Label ID="Hora_grande" runat="server" >Hora de Conexión:</asp:Label>
                            <asp:Label ID="Etiqueta_Hora_Grande" runat="server" ></asp:Label>
                        </div>
                    </div>
                </div>
             </nav>
        </div> 
            

            <div class="navbar navbar-default" id="subnav">
                    <div class="col-md-12"></div>	
                </div>

             <div class="container" id="main">
                <div class="row">
                    <div class="col-xs-12">       
                        <div class="panel panel-default" id="Lista" runat="server">                             
                            <div class="encabezado_panel panel-heading fondo"><h4 class="datos_del_administrador">Datos del Administrador</h4></div>                 
                            <div class="panel-body"> 
                              <div class="row body">           
                                <asp:DataList ID="Resultado_DataList" style="width: 100%;" runat="server">
                                    <ItemTemplate>

                                        
                                            <div class="col-xs-1 numero_datalist ">
                                                <asp:Label ID="Etiqueta_Ejercicio" Class="lo" runat="server" Text='<%# Eval("ID_Ejercicio") %>'> </asp:Label>
                                            </div>
                                            <div class="col-xs-10 ejercicio_datalist ">                                                
                                                <asp:Image ID="Imagen" CssClass="imagen"  ImageUrl='<%# "http://www.colegioeba.com/enunciado/Enunciado" + Eval("ID_Ejercicio") + ".png" %>'  runat="server" />
                                            </div>
                                        
                                                                           
                                    </ItemTemplate>
                                </asp:DataList>
                             </div>          
                            </div>            
                            <div class="panel-footer">    
                                <div class="row">
                                    <div id="Centros_Paginados" runat="server" visible="false">
                                        <asp:LinkButton ID="Anterior" runat="server" OnClick="Anterior_Click" style="text-decoration:none" >Anterior &nbsp</asp:LinkButton>
                                      <asp:LinkButton ID="Siguiente" runat="server" OnClick="Siguiente_Click" style="text-decoration:none" >&nbsp Siguiente </asp:LinkButton>
                                        
                                    </div>
                                    <div id="Extremos_Paginados" runat="server">
                                        <asp:LinkButton ID="Siguiente_Primero" runat="server" OnClick="Siguiente_Click" style="text-decoration:none" >Siguiente </asp:LinkButton>
                                        <asp:LinkButton ID="Anterior_Ultimo" runat="server" visible="false" OnClick="Anterior_Click" style="text-decoration:none" >Anterior</asp:LinkButton>  
                                    </div>                                   
                                </div>                                        
                            </div>
                        </div>
                    </div>
                  </div>
                </div>
            
                    <hr />
                    
                    <footer>
                        <div class=" container">
                            <div class="row">
                                <div class="col-xs-12">
                                    <h6>Copyrigth®2015 - Webmaster Martina Ivana Romero</h6>
                                </div>
                                
                            </div>
                        </div>
                    </footer>
                

<!-- script references -->
<script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/scripts.js"></script>


        </div>
    </form>
</body>
</html>

