<%@ Page Language="C#" ValidateRequest="false" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Busqueda.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Supervisión Martiva</title>
    <script src="//code.jquery.com/jquery-1.11.o.min.js"></script>
    <script src="//code.jquery.com/ui/1.11.0/jquery-ui.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css">
    <link rel="stylesheet" href="css/index.css" />
    <script>
        // funcion de Abandono de Session
        function session_expirada() {
            $.ajax({
                type: "POST",
                url: "index.aspx/Abandonar_Session",
                data: {},
                contenType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
            });
        }
        //fin de la funcion

        function validar_textbox() {

            var cliente = false; // permite al boton ser de servidor 

            if ($("#Empresa_TextBox").val().indexOf('@', 0) == -1) // mira si el correo tiene un @ y un punto para validarlo
            {
                var cliente = true;// no permite que el boton sea de servidor
            }
            if (cliente) { // validacion para pasar al servidor el boton                
                return false;
            }
            else {

                return true;
            }
        }


    </script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="container">
                <div class="row">
                    <div class="col-md-3 hidden-xs"></div>
                    <div class="col-md-6 col-xs-12">
           
                        <div class="panel caracteristicas_panel">
                            <div class="panel-heading caracteristicas_heading">Ingrese su Clave</div>
                                <div class="panel-body">
    
                                    <div class="input-group">
                            
                                        <asp:TextBox ID="Administrador" class="form-control" placeholder="Usuario" runat="server"></asp:TextBox>
                                        <span class="input-group-addon" id="basic-addon2"><span class="glyphicon glyphicon-user"></span></span>
                      
                                    </div>
  
                                    <div class="input-group">

                                        <asp:TextBox ID="Password" class="form-control" TextMode="Password" placeholder="Contraseña" runat="server"></asp:TextBox>
                                        <span class="input-group-addon" id="basic-addon22"><span class="glyphicon glyphicon-pencil"></span></span>
                        
                                    </div>

                                    <div class="input-group">

                                        <asp:TextBox ID="Empresa" class="form-control" placeholder="Empresa" runat="server"></asp:TextBox>
                                        <span class="input-group-addon" id="Empresa_TextBox"><span class="glyphicon glyphicon-globe" onblur="validar_textbox()" ></span></span>
                        
                                    </div>

                        
                                    <div class="row">

                                        <div class="col-xs-1">
                                
                                            <asp:CheckBox ID="Check_Session" runat="server" />

                                        </div>

                                        <div class="col-xs-11">

                                            <div class="mantener_session">Mantener Sesión</div>

                                        </div>

                                    </div>
                                               
                                </div>

                                <div class="panel-footer">
                                    <asp:UpdatePanel ID="Actualizar_Boton_Acceso" runat="server">
                                        <ContentTemplate>
                                            <asp:Button ID="Boton_Acceso" runat="server" CssClass="btn btn-info" Text="Acceder al Panel de Control" OnClick="Boton_Acceso_Click" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>

                        </div>
        
                        <div class="col-md-3 hidden-xs" ></div>

                    </div>
                </div>
            </div>
    </form>
</body>
</html>

